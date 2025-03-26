using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PI_3_Defensores_de_Hastings
{
    public partial class Form2 : Form
    {
        private string estadoJogo;
        private string[] arEstadoDoJogo;
        public Form2(string estadoDoJogo)
        {
            InitializeComponent();
            CarregarImagem(); // Carrega a imagem ao iniciar o Form
            estadoJogo = estadoDoJogo;

           arEstadoDoJogo = estadoJogo.Split(',');
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CarregarImagem();
            
        }
        

        private void CarregarImagem()
        {
            string imagePath = @"C:\Users\willi\Downloads\Hastings\imagens\tabuleiro.jpg";
            
         

            if (File.Exists(imagePath))
            {
                if (pictureBox1.Image == null) // Evita recarregar se já estiver carregada
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
            }
            else
            {
                MessageBox.Show("Imagem não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Colocar1()
        {
            // Verifica se temos dados suficientes
            if (arEstadoDoJogo == null || arEstadoDoJogo.Length < 2)
            {
                MessageBox.Show("Dados do jogo incompletos!");
                return;
            }

            // Cria um novo Panel para exibir o personagem
            Panel pnlPersonagem = new Panel();
            pnlPersonagem.Size = new Size(50, 50); // Tamanho reduzido para melhor visualização
            pnlPersonagem.BackgroundImageLayout = ImageLayout.Stretch;
            pnlPersonagem.Location = new Point(275, 535); // Posição fixa inicial - ajuste conforme necessário

            Dictionary<string, string> personagensDict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) // Ignora maiúsculas/minúsculas
    {
        { "A", "Adilson Konrad.png" }, { "B", "Beatriz Paiva.png" }, { "C", "Claro.png" },
        { "D", "Douglas Baquiao.png" }, { "E", "Eduardo Takeo.png" }, { "G", "Guilherme Rey.png" },
        { "H", "Heredia.png" }, { "K", "Kelly Kiyumi.png" }, { "L", "Leonardo Takuno.png" },
        { "M", "Mario Toledo.png" }, { "Q", "Quintas.png" }, { "R", "Ranulfo.png" },
        { "T", "Toshio.png" }
    };

            string nivel = arEstadoDoJogo[0];
            string letraPersonagem = arEstadoDoJogo[1].Replace("'", "").Trim().ToUpper();//força letra maisucula e tira as aspas simples


            // Debug: mostra os valores recebidos
            Console.WriteLine($"Nível: {nivel}, Personagem: {letraPersonagem}");

            if (nivel == "1")
            {
                if (personagensDict.TryGetValue(letraPersonagem, out string nomeArquivo))
                {
                    string caminhoImagem = Path.Combine(@"C:\Users\willi\Downloads\Hastings\imagens", nomeArquivo);

                    if (File.Exists(caminhoImagem))
                    {
                        try
                        {
                            pnlPersonagem.BackgroundImage = Image.FromFile(caminhoImagem);
                            this.Controls.Add(pnlPersonagem);
                            pnlPersonagem.BringToFront(); // Traz para frente de outros controles
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao carregar imagem: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Arquivo não encontrado: {caminhoImagem}");
                    }
                }
                else
                {
                    MessageBox.Show($"Personagem '{letraPersonagem}' não encontrado. Opções válidas: " +
                                  string.Join(", ", personagensDict.Keys));
                }
            }
        }
        private void btnColocarPerso_Click(object sender, EventArgs e)
        {
            Colocar1();
        }
    }
}
