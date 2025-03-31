using System; // :) Importa o namespace System
using System.Collections.Generic; // :) Importa o namespace para coleções genéricas
using System.ComponentModel; // :) Importa o namespace para componentes
using System.Data; // :) Importa o namespace para acesso a dados
using System.Drawing; // :) Importa o namespace para manipulação gráfica
using System.Linq; // :) Importa o namespace LINQ para consultas
using System.Text; // :) Importa o namespace para manipulação de texto
using System.Threading.Tasks; // :) Importa o namespace para tarefas assíncronas
using System.Windows.Forms; // :) Importa o namespace para Windows Forms
using KingMeServer; // :) Importa o namespace KingMeServer

namespace PI_3_Defensores_de_Hastings // :) Define o namespace da aplicação
{
    public partial class frmTelaInicial : Form // :) Declara a classe frmTelaInicial que herda de Form
    {
        private string versao; // :) Declara uma variável privada para armazenar a versão

        public frmTelaInicial() // :) Construtor da classe frmTelaInicial
        {
            InitializeComponent(); // :) Inicializa os componentes do formulário
            lblControleVersao.Text = Jogo.versao; // :) Atualiza o label lblControleVersao com a versão obtida de Jogo
        }

        private void Tela2_Load(object sender, EventArgs e) // :) Evento de carregamento do formulário Tela2
        {
        }

        private void btnVoltar_Click(object sender, EventArgs e) // :) Evento de clique do botão btnVoltar
        {
            frmLobby lobby = new frmLobby(); // :) Cria uma nova instância do formulário frmLobby
            lobby.ShowDialog(); // :) Exibe o formulário frmLobby como uma caixa de diálogo modal
        }

        private void btnCriarPartida_Click(object sender, EventArgs e) // :) Evento de clique do botão btnCriarPartida
        {
            Form1 tela1 = new Form1(); // :) Cria uma nova instância do formulário Form1
            tela1.versao = this.versao; // :) Atribui a versão do formulário atual à propriedade versao de tela1
            tela1.AtualizarTela(); // :) Chama o método AtualizarTela do formulário tela1
            tela1.ShowDialog(); // :) Exibe o formulário tela1 como uma caixa de diálogo modal
        }
    }
}
