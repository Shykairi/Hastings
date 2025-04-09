namespace PI_3_Defensores_de_Hastings
{
    partial class frmLobbyDaPartida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstbJogadores = new System.Windows.Forms.ListBox();
            this.lblJogadores = new System.Windows.Forms.Label();
            this.bntComecar = new System.Windows.Forms.Button();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblMostraSenha = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblMostraID = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblEscreverSenha = new System.Windows.Forms.Label();
            this.lblEscreverID = new System.Windows.Forms.Label();
            this.lstbVerificarVez = new System.Windows.Forms.ListBox();
            this.btnVerificarVez = new System.Windows.Forms.Button();
            this.lblVez = new System.Windows.Forms.Label();
            this.lblMostraVez = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstbPersonagens = new System.Windows.Forms.ListBox();
            this.lblPersonagens = new System.Windows.Forms.Label();
            this.lblSetor = new System.Windows.Forms.Label();
            this.lstbSetores = new System.Windows.Forms.ListBox();
            this.btnColocarPersonagem = new System.Windows.Forms.Button();
            this.txtCartas = new System.Windows.Forms.Label();
            this.TXBCartas = new System.Windows.Forms.ListBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.btnPromover = new System.Windows.Forms.Button();
            this.btnVerMapa = new System.Windows.Forms.Button();
            this.lblColocarSetor = new System.Windows.Forms.Label();
            this.txtEscolheSetor = new System.Windows.Forms.TextBox();
            this.txtEscolhaPersonagem = new System.Windows.Forms.TextBox();
            this.lblEscolhaPersonagem = new System.Windows.Forms.Label();
            this.lblEstadoDoJogo = new System.Windows.Forms.Label();
            this.lstEstadoDoJogo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVoto = new System.Windows.Forms.TextBox();
            this.lblEstadoJogo = new System.Windows.Forms.Label();
            this.lblUltimasJogadas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbJogadores
            // 
            this.lstbJogadores.FormattingEnabled = true;
            this.lstbJogadores.Location = new System.Drawing.Point(12, 41);
            this.lstbJogadores.Name = "lstbJogadores";
            this.lstbJogadores.Size = new System.Drawing.Size(106, 173);
            this.lstbJogadores.TabIndex = 0;
            // 
            // lblJogadores
            // 
            this.lblJogadores.AutoSize = true;
            this.lblJogadores.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadores.Location = new System.Drawing.Point(7, 9);
            this.lblJogadores.Name = "lblJogadores";
            this.lblJogadores.Size = new System.Drawing.Size(111, 29);
            this.lblJogadores.TabIndex = 1;
            this.lblJogadores.Text = "Jogadores:";
            // 
            // bntComecar
            // 
            this.bntComecar.Location = new System.Drawing.Point(12, 257);
            this.bntComecar.Name = "bntComecar";
            this.bntComecar.Size = new System.Drawing.Size(106, 32);
            this.bntComecar.TabIndex = 2;
            this.bntComecar.Text = "Começar";
            this.bntComecar.UseVisualStyleBackColor = true;
            this.bntComecar.Click += new System.EventHandler(this.bntComecar_Click);
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(12, 220);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(106, 31);
            this.btnListarJogadores.TabIndex = 3;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(134, 41);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(127, 25);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Sua senha: ";
            // 
            // lblMostraSenha
            // 
            this.lblMostraSenha.AutoSize = true;
            this.lblMostraSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraSenha.Location = new System.Drawing.Point(135, 66);
            this.lblMostraSenha.Name = "lblMostraSenha";
            this.lblMostraSenha.Size = new System.Drawing.Size(116, 20);
            this.lblMostraSenha.TabIndex = 5;
            this.lblMostraSenha.Text = "Replace senha";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(134, 98);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(82, 25);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "Seu ID:";
            // 
            // lblMostraID
            // 
            this.lblMostraID.AutoSize = true;
            this.lblMostraID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraID.Location = new System.Drawing.Point(135, 123);
            this.lblMostraID.Name = "lblMostraID";
            this.lblMostraID.Size = new System.Drawing.Size(89, 20);
            this.lblMostraID.TabIndex = 7;
            this.lblMostraID.Text = "Replace ID";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(139, 176);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(121, 20);
            this.txtSenha.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(139, 236);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 9;
            // 
            // lblEscreverSenha
            // 
            this.lblEscreverSenha.AutoSize = true;
            this.lblEscreverSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscreverSenha.Location = new System.Drawing.Point(135, 153);
            this.lblEscreverSenha.Name = "lblEscreverSenha";
            this.lblEscreverSenha.Size = new System.Drawing.Size(147, 24);
            this.lblEscreverSenha.TabIndex = 10;
            this.lblEscreverSenha.Text = "Escrever senha:";
            // 
            // lblEscreverID
            // 
            this.lblEscreverID.AutoSize = true;
            this.lblEscreverID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscreverID.Location = new System.Drawing.Point(135, 209);
            this.lblEscreverID.Name = "lblEscreverID";
            this.lblEscreverID.Size = new System.Drawing.Size(128, 24);
            this.lblEscreverID.TabIndex = 11;
            this.lblEscreverID.Text = "Escrever o ID:";
            // 
            // lstbVerificarVez
            // 
            this.lstbVerificarVez.FormattingEnabled = true;
            this.lstbVerificarVez.Location = new System.Drawing.Point(282, 227);
            this.lstbVerificarVez.Name = "lstbVerificarVez";
            this.lstbVerificarVez.Size = new System.Drawing.Size(202, 277);
            this.lstbVerificarVez.TabIndex = 12;
            // 
            // btnVerificarVez
            // 
            this.btnVerificarVez.Location = new System.Drawing.Point(12, 385);
            this.btnVerificarVez.Name = "btnVerificarVez";
            this.btnVerificarVez.Size = new System.Drawing.Size(202, 56);
            this.btnVerificarVez.TabIndex = 13;
            this.btnVerificarVez.Text = "Verificar Estado Do Tabuleiro";
            this.btnVerificarVez.UseVisualStyleBackColor = true;
            this.btnVerificarVez.Click += new System.EventHandler(this.btnVerificarVez_Click);
            // 
            // lblVez
            // 
            this.lblVez.AutoSize = true;
            this.lblVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVez.Location = new System.Drawing.Point(8, 319);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(158, 24);
            this.lblVez.TabIndex = 14;
            this.lblVez.Text = "De quem é a vez:";
            // 
            // lblMostraVez
            // 
            this.lblMostraVez.AutoSize = true;
            this.lblMostraVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraVez.Location = new System.Drawing.Point(10, 362);
            this.lblMostraVez.Name = "lblMostraVez";
            this.lblMostraVez.Size = new System.Drawing.Size(89, 20);
            this.lblMostraVez.TabIndex = 15;
            this.lblMostraVez.Text = "Replace ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "É a vez do:";
            // 
            // lstbPersonagens
            // 
            this.lstbPersonagens.FormattingEnabled = true;
            this.lstbPersonagens.Location = new System.Drawing.Point(282, 41);
            this.lstbPersonagens.Name = "lstbPersonagens";
            this.lstbPersonagens.Size = new System.Drawing.Size(202, 147);
            this.lstbPersonagens.TabIndex = 18;
            // 
            // lblPersonagens
            // 
            this.lblPersonagens.AutoSize = true;
            this.lblPersonagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonagens.Location = new System.Drawing.Point(278, 14);
            this.lblPersonagens.Name = "lblPersonagens";
            this.lblPersonagens.Size = new System.Drawing.Size(122, 24);
            this.lblPersonagens.TabIndex = 19;
            this.lblPersonagens.Text = "Personagens";
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.Location = new System.Drawing.Point(507, 13);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(74, 24);
            this.lblSetor.TabIndex = 20;
            this.lblSetor.Text = "Setores";
            // 
            // lstbSetores
            // 
            this.lstbSetores.FormattingEnabled = true;
            this.lstbSetores.Location = new System.Drawing.Point(511, 41);
            this.lstbSetores.Name = "lstbSetores";
            this.lstbSetores.Size = new System.Drawing.Size(144, 147);
            this.lstbSetores.TabIndex = 21;
            // 
            // btnColocarPersonagem
            // 
            this.btnColocarPersonagem.Location = new System.Drawing.Point(666, 110);
            this.btnColocarPersonagem.Name = "btnColocarPersonagem";
            this.btnColocarPersonagem.Size = new System.Drawing.Size(136, 44);
            this.btnColocarPersonagem.TabIndex = 22;
            this.btnColocarPersonagem.Text = "Colocar Personagem";
            this.btnColocarPersonagem.UseVisualStyleBackColor = true;
            this.btnColocarPersonagem.Click += new System.EventHandler(this.btnColocarPersonagem_Click);
            // 
            // txtCartas
            // 
            this.txtCartas.AutoSize = true;
            this.txtCartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartas.Location = new System.Drawing.Point(686, 358);
            this.txtCartas.Name = "txtCartas";
            this.txtCartas.Size = new System.Drawing.Size(62, 24);
            this.txtCartas.TabIndex = 26;
            this.txtCartas.Text = "Cartas";
            // 
            // TXBCartas
            // 
            this.TXBCartas.FormattingEnabled = true;
            this.TXBCartas.Location = new System.Drawing.Point(690, 385);
            this.TXBCartas.Name = "TXBCartas";
            this.TXBCartas.Size = new System.Drawing.Size(144, 121);
            this.TXBCartas.TabIndex = 27;
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(667, 207);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(136, 39);
            this.btnVotar.TabIndex = 28;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // btnPromover
            // 
            this.btnPromover.Location = new System.Drawing.Point(808, 110);
            this.btnPromover.Name = "btnPromover";
            this.btnPromover.Size = new System.Drawing.Size(136, 44);
            this.btnPromover.TabIndex = 29;
            this.btnPromover.Text = "Promover";
            this.btnPromover.UseVisualStyleBackColor = true;
            this.btnPromover.Click += new System.EventHandler(this.btnPromover_Click);
            // 
            // btnVerMapa
            // 
            this.btnVerMapa.Location = new System.Drawing.Point(811, 216);
            this.btnVerMapa.Name = "btnVerMapa";
            this.btnVerMapa.Size = new System.Drawing.Size(143, 67);
            this.btnVerMapa.TabIndex = 30;
            this.btnVerMapa.Text = "Ver Mapa";
            this.btnVerMapa.UseVisualStyleBackColor = true;
            this.btnVerMapa.Click += new System.EventHandler(this.btnVerMapa_Click);
            // 
            // lblColocarSetor
            // 
            this.lblColocarSetor.AutoSize = true;
            this.lblColocarSetor.Location = new System.Drawing.Point(663, 21);
            this.lblColocarSetor.Name = "lblColocarSetor";
            this.lblColocarSetor.Size = new System.Drawing.Size(85, 13);
            this.lblColocarSetor.TabIndex = 31;
            this.lblColocarSetor.Text = "Escolha o Setor:";
            // 
            // txtEscolheSetor
            // 
            this.txtEscolheSetor.Location = new System.Drawing.Point(666, 37);
            this.txtEscolheSetor.Name = "txtEscolheSetor";
            this.txtEscolheSetor.Size = new System.Drawing.Size(136, 20);
            this.txtEscolheSetor.TabIndex = 32;
            // 
            // txtEscolhaPersonagem
            // 
            this.txtEscolhaPersonagem.Location = new System.Drawing.Point(666, 84);
            this.txtEscolhaPersonagem.Name = "txtEscolhaPersonagem";
            this.txtEscolhaPersonagem.Size = new System.Drawing.Size(136, 20);
            this.txtEscolhaPersonagem.TabIndex = 34;
            // 
            // lblEscolhaPersonagem
            // 
            this.lblEscolhaPersonagem.AutoSize = true;
            this.lblEscolhaPersonagem.Location = new System.Drawing.Point(662, 68);
            this.lblEscolhaPersonagem.Name = "lblEscolhaPersonagem";
            this.lblEscolhaPersonagem.Size = new System.Drawing.Size(119, 13);
            this.lblEscolhaPersonagem.TabIndex = 33;
            this.lblEscolhaPersonagem.Text = "Escolha o Personagem:";
            // 
            // lblEstadoDoJogo
            // 
            this.lblEstadoDoJogo.AutoSize = true;
            this.lblEstadoDoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoDoJogo.Location = new System.Drawing.Point(278, 201);
            this.lblEstadoDoJogo.Name = "lblEstadoDoJogo";
            this.lblEstadoDoJogo.Size = new System.Drawing.Size(185, 24);
            this.lblEstadoDoJogo.TabIndex = 35;
            this.lblEstadoDoJogo.Text = "Estado do Tabuleiro:";
            // 
            // lstEstadoDoJogo
            // 
            this.lstEstadoDoJogo.FormattingEnabled = true;
            this.lstEstadoDoJogo.Location = new System.Drawing.Point(511, 227);
            this.lstEstadoDoJogo.Name = "lstEstadoDoJogo";
            this.lstEstadoDoJogo.Size = new System.Drawing.Size(144, 277);
            this.lstEstadoDoJogo.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Digite seu Voto:";
            // 
            // txtVoto
            // 
            this.txtVoto.Location = new System.Drawing.Point(666, 181);
            this.txtVoto.Name = "txtVoto";
            this.txtVoto.Size = new System.Drawing.Size(137, 20);
            this.txtVoto.TabIndex = 38;
            // 
            // lblEstadoJogo
            // 
            this.lblEstadoJogo.AutoSize = true;
            this.lblEstadoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoJogo.Location = new System.Drawing.Point(931, 57);
            this.lblEstadoJogo.Name = "lblEstadoJogo";
            this.lblEstadoJogo.Size = new System.Drawing.Size(0, 24);
            this.lblEstadoJogo.TabIndex = 39;
            // 
            // lblUltimasJogadas
            // 
            this.lblUltimasJogadas.AutoSize = true;
            this.lblUltimasJogadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimasJogadas.Location = new System.Drawing.Point(506, 200);
            this.lblUltimasJogadas.Name = "lblUltimasJogadas";
            this.lblUltimasJogadas.Size = new System.Drawing.Size(100, 25);
            this.lblUltimasJogadas.TabIndex = 40;
            this.lblUltimasJogadas.Text = "Jogadas:";
            // 
            // frmLobbyDaPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 578);
            this.Controls.Add(this.lblUltimasJogadas);
            this.Controls.Add(this.lblEstadoJogo);
            this.Controls.Add(this.txtVoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstEstadoDoJogo);
            this.Controls.Add(this.lblEstadoDoJogo);
            this.Controls.Add(this.txtEscolhaPersonagem);
            this.Controls.Add(this.lblEscolhaPersonagem);
            this.Controls.Add(this.txtEscolheSetor);
            this.Controls.Add(this.lblColocarSetor);
            this.Controls.Add(this.btnVerMapa);
            this.Controls.Add(this.btnPromover);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.TXBCartas);
            this.Controls.Add(this.txtCartas);
            this.Controls.Add(this.btnColocarPersonagem);
            this.Controls.Add(this.lstbSetores);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.lblPersonagens);
            this.Controls.Add(this.lstbPersonagens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMostraVez);
            this.Controls.Add(this.lblVez);
            this.Controls.Add(this.btnVerificarVez);
            this.Controls.Add(this.lstbVerificarVez);
            this.Controls.Add(this.lblEscreverID);
            this.Controls.Add(this.lblEscreverSenha);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblMostraID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblMostraSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.bntComecar);
            this.Controls.Add(this.lblJogadores);
            this.Controls.Add(this.lstbJogadores);
            this.Name = "frmLobbyDaPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLobbyDaPartida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbJogadores;
        private System.Windows.Forms.Label lblJogadores;
        private System.Windows.Forms.Button bntComecar;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblMostraSenha;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMostraID;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblEscreverSenha;
        private System.Windows.Forms.Label lblEscreverID;
        private System.Windows.Forms.ListBox lstbVerificarVez;
        private System.Windows.Forms.Button btnVerificarVez;
        private System.Windows.Forms.Label lblVez;
        private System.Windows.Forms.Label lblMostraVez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstbPersonagens;
        private System.Windows.Forms.Label lblPersonagens;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.ListBox lstbSetores;
        private System.Windows.Forms.Button btnColocarPersonagem;
        private System.Windows.Forms.Label txtCartas;
        private System.Windows.Forms.ListBox TXBCartas;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button btnPromover;
        private System.Windows.Forms.Button btnVerMapa;
        private System.Windows.Forms.Label lblColocarSetor;
        private System.Windows.Forms.TextBox txtEscolheSetor;
        private System.Windows.Forms.TextBox txtEscolhaPersonagem;
        private System.Windows.Forms.Label lblEscolhaPersonagem;
        private System.Windows.Forms.Label lblEstadoDoJogo;
        private System.Windows.Forms.ListBox lstEstadoDoJogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVoto;
        private System.Windows.Forms.Label lblEstadoJogo;
        private System.Windows.Forms.Label lblUltimasJogadas;
    }
}