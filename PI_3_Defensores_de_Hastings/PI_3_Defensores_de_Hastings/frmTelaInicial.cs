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
    public partial class frmTelaInicial: Form
    {

        private string versao;


        public frmTelaInicial()
        {
            InitializeComponent();
            lblControleVersao.Text = Jogo.versao;
        }

        private void Tela2_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLobby lobby = new frmLobby();
            lobby.ShowDialog();
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            Form1 tela1 = new Form1();
            tela1.versao = this.versao;
            tela1.AtualizarTela();
            tela1.ShowDialog();
        }
    }
}
