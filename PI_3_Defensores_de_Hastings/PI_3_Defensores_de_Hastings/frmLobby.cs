using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;

namespace PI_3_Defensores_de_Hastings
{
    public partial class frmLobby: Form
    {
        public frmLobby()
        {
            InitializeComponent();

            dgvPartidas.DataSource = Partida.ListarPartidas();

            dgvPartidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPartidas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPartidas.AllowUserToResizeRows = false;
            dgvPartidas.AllowUserToResizeColumns = false;
            dgvPartidas.RowHeadersVisible = false;
            dgvPartidas.MultiSelect = false;

            dgvPartidas.Columns[0].Visible = true;
            dgvPartidas.Columns[1].HeaderText = "Nome da Partida";
            dgvPartidas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

           
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

         
        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            Partida match = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;

            string nomeJogador = txtbNomeDoJogador.Text;
            string senhaSala = txtbSenhaDaSala.Text;
            int idSala = match.id;

            

            string IdJogador = KingMeServer.Jogo.Entrar(idSala, nomeJogador, senhaSala);

            string[] Info = IdJogador.Split(','); 

            string idJogador = Info[0];
            string senhaJogador = Info[1];

            if (nomeJogador == string.Empty)
            {
                MessageBox.Show("Insira o seu nome: ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (senhaSala == string.Empty)
            {
                MessageBox.Show("Insira a sua senha: ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


             frmLobbyDaPartida gameLobby = new frmLobbyDaPartida(idSala, idJogador, senhaJogador);
             gameLobby.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lsb_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
