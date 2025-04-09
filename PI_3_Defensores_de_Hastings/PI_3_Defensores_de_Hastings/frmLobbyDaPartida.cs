using KingMeServer;
using System.Collections.Generic;
using System.Windows.Forms;
using System;


using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;

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
            txtID.Text = lblMostraID.Text; // O ID do jogador é obtido do label
            txtSenha.Text = lblMostraSenha.Text; // A senha é obtida do label
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
            Colocar();
        }

        private string _resultadoFinal; // Variável de instância para armazenar o resultado
        private void Colocar()
        {
            string senha = txtSenha.Text;
            string TempSetor = txtEscolheSetor.Text;
            int setor = Convert.ToInt32(TempSetor);
            string personagem = txtEscolhaPersonagem.Text;
            string TempIdJogador = lblMostraID.Text;
            int IdJogador = Convert.ToInt32(TempIdJogador);

            string estadoDoJogo = Jogo.ColocarPersonagem(IdJogador, senha, setor, personagem);

            string[] linhas = estadoDoJogo.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            lstEstadoDoJogo.Items.Clear();
            
            
            List<string> linhasFormatadas = new List<string>();

            foreach (string linha in linhas)
            {  
                lstEstadoDoJogo.Items.Add(linha);
            }
            
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

        

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            // Obtém a string de verificação do jogo
            string verificacao = Jogo.VerificarVez(_idSala);

            
            List<string> linhasFormatadas = new List<string>();

            string[] atualizar = verificacao.Split('\n');
            
            lstbVerificarVez.Items.Clear(); // Limpa o ListBox antes de adicionar novos itens
            
            foreach (string linha in atualizar)
            {
                lstbVerificarVez.Items.Add(linha);
                string[] setorJogador = linha.Split(',');
                // Verifica se a linha tem exatamente duas partes (setor e personagem)
                if (setorJogador.Length == 2)
                {
                    // Formata a linha no formato 'setor,personagem'
                    string linhaFormatada = $"{setorJogador[0]},{setorJogador[1]}";
                    linhasFormatadas.Add(linhaFormatada);
                }


            }
            // Junta todas as linhas formatadas em uma única string, separadas por aspas simples
            _resultadoFinal = string.Join("$", linhasFormatadas);

            // Se desejar continuar exibindo apenas a vez em lblMostraVez:
            string[] partes = verificacao.Split(',');
            if (partes.Length > 0)
            {
              lblMostraVez.Text = partes[0];
            }
        }
  
        private void btnVerMapa_Click(object sender, EventArgs e)
        {
          
            Form2 mapa = new Form2(_resultadoFinal);
            mapa.ShowDialog();
        }
  
        private void btnVotar_Click(object sender, EventArgs e)
        {
            int jogador = Convert.ToInt32(txtID.Text);
            string senha = lblMostraSenha.Text;
            string voto = txtVoto.Text; // Assumindo que há um campo para capturar o voto

            Jogo.Votar(jogador, senha, voto);
        }

        private void btnPromover_Click(object sender, EventArgs e)
        {
            promover();
        }

        private void promover()
        {
            int jogador = Convert.ToInt32(txtID.Text);
            string senha = txtSenha.Text;
            string promocao = txtEscolhaPersonagem.Text;

            Jogo.Promover(jogador, senha, promocao);
        }

    }
}
