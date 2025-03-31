using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using KingMeServer;

namespace PI_3_Defensores_de_Hastings
{
    public partial class Form2 : Form
    {
        private string estadoJogo;
        private string[] arEstadoDoJogo;
        private Panel pnlPersonagem;

        public Form2(string estadoDoJogo)
        {
            InitializeComponent();
            estadoJogo = estadoDoJogo;
            arEstadoDoJogo = estadoJogo.Split(',');
            CarregarImagem();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CarregarImagem();
        }

        private void CarregarImagem()
        {
            string imagePath = @"C:\Users\fernando.barreto\OneDrive - Solutta\Documentos\GitHub\Hastings\PI_3_Defensores_de_Hastings\imagens\tabuleiro.jpg";

            if (File.Exists(imagePath))
            {
                if (pictureBox1.Image == null)
                {
                    using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        pictureBox1.Image = Image.FromStream(fs);
                    }
                }
            }
            else
            {
                MessageBox.Show("Imagem não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Colocar1()
        {
            if (arEstadoDoJogo == null || arEstadoDoJogo.Length < 2)
            {
                MessageBox.Show("Dados do jogo incompletos!");
                return;
            }

            string nivel = arEstadoDoJogo[0];
            string letraPersonagem = arEstadoDoJogo[1].Replace("'", "").Trim().ToUpper();

            Dictionary<string, string> personagensDict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "A", "Adilson Konrad.png" }, { "B", "Beatriz Paiva.png" }, { "C", "Claro.png" },
                { "D", "Douglas Baquiao.png" }, { "E", "Eduardo Takeo.png" }, { "G", "Guilherme Rey.png" },
                { "H", "Heredia.png" }, { "K", "Kelly Kiyumi.png" }, { "L", "Leonardo Takuno.png" },
                { "M", "Mario Toledo.png" }, { "Q", "Quintas.png" }, { "R", "Ranulfo.png" },
                { "T", "Toshio.png" }
            };

            if (nivel == "1" && personagensDict.TryGetValue(letraPersonagem, out string nomeArquivo))
            {
                string caminhoImagem = Path.Combine(@"C:\Users\fernando.barreto\OneDrive - Solutta\Documentos\GitHub\Hastings\PI_3_Defensores_de_Hastings\imagens", nomeArquivo);

                if (!File.Exists(caminhoImagem))
                {
                    MessageBox.Show($"Arquivo não encontrado: {caminhoImagem}");
                    return;
                }

                // Se o painel do personagem ainda não foi criado, cria e adiciona ao pictureBox1
                if (pnlPersonagem == null)
                {
                    pnlPersonagem = new Panel
                    {
                        Size = new Size(50, 50),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Location = new Point(275, 535)
                    };
                    pictureBox1.Controls.Add(pnlPersonagem);
                }

                try
                {
                    using (FileStream fs = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read))
                    {
                        pnlPersonagem.BackgroundImage = Image.FromStream(fs);
                    }
                    pnlPersonagem.BringToFront();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar imagem: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show($"Personagem '{letraPersonagem}' não encontrado. Opções válidas: " +
                                string.Join(", ", personagensDict.Keys));
            }
        }

        private void PromoverPersonagem()
        {
            if (pnlPersonagem == null)
            {
                MessageBox.Show("Nenhum personagem para promover!");
                return;
            }

            int novaPosicaoY = pnlPersonagem.Location.Y - 50;

            if (novaPosicaoY < 0)
            {
                novaPosicaoY = 0;
            }

            pnlPersonagem.Location = new Point(pnlPersonagem.Location.X, novaPosicaoY);
        }

        private void btnColocarPerso_Click(object sender, EventArgs e)
        {
            Colocar1();
        }

        private void btnPromover_Click(object sender, EventArgs e)
        {
            PromoverPersonagem();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }
    }
}
