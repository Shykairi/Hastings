using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PI_3_Defensores_de_Hastings
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CarregarImagem(); // Carrega a imagem ao iniciar o Form
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CarregarImagem();
        }

        private void CarregarImagem()
        {
            string imagePath = @"C:\Users\fernando.barreto\OneDrive - Solutta\Documentos\GitHub\Hastings\imagens\tabuleiro.jpg";

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
    }
}
