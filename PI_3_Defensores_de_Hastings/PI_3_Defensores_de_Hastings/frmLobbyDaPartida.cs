using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;

namespace PI_3_Defensores_de_Hastings
{
    public partial class frmLobbyDaPartida: Form
    {
        private int _idSala;
        
        public frmLobbyDaPartida(int idSala, string a, string b)
        {
            InitializeComponent();
            _idSala = idSala;
            lblMostraID.Text = a;
            lblMostraSenha.Text = b;
        }

        
        private void bntComecar_Click(object sender, EventArgs e)
        {
            string tempID = txtID.Text;
            int ID = Convert.ToInt32(tempID);
            string SENHA = txtSenha.Text;

            Jogo.Iniciar(ID,SENHA);

            ///////////////////
            
            string personagens = Jogo.ListarPersonagens();
            string[] listapersonganes = personagens.Split('\r');
            for (int i = 0; i < listapersonganes.Length; i++)
            {
                lstbPersonagens.Items.Add(listapersonganes[i]);
            }

            string setores = Jogo.ListarSetores();
            string[] listaSetores = setores.Split('\r');

            for (int i = 0; i < listaSetores.Length; i++)
            {
                lstbSetores.Items.Add(listaSetores[i]);
            }
        }
        private void lstbJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void frmLobbyDaPartida_Load(object sender, EventArgs e)
        {

        }

        private void lblNomeJogador_Click(object sender, EventArgs e)
        {

        }

        private void txtbNomeDoJogador_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIdDaSala_Click(object sender, EventArgs e)
        {

        }

        private void txtbIdSala_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbSenhaDaSala_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            string ID = Jogo.ListarJogadores(_idSala);
            ID = ID.Replace("\r", "");
            string[] jogadores = ID.Split('\n');

            lstbJogadores.Items.Clear();
            for (int i = 0; i < jogadores.Length; i++)
            {
                lstbJogadores.Items.Add(jogadores[i]);

            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            string verificacao =  Jogo.VerificarVez(_idSala);
            string[] vez = verificacao.Split(',');

            lblMostraVez.Text = vez[0];
            lblMostraNome.Text = vez[2];
        }

        private void lstbPersonagens_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblMostraNome_Click(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click_1(object sender, EventArgs e)
        {

        }

        private void lblEscreverSenha_Click(object sender, EventArgs e)
        {

        }

        private void lstbVerificarVez_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
