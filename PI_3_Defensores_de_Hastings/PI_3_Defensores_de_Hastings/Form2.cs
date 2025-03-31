using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PI_3_Defensores_de_Hastings
{
    public partial class Form2 : Form
    {
        private readonly string estadoJogo;
        private readonly string[] arEstadoDoJogo;
        private readonly Panel pnlPersonagem;
        private readonly Dictionary<string, string> _personagensDict = new()
        {
            { "A", "Adilson Konrad.png" }, { "B", "Beatriz Paiva.png" }, { "C", "Claro.png" },
            { "D", "Douglas Baquiao.png" }, { "E", "Eduardo Takeo.png" }, { "G", "Guilherme Rey.png" },
            { "H", "Heredia.png" }, { "K", "Kelly Kiyumi.png" }, { "L", "Leonardo Takuno.png" },
            { "M", "Mario Toledo.png" }, { "Q", "Quintas.png" }, { "R", "Ranulfo.png" },
            { "T", "Toshio.png" }
        };

        public Form2(string estadoDoJogo)
        {
            InitializeComponent();
            estadoJogo = estadoDoJogo;
            arEstadoDoJogo = estadoJogo.Split(',');
            
            pnlPersonagem = new Panel
            {
                Size = new Size(50, 50),
                BackgroundImageLayout = ImageLayout.Stretch,
                Location = new Point(275, 535)
            };
            Controls.Add(pnlPersonagem);

            CarregarImagemTabuleiro();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CarregarImagemTabuleiro();
        }

        private void CarregarImagemTabuleiro()
        {
            string imagePath = @"C:\\Users\\willi\\Downloads\\Hastings\\imagens\\tabuleiro.jpg";
            pictureBox1.Image = CarregarImagemDeArquivo(imagePath);
        }

        private Image CarregarImagemDeArquivo(string caminho)
        {
            if (!File.Exists(caminho))
            {
                MessageBox.Show($"Imagem não encontrada: {caminho}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
            using FileStream fs = new FileStream(caminho, FileMode.Open, FileAccess.Read);
            return Image.FromStream(fs);
        }

        private void Colocar1()
        {
            if (!ValidarEstadoJogo(out string nivel, out string letraPersonagem)) return;

            if (nivel == "1" && _personagensDict.TryGetValue(letraPersonagem, out string nomeArquivo))
            {
                AtualizarImagemPersonagem(nomeArquivo);
            }
            else
            {
                MessageBox.Show($"Personagem '{letraPersonagem}' não encontrado.");
            }
        }

        private bool ValidarEstadoJogo(out string nivel, out string letraPersonagem)
        {
            nivel = null;
            letraPersonagem = null;

            if (arEstadoDoJogo == null || arEstadoDoJogo.Length < 2)
            {
                MessageBox.Show("Dados do jogo incompletos!");
                return false;
            }

            nivel = arEstadoDoJogo[0];
            letraPersonagem = arEstadoDoJogo[1].Replace("'", "").Trim().ToUpper();
            return true;
        }

        private void AtualizarImagemPersonagem(string nomeArquivo)
        {
            string caminhoImagem = Path.Combine(@"C:\\Users\\willi\\Downloads\\Hastings\\imagens", nomeArquivo);
            pnlPersonagem.BackgroundImage = CarregarImagemDeArquivo(caminhoImagem);
            pnlPersonagem.BringToFront();
        }

        private void btnColocarPerso_Click(object sender, EventArgs e)
        {
            Colocar1();
        }
    }
}
