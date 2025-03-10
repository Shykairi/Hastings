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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PI_3_Defensores_de_Hastings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label6.Text = Jogo.versao;
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

        private void nomeDoGrupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = idDaPartida.Text;
            string nomeDoJOgador = nomeDoJogador.Text;
            string confSenha = confirmarSenha.Text;
            string senha = senhaDaPartida.Text;
            int idDoJogo = Convert.ToInt32(id);

            if (senha != confSenha)
            {
                MessageBox.Show("Senha errada: ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string jogador = Jogo.Entrar(idDoJogo, nomeDoJOgador, confSenha);

            string ID = jogador.Split(',')[0];
            string Senha = jogador.Split(',')[1];

            TXB_SenhaJogador.Text = Senha;
            TXB_IDJogador.Text = ID;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_4(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_5(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Validação do ID do jogador
                if (!int.TryParse(TXB_IDJogador.Text, out int idDoJogador))
                {
                    MessageBox.Show("ID do jogador inválido. Insira um número válido.");
                    return;
                }

                string senha = TXB_SenhaJogador.Text;
                string senhaDaPartida = confirmarSenha.Text;

                // Inicia o jogo
                Jogo.Iniciar(idDoJogador, senha);

                // Lista as cartas do jogador
                string cartas = Jogo.ListarCartas(idDoJogador, senha);
                textBox1.Text = cartas;  // Exibe as iniciais das cartas

                // Obtém a lista de personagens
                string retorno = Jogo.ListarPersonagens();

                // Limpa quebras de linha e outros caracteres indesejados
                retorno = retorno.Replace("\r", "").Trim();
                string[] partidas = retorno.Split('\n');

                // Dicionário que mapeia as iniciais para os nomes completos
                Dictionary<string, string> personagensDict = new Dictionary<string, string>
        {
            { "A", "Adilson Konrad" },
            { "B", "Beatriz Paiva" },
            { "C", "Claro" },
            { "D", "Douglas Baquiao" },
            { "E", "Eduardo Takeo" },
            { "G", "Guilherme Rey" },
            { "H", "Heredia" },
            { "K", "Karin" },
            { "L", "Leonardo Takuno" },
            { "M", "Mario Toledo" },
            { "Q", "Quintas" },
            { "R", "Ranulffo" },
            { "T", "Toshio" }
        };

                // Limpa o ListBox de personagens
                personagens.Items.Clear();

                // Itera sobre os códigos de personagens e exibe o nome completo
                foreach (string codigo in partidas)
                {
                    string codigoTrimmed = codigo.Trim();  // Remove espaços extras

                    if (personagensDict.ContainsKey(codigoTrimmed))
                    {
                        personagens.Items.Add(personagensDict[codigoTrimmed]);  // Adiciona o nome completo
                    }
                    else
                    {
                        personagens.Items.Add(codigoTrimmed);  // Caso não encontre, adiciona o código original
                    }
                }

                // Agora, associar as cartas com seus respectivos nomes no ListBox TXB_Cartas
                TXB_Cartas.Items.Clear(); // Limpa o ListBox de cartas

                // Itera sobre cada caractere da string de cartas (exemplo: "ACDLMR")
                foreach (char letra in cartas)
                {
                    string letraStr = letra.ToString(); // Converte o caractere para string

                    if (personagensDict.ContainsKey(letraStr))
                    {
                        TXB_Cartas.Items.Add(personagensDict[letraStr]); // Adiciona o nome completo da carta
                    }
                    else
                    {
                        TXB_Cartas.Items.Add(letraStr); // Se não encontrar, exibe o código da carta
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }




        private void TXB_IDJogador_TextChanged(object sender, EventArgs e)
        {

        }

        private void personagens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}