﻿using KingMeServer;
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
        private string _idDoJogador;//um string que recebe o ID do jogador
        private string _senhaDoJogador; // um string que recebe a senha do jogador
        private string _IdDaVez; // um string que recebe o ID de quem é a vez quando é verificado a vez
        private List<string> _letras = new List<string> {"A", "B", "C", "D", "E", "G", "H", "K","L", "M", "Q", "R", "T"};
        private List<string> _Cartas = new List<string> {}; // Lista de cartas do jogador
        public frmLobbyDaPartida(int idSala, string IdJogador, string SenhaJogador)
        {
            InitializeComponent();
            tmrVez.Enabled = true;
            _idSala = idSala;
            _idDoJogador = IdJogador;
            _senhaDoJogador = SenhaJogador;

            lblMostraID.Text = IdJogador;
            lblMostraSenha.Text = SenhaJogador;

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
                

                string senha = _senhaDoJogador;

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
            VerificarVez();
        }

        private void VerificarVez()
        {
            //obtém a string de verificação do jogo
            string verificacao = Jogo.VerificarVez(_idSala);


            List<string> linhasFormatadas = new List<string>();

            string[] atualizar = verificacao.Split('\n');

            lstbVerificarVez.Items.Clear(); //limpa o ListBox antes de adicionar novos itens

            foreach (string linha in atualizar)
            {
                lstbVerificarVez.Items.Add(linha);
                string[] setorJogador = linha.Split(',');

                if (setorJogador.Length > 1)
                {
                    _letras.Remove(setorJogador[1]);
                }
                //verifica se a linha tem exatamente duas partes (setor e personagem)
                if (setorJogador.Length == 2)
                {
                    //formata a linha no formato 'setor,personagem'
                    string linhaFormatada = $"{setorJogador[0]},{setorJogador[1]}";
                    linhasFormatadas.Add(linhaFormatada);
                }


            }
            //junta todas as linhas formatadas em uma única string, separadas por aspas simples
            _resultadoFinal = string.Join("$", linhasFormatadas);

            //se desejar continuar exibindo apenas a vez em lblMostraVez:
            string[] partes = verificacao.Split(',');
            if (partes.Length > 0)
            {
                _IdDaVez = partes[0]; // atualizar a string de quem é a vez
                lblMostraVez.Text = partes[0]; // mostra em uma label de quem é a vez
            }

        }
        static int nivelAleatorio() // devolve uma fase de 1 - 4
        {
            Random randomNivel = new Random();
            int nivel = randomNivel.Next(1, 5);
            return nivel;
        }

        static string ReturnFaseJogo(int Id) // essa função serve para retornar a fase do jogo (setup,promocão e etc).
        {   
            string verificacao = Jogo.VerificarVez(Id);
            string[] atualizar = verificacao.Split('\n');

            string tempPartes = atualizar[0]; // pega a primeira parte da string
            string[] partes = tempPartes.Split(','); // divide a string em partes

            //F = não começou o jogo

            if(atualizar.Length > 0)
            {
                if (partes.Length < 5 && partes.Length > 2)
                {
                    return partes[3];
                    
                }
                else 
                {

                    return "F"; // Retorna "F" se não houver partes suficientes

                }
            }
            else
            {
                return "F"; // Retorna "F" se não houver partes suficientes
            }

        }

        private void robo()
        {
           string tempFase = ReturnFaseJogo(_idSala);
           string Fase = tempFase.Replace("\r", "").Replace("\n","").ToUpper(); // Fase do jogo (Setup, Promoção, etc.)

            MessageBox.Show(Fase);

            if (Fase == "F") // faz nada
            {
                MessageBox.Show("N faz nada");
            }

            if ( Fase == "S") // se a fase estiver em fase de Setup ele vai colocar os personganes
            {
                MessageBox.Show("Entro no S");
                if (_idDoJogador == _IdDaVez)
                {
                    Random randomLetras = new Random();
                    int indice = randomLetras.Next(_letras.Count);
                    string Personagem = _letras[indice];
                    int nivel = nivelAleatorio();
                
                    colocarRobo(Personagem, nivel);
                    _Cartas.Add(Personagem); // Adiciona o personagem à lista de cartas do jogador

                }
            }else if (Fase == "P")
            {
                MessageBox.Show("Entro no P");
                if (_idDoJogador == _IdDaVez)
                {
                    int jogador = Convert.ToInt32(_idDoJogador);
                    string senha = _senhaDoJogador;

                    Random randomLetras = new Random();
                    int indice = randomLetras.Next(_Cartas.Count);
                    string Personagem = _Cartas[indice];


                    Jogo.Promover(jogador, senha, Personagem);
                }

            }
            

        }

   

        private void colocarRobo(string person, int nivel)
        {
            string senha = txtSenha.Text;
            int setor = nivel;
            string personagem = person;
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


        private void btnVerMapa_Click(object sender, EventArgs e)
        {
          
            Mapa mapa = new Mapa(_resultadoFinal);
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

        private void lblColocarSetor_Click(object sender, EventArgs e)
        {

        }

        private void lblEscolhaPersonagem_Click(object sender, EventArgs e)
        {

        }

        private void lstbSetores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tmrVez_Tick(object sender, EventArgs e)
        {
            tmrVez.Enabled = false;
            VerificarVez();
            robo();
            VerificarVez();
            tmrVez.Enabled = true;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }
    }
}
