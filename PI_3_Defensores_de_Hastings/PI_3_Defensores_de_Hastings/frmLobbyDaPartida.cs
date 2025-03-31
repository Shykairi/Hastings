using KingMeServer;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PI_3_Defensores_de_Hastings
{
    public partial class frmLobbyDaPartida : Form
    {
        private int _idSala;

        public frmLobbyDaPartida(int idSala, string a, string b)
        {
            InitializeComponent();
            _idSala = idSala;

            lblMostraID.Text = a;
            lblMostraSenha.Text = b;

            lblEstadoJogo.Visible = false;
        }

        private void bntComecar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validação do ID do jogador
                if (!int.TryParse(txtID.Text, out int idDoJogador))
                {
                    MessageBox.Show("ID do jogador inválido. Insira um número válido.");
                    return;
                }

                string senha = txtSenha.Text;

                // Inicia o jogo
                Jogo.Iniciar(idDoJogador, senha);

                // Lista as cartas do jogador
                string cartas = Jogo.ListarCartas(idDoJogador, senha);
                txtCartas.Text = cartas;  // Exibe as iniciais das cartas

                // Obtém a lista de personagens
                string retorno = Jogo.ListarPersonagens();
                retorno = retorno.Replace("\r", "").Trim();
                string[] partidas = retorno.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                Dictionary<string, string> personagensDict = new Dictionary<string, string>
                {
                    { "A", "Adilson Konrad" }, { "B", "Beatriz Paiva" }, { "C", "Claro" }, { "D", "Douglas Baquiao" },
                    { "E", "Eduardo Takeo" }, { "G", "Guilherme Rey" }, { "H", "Heredia" }, { "K", "Karin" },
                    { "L", "Leonardo Takuno" }, { "M", "Mario Toledo" }, { "Q", "Quintas" }, { "R", "Ranulffo" },
                    { "T", "Toshio" }
                };

                lstbPersonagens.Items.Clear();

                foreach (string codigo in partidas)
                {
                    string codigoTrimmed = codigo.Trim();
                    lstbPersonagens.Items.Add(personagensDict.ContainsKey(codigoTrimmed) ? personagensDict[codigoTrimmed] : codigoTrimmed);
                }

                // Associar cartas com seus respectivos nomes no ListBox TXBCartas
                TXBCartas.Items.Clear();
                foreach (char letra in cartas)
                {
                    string letraStr = letra.ToString();
                    TXBCartas.Items.Add(personagensDict.ContainsKey(letraStr) ? personagensDict[letraStr] : letraStr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }

            string tempSetores = Jogo.ListarSetores();
            string[] setores = tempSetores.Split('\r');

            lstbSetores.Items.Clear();
            for (int i = 0; i < setores.Length; i++)
            {
                lstbSetores.Items.Add(setores[i]);
            }
        }

        private void btnColocarPersonagem_Click(object sender, EventArgs e)
        {
            string senha = txtSenha.Text;
            string TempSetor = txtEscolheSetor.Text;
            int setor = Convert.ToInt32(TempSetor);
            string personagem = txtEscolhaPersonagem.Text;
            string TempIdJogador = lblMostraID.Text;
            int IdJogador = Convert.ToInt32(TempIdJogador);

            string estadoDoJogo = Jogo.ColocarPersonagem(IdJogador, senha, setor, personagem);

            lstEstadoDoJogo.Items.Clear();
            lstEstadoDoJogo.Items.Add(estadoDoJogo);

            // Essa label serve para pegar o estado do jogo em forma de string para que eu possa passar para o próximo forms
            lblEstadoJogo.Text = estadoDoJogo;
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
            string verificacao = Jogo.VerificarVez(_idSala);
            string[] vez = verificacao.Split(',');

            lblMostraVez.Text = vez[0];
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

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jogo.ListarSetores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jogo.ListarSetores();
        }

        private void lstbSetores_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lblSetor_Click(object sender, EventArgs e)
        {
        }

        private void txtCartas_Click(object sender, EventArgs e)
        {
        }

        private void btnVerMapa_Click(object sender, EventArgs e)
        {
            string estadodojogo = lblEstadoJogo.Text;
            Form2 mapa = new Form2(estadodojogo);
            mapa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
