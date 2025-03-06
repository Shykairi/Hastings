using KingMeServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_3_Defensores_de_Hastings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblControleDeVersao.Text = Jogo.versao;
        }

        private void button1_Click_1(object sender, EventArgs e)
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
        private void btnPartida_Click(object sender, EventArgs e)
        {
            string nome = nomeDaPartida.Text;
            string senha = senhaDaPartida.Text;
            string grupo = nomeDoGrupo.Text;

            string id = KingMeServer.Jogo.CriarPartida(nome, senha, grupo);
            idDaPartida.Text = id;

            if (nome == string.Empty)
            {
                MessageBox.Show("Insira o nome da partida: ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (senha == string.Empty)
            {
                MessageBox.Show("Insira a sua senha: ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (grupo == string.Empty)
            {
                MessageBox.Show("Insira o nome do grupo: ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string partida = listBox1.SelectedItem.ToString();
            string[] dadosDaPartida = partida.Split(',');

            int idPartida = Convert.ToInt32(dadosDaPartida[0]);
            string nomeDaPartida = dadosDaPartida[1];
            string dataDaPartida = dadosDaPartida[2];

            lblData.Text = dataDaPartida;

            string retorno = Jogo.ListarJogadores(idPartida);
            if (retorno.Substring(0,4) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro:\n" + retorno.Substring(5),"Defensores de Hastings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            retorno = retorno.Replace("\r", "");
            string[] jogadores = retorno.Split('\n');

            listBox2.Items.Clear();
            for (int i = 0; i < jogadores.Length - 1; i++)
            {
                listBox2.Items.Add(jogadores[i]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void idDaPartida_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}