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

        
        public Form2(string estadoDoJogo)
        {
            InitializeComponent();
            estadoJogo = estadoDoJogo;
            arEstadoDoJogo = estadoDoJogo.Split(',');
            CarregarImagem();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CarregarImagem();
        }

        private void CarregarImagem()
        {
            string imagePath = @"C:\Users\willi\Downloads\Hastings\PI_3_Defensores_de_Hastings\imagens\tabuleiro.jpg";

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

            int lvlPersonagens1 = 0;
            int lvlPersonagens2 = 0;
            int lvlPersonagens3 = 0;
            int lvlPersonagens4 = 0;
            int posicaox1 = 0;
            int posicaox2 = 0;
            int posicaox3 = 0;
            int posicaox4 = 0;

            if (nivel == "1" && personagensDict.TryGetValue(letraPersonagem, out string nomeArquivo))
            {
                string caminhoImagem = Path.Combine(@"C:\Users\willi\Downloads\Hastings\PI_3_Defensores_de_Hastings\imagens", nomeArquivo);

                if (!File.Exists(caminhoImagem))
                {
                    MessageBox.Show($"Arquivo não encontrado: {caminhoImagem}");
                    return;
                }

                if (lvlPersonagens1 == 0)
                {
                    posicaox1 = 275;
                    lvlPersonagens1++;
                }
                else if (lvlPersonagens1 == 1)
                {
                    posicaox1 = 235;
                    lvlPersonagens1++;
                }
                else if (lvlPersonagens1 == 2)
                {
                    posicaox1 = 195;
                    lvlPersonagens1++;
                }
                else if (lvlPersonagens1 == 3)
                {
                    posicaox1 = 155;
                    lvlPersonagens1++;
                }

                // Cria um NOVO painel para cada personagem
                Panel novoPersonagem = new Panel
                {
                    Size = new Size(50, 50),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Location = new Point(posicaox1, 535)
                };

                try
                {
                    using (FileStream fs = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read))
                    {
                        novoPersonagem.BackgroundImage = Image.FromStream(fs);
                    }
                    pictureBox1.Controls.Add(novoPersonagem);
                    novoPersonagem.BringToFront();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar imagem: {ex.Message}");
                }
            }
            else if (nivel == "2" && personagensDict.TryGetValue(letraPersonagem, out string nomeArquivo2))
            {
                string caminhoImagem = Path.Combine(@"C:\Users\willi\Downloads\Hastings\PI_3_Defensores_de_Hastings\imagens", nomeArquivo2);

                if (!File.Exists(caminhoImagem))
                {
                    MessageBox.Show($"Arquivo não encontrado: {caminhoImagem}");
                    return;
                }

                if (lvlPersonagens2 == 0)
                {
                    posicaox2 = 275;
                    lvlPersonagens2++;
                }
                else if (lvlPersonagens2 == 1)
                {
                    posicaox2 = 235;
                    lvlPersonagens2++;
                }
                else if (lvlPersonagens2 == 2)
                {
                    posicaox2 = 195;
                    lvlPersonagens2++;
                }
                else if (lvlPersonagens2 == 3)
                {
                    posicaox2 = 155;
                    lvlPersonagens2++;
                }

                Panel novoPersonagem = new Panel
                {
                    Size = new Size(50, 50),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Location = new Point(posicaox2, 435)
                };

                try
                {
                    using (FileStream fs = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read))
                    {
                        novoPersonagem.BackgroundImage = Image.FromStream(fs);
                    }
                    pictureBox1.Controls.Add(novoPersonagem);
                    novoPersonagem.BringToFront();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar imagem: {ex.Message}");
                }
            }
            else if (nivel == "3" && personagensDict.TryGetValue(letraPersonagem, out string nomeArquivo3))
            {
                string caminhoImagem = Path.Combine(@"C:\Users\willi\Downloads\Hastings\PI_3_Defensores_de_Hastings\imagens", nomeArquivo3);

                if (!File.Exists(caminhoImagem))
                {
                    MessageBox.Show($"Arquivo não encontrado: {caminhoImagem}");
                    return;
                }

                if (lvlPersonagens3 == 0)
                {
                    posicaox3 = 275;
                    lvlPersonagens3++;
                }
                else if (lvlPersonagens3 == 1)
                {
                    posicaox3 = 235;
                    lvlPersonagens3++;
                }
                else if (lvlPersonagens3 == 2)
                {
                    posicaox3 = 195;
                    lvlPersonagens3++;
                }
                else if (lvlPersonagens3 == 3)
                {
                    posicaox3 = 155;
                    lvlPersonagens3++;
                }

                Panel novoPersonagem = new Panel
                {
                    Size = new Size(50, 50),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Location = new Point(posicaox3, 355)
                };

                try
                {
                    using (FileStream fs = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read))
                    {
                        novoPersonagem.BackgroundImage = Image.FromStream(fs);
                    }
                    pictureBox1.Controls.Add(novoPersonagem);
                    novoPersonagem.BringToFront();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar imagem: {ex.Message}");
                }
            }
            else if (nivel == "4" && personagensDict.TryGetValue(letraPersonagem, out string nomeArquivo4))
            {
                string caminhoImagem = Path.Combine(@"C:\Users\willi\Downloads\Hastings\PI_3_Defensores_de_Hastings\imagens", nomeArquivo4);

                if (!File.Exists(caminhoImagem))
                {
                    MessageBox.Show($"Arquivo não encontrado: {caminhoImagem}");
                    return;
                }

                if (lvlPersonagens4 == 0)
                {
                    posicaox4 = 295;
                    lvlPersonagens4++;
                }
                else if (lvlPersonagens4 == 1)
                {
                    posicaox4 = 255;
                    lvlPersonagens4++;
                }
                else if (lvlPersonagens4 == 2)
                {
                    posicaox4 = 215;
                    lvlPersonagens4++;
                }
                else if (lvlPersonagens4 == 3)
                {
                    posicaox4 = 235;
                    lvlPersonagens4++;
                }

                Panel novoPersonagem = new Panel
                {
                    Size = new Size(50, 50),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Location = new Point(posicaox4, 265)
                };

                try
                {
                    using (FileStream fs = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read))
                    {
                        novoPersonagem.BackgroundImage = Image.FromStream(fs);
                    }
                    pictureBox1.Controls.Add(novoPersonagem);
                    novoPersonagem.BringToFront();
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
            // Encontra o último personagem adicionado
            if (pictureBox1.Controls.Count > 0)
            {
                var ultimoPersonagem = pictureBox1.Controls[pictureBox1.Controls.Count - 1];
                int novaPosicaoY = ultimoPersonagem.Location.Y - 50;

                if (novaPosicaoY < 0)
                {
                    novaPosicaoY = 0;
                }

                ultimoPersonagem.Location = new Point(ultimoPersonagem.Location.X, novaPosicaoY);
            }
            else
            {
                MessageBox.Show("Nenhum personagem para promover!");
            }
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
            // Método vazio mantido para compatibilidade
        }
    }
}