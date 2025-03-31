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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.lblEstadoJogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbJogadores
            // 
            this.lstbJogadores.FormattingEnabled = true;
            this.lstbJogadores.Location = new System.Drawing.Point(12, 41);
            this.lstbJogadores.Name = "lstbJogadores";
            this.lstbJogadores.Size = new System.Drawing.Size(106, 173);
            this.lstbJogadores.TabIndex = 0;
            this.lstbJogadores.SelectedIndexChanged += new System.EventHandler(this.lstbJogadores_SelectedIndexChanged);
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
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click_1);
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
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
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
            this.lblEscreverSenha.Click += new System.EventHandler(this.lblEscreverSenha_Click);
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
            this.lstbVerificarVez.Location = new System.Drawing.Point(12, 382);
            this.lstbVerificarVez.Name = "lstbVerificarVez";
            this.lstbVerificarVez.Size = new System.Drawing.Size(202, 95);
            this.lstbVerificarVez.TabIndex = 12;
            this.lstbVerificarVez.SelectedIndexChanged += new System.EventHandler(this.lstbVerificarVez_SelectedIndexChanged);
            // 
            // btnVerificarVez
            // 
            this.btnVerificarVez.Location = new System.Drawing.Point(12, 353);
            this.btnVerificarVez.Name = "btnVerificarVez";
            this.btnVerificarVez.Size = new System.Drawing.Size(122, 23);
            this.btnVerificarVez.TabIndex = 13;
            this.btnVerificarVez.Text = "Verificar Vez";
            this.btnVerificarVez.UseVisualStyleBackColor = true;
            this.btnVerificarVez.Click += new System.EventHandler(this.btnVerificarVez_Click);
            // 
            // lblVez
            // 
            this.lblVez.AutoSize = true;
            this.lblVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVez.Location = new System.Drawing.Point(221, 383);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(158, 24);
            this.lblVez.TabIndex = 14;
            this.lblVez.Text = "De quem é a vez:";
            // 
            // lblMostraVez
            // 
            this.lblMostraVez.AutoSize = true;
            this.lblMostraVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraVez.Location = new System.Drawing.Point(223, 446);
            this.lblMostraVez.Name = "lblMostraVez";
            this.lblMostraVez.Size = new System.Drawing.Size(89, 20);
            this.lblMostraVez.TabIndex = 15;
            this.lblMostraVez.Text = "Replace ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "É a vez do:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstbPersonagens
            // 
            this.lstbPersonagens.FormattingEnabled = true;
            this.lstbPersonagens.Location = new System.Drawing.Point(354, 41);
            this.lstbPersonagens.Name = "lstbPersonagens";
            this.lstbPersonagens.Size = new System.Drawing.Size(202, 147);
            this.lstbPersonagens.TabIndex = 18;
            this.lstbPersonagens.SelectedIndexChanged += new System.EventHandler(this.lstbPersonagens_SelectedIndexChanged);
            // 
            // lblPersonagens
            // 
            this.lblPersonagens.AutoSize = true;
            this.lblPersonagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonagens.Location = new System.Drawing.Point(350, 14);
            this.lblPersonagens.Name = "lblPersonagens";
            this.lblPersonagens.Size = new System.Drawing.Size(122, 24);
            this.lblPersonagens.TabIndex = 19;
            this.lblPersonagens.Text = "Personagens";
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.Location = new System.Drawing.Point(581, 13);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(74, 24);
            this.lblSetor.TabIndex = 20;
            this.lblSetor.Text = "Setores";
            this.lblSetor.Click += new System.EventHandler(this.lblSetor_Click);
            // 
            // lstbSetores
            // 
            this.lstbSetores.FormattingEnabled = true;
            this.lstbSetores.Location = new System.Drawing.Point(585, 41);
            this.lstbSetores.Name = "lstbSetores";
            this.lstbSetores.Size = new System.Drawing.Size(144, 147);
            this.lstbSetores.TabIndex = 21;
            this.lstbSetores.SelectedIndexChanged += new System.EventHandler(this.lstbSetores_SelectedIndexChanged);
            // 
            // btnColocarPersonagem
            // 
            this.btnColocarPersonagem.Location = new System.Drawing.Point(761, 144);
            this.btnColocarPersonagem.Name = "btnColocarPersonagem";
            this.btnColocarPersonagem.Size = new System.Drawing.Size(136, 44);
            this.btnColocarPersonagem.TabIndex = 22;
            this.btnColocarPersonagem.Text = "Colocar Personagem";
            this.btnColocarPersonagem.UseVisualStyleBackColor = true;
            this.btnColocarPersonagem.Click += new System.EventHandler(this.btnColocarPersonagem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 209);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 24);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Setores:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(354, 236);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 95);
            this.listBox1.TabIndex = 25;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtCartas
            // 
            this.txtCartas.AutoSize = true;
            this.txtCartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartas.Location = new System.Drawing.Point(581, 209);
            this.txtCartas.Name = "txtCartas";
            this.txtCartas.Size = new System.Drawing.Size(62, 24);
            this.txtCartas.TabIndex = 26;
            this.txtCartas.Text = "Cartas";
            this.txtCartas.Click += new System.EventHandler(this.txtCartas_Click);
            // 
            // TXBCartas
            // 
            this.TXBCartas.FormattingEnabled = true;
            this.TXBCartas.Location = new System.Drawing.Point(585, 236);
            this.TXBCartas.Name = "TXBCartas";
            this.TXBCartas.Size = new System.Drawing.Size(144, 121);
            this.TXBCartas.TabIndex = 27;
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(944, 283);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(75, 19);
            this.btnVotar.TabIndex = 28;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            // 
            // btnPromover
            // 
            this.btnPromover.Location = new System.Drawing.Point(944, 312);
            this.btnPromover.Name = "btnPromover";
            this.btnPromover.Size = new System.Drawing.Size(75, 19);
            this.btnPromover.TabIndex = 29;
            this.btnPromover.Text = "Promover";
            this.btnPromover.UseVisualStyleBackColor = true;
            // 
            // btnVerMapa
            // 
            this.btnVerMapa.Location = new System.Drawing.Point(944, 343);
            this.btnVerMapa.Name = "btnVerMapa";
            this.btnVerMapa.Size = new System.Drawing.Size(75, 19);
            this.btnVerMapa.TabIndex = 30;
            this.btnVerMapa.Text = "Ver Mapa";
            this.btnVerMapa.UseVisualStyleBackColor = true;
            this.btnVerMapa.Click += new System.EventHandler(this.btnVerMapa_Click);
            // 
            // lblColocarSetor
            // 
            this.lblColocarSetor.AutoSize = true;
            this.lblColocarSetor.Location = new System.Drawing.Point(758, 41);
            this.lblColocarSetor.Name = "lblColocarSetor";
            this.lblColocarSetor.Size = new System.Drawing.Size(85, 13);
            this.lblColocarSetor.TabIndex = 31;
            this.lblColocarSetor.Text = "Escolha o Setor:";
            // 
            // txtEscolheSetor
            // 
            this.txtEscolheSetor.Location = new System.Drawing.Point(761, 57);
            this.txtEscolheSetor.Name = "txtEscolheSetor";
            this.txtEscolheSetor.Size = new System.Drawing.Size(100, 20);
            this.txtEscolheSetor.TabIndex = 32;
            // 
            // txtEscolhaPersonagem
            // 
            this.txtEscolhaPersonagem.Location = new System.Drawing.Point(761, 104);
            this.txtEscolhaPersonagem.Name = "txtEscolhaPersonagem";
            this.txtEscolhaPersonagem.Size = new System.Drawing.Size(100, 20);
            this.txtEscolhaPersonagem.TabIndex = 34;
            // 
            // lblEscolhaPersonagem
            // 
            this.lblEscolhaPersonagem.AutoSize = true;
            this.lblEscolhaPersonagem.Location = new System.Drawing.Point(758, 88);
            this.lblEscolhaPersonagem.Name = "lblEscolhaPersonagem";
            this.lblEscolhaPersonagem.Size = new System.Drawing.Size(119, 13);
            this.lblEscolhaPersonagem.TabIndex = 33;
            this.lblEscolhaPersonagem.Text = "Escolha o Personagem:";
            // 
            // lblEstadoDoJogo
            // 
            this.lblEstadoDoJogo.AutoSize = true;
            this.lblEstadoDoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoDoJogo.Location = new System.Drawing.Point(394, 382);
            this.lblEstadoDoJogo.Name = "lblEstadoDoJogo";
            this.lblEstadoDoJogo.Size = new System.Drawing.Size(142, 24);
            this.lblEstadoDoJogo.TabIndex = 35;
            this.lblEstadoDoJogo.Text = "Estado do jogo:";
            // 
            // lstEstadoDoJogo
            // 
            this.lstEstadoDoJogo.FormattingEnabled = true;
            this.lstEstadoDoJogo.Location = new System.Drawing.Point(398, 409);
            this.lstEstadoDoJogo.Name = "lstEstadoDoJogo";
            this.lstEstadoDoJogo.Size = new System.Drawing.Size(310, 121);
            this.lstEstadoDoJogo.TabIndex = 36;
            // 
            // lblEstadoJogo
            // 
            this.lblEstadoJogo.AutoSize = true;
            this.lblEstadoJogo.Font = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoJogo.Location = new System.Drawing.Point(10, 603);
            this.lblEstadoJogo.Name = "lblEstadoJogo";
            this.lblEstadoJogo.Size = new System.Drawing.Size(60, 11);
            this.lblEstadoJogo.TabIndex = 37;
            this.lblEstadoJogo.Text = "lblEstadoJogo";
            this.lblEstadoJogo.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmLobbyDaPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 623);
            this.Controls.Add(this.lblEstadoJogo);
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
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
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
            this.Load += new System.EventHandler(this.frmLobbyDaPartida_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
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
        private System.Windows.Forms.Label lblEstadoJogo;
    }
}