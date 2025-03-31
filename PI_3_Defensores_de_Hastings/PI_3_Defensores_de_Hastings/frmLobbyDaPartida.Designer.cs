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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEstadoJogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbJogadores
            // 
            this.lstbJogadores.FormattingEnabled = true;
            this.lstbJogadores.ItemHeight = 16;
            this.lstbJogadores.Location = new System.Drawing.Point(16, 50);
            this.lstbJogadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstbJogadores.Name = "lstbJogadores";
            this.lstbJogadores.Size = new System.Drawing.Size(140, 212);
            this.lstbJogadores.TabIndex = 0;
            this.lstbJogadores.SelectedIndexChanged += new System.EventHandler(this.lstbJogadores_SelectedIndexChanged);
            // 
            // lblJogadores
            // 
            this.lblJogadores.AutoSize = true;
            this.lblJogadores.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadores.Location = new System.Drawing.Point(9, 11);
            this.lblJogadores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJogadores.Name = "lblJogadores";
            this.lblJogadores.Size = new System.Drawing.Size(138, 35);
            this.lblJogadores.TabIndex = 1;
            this.lblJogadores.Text = "Jogadores:";
            // 
            // bntComecar
            // 
            this.bntComecar.Location = new System.Drawing.Point(16, 316);
            this.bntComecar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntComecar.Name = "bntComecar";
            this.bntComecar.Size = new System.Drawing.Size(141, 39);
            this.bntComecar.TabIndex = 2;
            this.bntComecar.Text = "Começar";
            this.bntComecar.UseVisualStyleBackColor = true;
            this.bntComecar.Click += new System.EventHandler(this.bntComecar_Click);
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(16, 271);
            this.btnListarJogadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(141, 38);
            this.btnListarJogadores.TabIndex = 3;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(179, 50);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(158, 31);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Sua senha: ";
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click_1);
            // 
            // lblMostraSenha
            // 
            this.lblMostraSenha.AutoSize = true;
            this.lblMostraSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraSenha.Location = new System.Drawing.Point(180, 81);
            this.lblMostraSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMostraSenha.Name = "lblMostraSenha";
            this.lblMostraSenha.Size = new System.Drawing.Size(142, 25);
            this.lblMostraSenha.TabIndex = 5;
            this.lblMostraSenha.Text = "Replace senha";
            this.lblMostraSenha.Click += new System.EventHandler(this.lblMostraSenha_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(179, 121);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(105, 31);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "Seu ID:";
            // 
            // lblMostraID
            // 
            this.lblMostraID.AutoSize = true;
            this.lblMostraID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraID.Location = new System.Drawing.Point(180, 151);
            this.lblMostraID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMostraID.Name = "lblMostraID";
            this.lblMostraID.Size = new System.Drawing.Size(107, 25);
            this.lblMostraID.TabIndex = 7;
            this.lblMostraID.Text = "Replace ID";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(185, 217);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(160, 22);
            this.txtSenha.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(185, 290);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(160, 22);
            this.txtID.TabIndex = 9;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblEscreverSenha
            // 
            this.lblEscreverSenha.AutoSize = true;
            this.lblEscreverSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscreverSenha.Location = new System.Drawing.Point(180, 188);
            this.lblEscreverSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEscreverSenha.Name = "lblEscreverSenha";
            this.lblEscreverSenha.Size = new System.Drawing.Size(185, 29);
            this.lblEscreverSenha.TabIndex = 10;
            this.lblEscreverSenha.Text = "Escrever senha:";
            this.lblEscreverSenha.Click += new System.EventHandler(this.lblEscreverSenha_Click);
            // 
            // lblEscreverID
            // 
            this.lblEscreverID.AutoSize = true;
            this.lblEscreverID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscreverID.Location = new System.Drawing.Point(180, 257);
            this.lblEscreverID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEscreverID.Name = "lblEscreverID";
            this.lblEscreverID.Size = new System.Drawing.Size(163, 29);
            this.lblEscreverID.TabIndex = 11;
            this.lblEscreverID.Text = "Escrever o ID:";
            // 
            // lstbVerificarVez
            // 
            this.lstbVerificarVez.FormattingEnabled = true;
            this.lstbVerificarVez.ItemHeight = 16;
            this.lstbVerificarVez.Location = new System.Drawing.Point(16, 470);
            this.lstbVerificarVez.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstbVerificarVez.Name = "lstbVerificarVez";
            this.lstbVerificarVez.Size = new System.Drawing.Size(268, 116);
            this.lstbVerificarVez.TabIndex = 12;
            this.lstbVerificarVez.SelectedIndexChanged += new System.EventHandler(this.lstbVerificarVez_SelectedIndexChanged);
            // 
            // btnVerificarVez
            // 
            this.btnVerificarVez.Location = new System.Drawing.Point(16, 434);
            this.btnVerificarVez.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerificarVez.Name = "btnVerificarVez";
            this.btnVerificarVez.Size = new System.Drawing.Size(163, 28);
            this.btnVerificarVez.TabIndex = 13;
            this.btnVerificarVez.Text = "Verificar Vez";
            this.btnVerificarVez.UseVisualStyleBackColor = true;
            this.btnVerificarVez.Click += new System.EventHandler(this.btnVerificarVez_Click);
            // 
            // lblVez
            // 
            this.lblVez.AutoSize = true;
            this.lblVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVez.Location = new System.Drawing.Point(295, 471);
            this.lblVez.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(198, 29);
            this.lblVez.TabIndex = 14;
            this.lblVez.Text = "De quem é a vez:";
            // 
            // lblMostraVez
            // 
            this.lblMostraVez.AutoSize = true;
            this.lblMostraVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraVez.Location = new System.Drawing.Point(300, 535);
            this.lblMostraVez.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMostraVez.Name = "lblMostraVez";
            this.lblMostraVez.Size = new System.Drawing.Size(107, 25);
            this.lblMostraVez.TabIndex = 15;
            this.lblMostraVez.Text = "Replace ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 500);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "É a vez do:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstbPersonagens
            // 
            this.lstbPersonagens.FormattingEnabled = true;
            this.lstbPersonagens.ItemHeight = 16;
            this.lstbPersonagens.Location = new System.Drawing.Point(472, 50);
            this.lstbPersonagens.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstbPersonagens.Name = "lstbPersonagens";
            this.lstbPersonagens.Size = new System.Drawing.Size(268, 180);
            this.lstbPersonagens.TabIndex = 18;
            this.lstbPersonagens.SelectedIndexChanged += new System.EventHandler(this.lstbPersonagens_SelectedIndexChanged);
            // 
            // lblPersonagens
            // 
            this.lblPersonagens.AutoSize = true;
            this.lblPersonagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonagens.Location = new System.Drawing.Point(467, 17);
            this.lblPersonagens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonagens.Name = "lblPersonagens";
            this.lblPersonagens.Size = new System.Drawing.Size(156, 29);
            this.lblPersonagens.TabIndex = 19;
            this.lblPersonagens.Text = "Personagens";
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.Location = new System.Drawing.Point(775, 16);
            this.lblSetor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(97, 29);
            this.lblSetor.TabIndex = 20;
            this.lblSetor.Text = "Setores";
            this.lblSetor.Click += new System.EventHandler(this.lblSetor_Click);
            // 
            // lstbSetores
            // 
            this.lstbSetores.FormattingEnabled = true;
            this.lstbSetores.ItemHeight = 16;
            this.lstbSetores.Location = new System.Drawing.Point(780, 50);
            this.lstbSetores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstbSetores.Name = "lstbSetores";
            this.lstbSetores.Size = new System.Drawing.Size(191, 180);
            this.lstbSetores.TabIndex = 21;
            this.lstbSetores.SelectedIndexChanged += new System.EventHandler(this.lstbSetores_SelectedIndexChanged);
            // 
            // btnColocarPersonagem
            // 
            this.btnColocarPersonagem.Location = new System.Drawing.Point(1015, 177);
            this.btnColocarPersonagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColocarPersonagem.Name = "btnColocarPersonagem";
            this.btnColocarPersonagem.Size = new System.Drawing.Size(181, 54);
            this.btnColocarPersonagem.TabIndex = 22;
            this.btnColocarPersonagem.Text = "Colocar Personagem";
            this.btnColocarPersonagem.UseVisualStyleBackColor = true;
            this.btnColocarPersonagem.Click += new System.EventHandler(this.btnColocarPersonagem_Click);
            // 
            // txtCartas
            // 
            this.txtCartas.AutoSize = true;
            this.txtCartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartas.Location = new System.Drawing.Point(775, 257);
            this.txtCartas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCartas.Name = "txtCartas";
            this.txtCartas.Size = new System.Drawing.Size(82, 29);
            this.txtCartas.TabIndex = 26;
            this.txtCartas.Text = "Cartas";
            this.txtCartas.Click += new System.EventHandler(this.txtCartas_Click);
            // 
            // TXBCartas
            // 
            this.TXBCartas.FormattingEnabled = true;
            this.TXBCartas.ItemHeight = 16;
            this.TXBCartas.Location = new System.Drawing.Point(780, 290);
            this.TXBCartas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXBCartas.Name = "TXBCartas";
            this.TXBCartas.Size = new System.Drawing.Size(191, 148);
            this.TXBCartas.TabIndex = 27;
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(1259, 348);
            this.btnVotar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(100, 23);
            this.btnVotar.TabIndex = 28;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // btnPromover
            // 
            this.btnPromover.Location = new System.Drawing.Point(1259, 384);
            this.btnPromover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPromover.Name = "btnPromover";
            this.btnPromover.Size = new System.Drawing.Size(100, 23);
            this.btnPromover.TabIndex = 29;
            this.btnPromover.Text = "Promover";
            this.btnPromover.UseVisualStyleBackColor = true;
            this.btnPromover.Click += new System.EventHandler(this.btnPromover_Click);
            // 
            // btnVerMapa
            // 
            this.btnVerMapa.Location = new System.Drawing.Point(1259, 422);
            this.btnVerMapa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerMapa.Name = "btnVerMapa";
            this.btnVerMapa.Size = new System.Drawing.Size(100, 23);
            this.btnVerMapa.TabIndex = 30;
            this.btnVerMapa.Text = "Ver Mapa";
            this.btnVerMapa.UseVisualStyleBackColor = true;
            this.btnVerMapa.Click += new System.EventHandler(this.btnVerMapa_Click);
            // 
            // lblColocarSetor
            // 
            this.lblColocarSetor.AutoSize = true;
            this.lblColocarSetor.Location = new System.Drawing.Point(1011, 50);
            this.lblColocarSetor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColocarSetor.Name = "lblColocarSetor";
            this.lblColocarSetor.Size = new System.Drawing.Size(105, 16);
            this.lblColocarSetor.TabIndex = 31;
            this.lblColocarSetor.Text = "Escolha o Setor:";
            // 
            // txtEscolheSetor
            // 
            this.txtEscolheSetor.Location = new System.Drawing.Point(1015, 70);
            this.txtEscolheSetor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEscolheSetor.Name = "txtEscolheSetor";
            this.txtEscolheSetor.Size = new System.Drawing.Size(132, 22);
            this.txtEscolheSetor.TabIndex = 32;
            // 
            // txtEscolhaPersonagem
            // 
            this.txtEscolhaPersonagem.Location = new System.Drawing.Point(1015, 128);
            this.txtEscolhaPersonagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEscolhaPersonagem.Name = "txtEscolhaPersonagem";
            this.txtEscolhaPersonagem.Size = new System.Drawing.Size(132, 22);
            this.txtEscolhaPersonagem.TabIndex = 34;
            // 
            // lblEscolhaPersonagem
            // 
            this.lblEscolhaPersonagem.AutoSize = true;
            this.lblEscolhaPersonagem.Location = new System.Drawing.Point(1011, 108);
            this.lblEscolhaPersonagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEscolhaPersonagem.Name = "lblEscolhaPersonagem";
            this.lblEscolhaPersonagem.Size = new System.Drawing.Size(151, 16);
            this.lblEscolhaPersonagem.TabIndex = 33;
            this.lblEscolhaPersonagem.Text = "Escolha o Personagem:";
            // 
            // lblEstadoDoJogo
            // 
            this.lblEstadoDoJogo.AutoSize = true;
            this.lblEstadoDoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoDoJogo.Location = new System.Drawing.Point(525, 470);
            this.lblEstadoDoJogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoDoJogo.Name = "lblEstadoDoJogo";
            this.lblEstadoDoJogo.Size = new System.Drawing.Size(182, 29);
            this.lblEstadoDoJogo.TabIndex = 35;
            this.lblEstadoDoJogo.Text = "Estado do jogo:";
            this.lblEstadoDoJogo.Click += new System.EventHandler(this.lblEstadoDoJogo_Click);
            // 
            // lstEstadoDoJogo
            // 
            this.lstEstadoDoJogo.FormattingEnabled = true;
            this.lstEstadoDoJogo.ItemHeight = 16;
            this.lstEstadoDoJogo.Location = new System.Drawing.Point(531, 503);
            this.lstEstadoDoJogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstEstadoDoJogo.Name = "lstEstadoDoJogo";
            this.lstEstadoDoJogo.Size = new System.Drawing.Size(412, 148);
            this.lstEstadoDoJogo.TabIndex = 36;
            this.lstEstadoDoJogo.SelectedIndexChanged += new System.EventHandler(this.lstEstadoDoJogo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Digite seu Voto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(472, 290);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 38;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEstadoJogo
            // 
            this.lblEstadoJogo.AutoSize = true;
            this.lblEstadoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoJogo.Location = new System.Drawing.Point(715, 471);
            this.lblEstadoJogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoJogo.Name = "lblEstadoJogo";
            this.lblEstadoJogo.Size = new System.Drawing.Size(0, 36);
            this.lblEstadoJogo.TabIndex = 39;
            // 
            // frmLobbyDaPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 712);
            this.Controls.Add(this.lblEstadoJogo);
            this.Controls.Add(this.textBox1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEstadoJogo;
    }
}