using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;

namespace PI_3_Defensores_de_Hastings
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string partida = listBox1.SelectedItem.ToString();
            string[] dadosDaPartida = partida.Split(',');

            int idPartida = Convert.ToInt32(dadosDaPartida[0]);
            string nomeDaPartida = dadosDaPartida[1];
            string dataDaPartida = dadosDaPartida[2];

            string retorno = Jogo.ListarJogadores(idPartida);
            retorno = retorno.Replace("\r", "");
            string[] jogadores = retorno.Split('\n');

            listBox2.Items.Clear();
            for (int i = 0; i < jogadores.Length - 1; i++)
            {
                listBox2.Items.Add(jogadores[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");


            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');

            listBox1.Items.Clear();
            for (int i = 0; i < partidas.Length - 1; i++)
            {
                listBox1.Items.Add(partidas[i]);
            }
        }
    }
}
