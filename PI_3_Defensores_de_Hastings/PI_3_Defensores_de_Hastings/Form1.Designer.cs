namespace PI_3_Defensores_de_Hastings
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPartida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeDaPartida = new System.Windows.Forms.TextBox();
            this.senhaDaPartida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeDoGrupo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idDaPartida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nomeDoJogador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.confirmarSenha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TXB_IDJogador = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TXB_SenhaJogador = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.TXB_Cartas = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.personagens = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPartida
            // 
            this.btnPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnPartida.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartida.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnPartida.ForeColor = System.Drawing.Color.Transparent;
            this.btnPartida.Location = new System.Drawing.Point(203, 137);
            this.btnPartida.Margin = new System.Windows.Forms.Padding(4);
            this.btnPartida.Name = "btnPartida";
            this.btnPartida.Size = new System.Drawing.Size(100, 28);
            this.btnPartida.TabIndex = 0;
            this.btnPartida.Text = "Criar";
            this.btnPartida.UseVisualStyleBackColor = false;
            this.btnPartida.Click += new System.EventHandler(this.btnPartida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Partida:";
            // 
            // nomeDaPartida
            // 
            this.nomeDaPartida.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeDaPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeDaPartida.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.nomeDaPartida.Location = new System.Drawing.Point(16, 87);
            this.nomeDaPartida.Margin = new System.Windows.Forms.Padding(4);
            this.nomeDaPartida.Name = "nomeDaPartida";
            this.nomeDaPartida.Size = new System.Drawing.Size(133, 25);
            this.nomeDaPartida.TabIndex = 2;
            // 
            // senhaDaPartida
            // 
            this.senhaDaPartida.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.senhaDaPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhaDaPartida.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.senhaDaPartida.Location = new System.Drawing.Point(187, 87);
            this.senhaDaPartida.Margin = new System.Windows.Forms.Padding(4);
            this.senhaDaPartida.Name = "senhaDaPartida";
            this.senhaDaPartida.Size = new System.Drawing.Size(133, 25);
            this.senhaDaPartida.TabIndex = 4;
            this.senhaDaPartida.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(184, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nomeDoGrupo
            // 
            this.nomeDoGrupo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeDoGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeDoGrupo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.nomeDoGrupo.Location = new System.Drawing.Point(364, 87);
            this.nomeDoGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.nomeDoGrupo.Name = "nomeDoGrupo";
            this.nomeDoGrupo.Size = new System.Drawing.Size(196, 25);
            this.nomeDoGrupo.TabIndex = 6;
            this.nomeDoGrupo.Text = "Defensores";
            this.nomeDoGrupo.TextChanged += new System.EventHandler(this.nomeDoGrupo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(361, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grupo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Diagram;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(347, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Defensores de Hastings\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // idDaPartida
            // 
            this.idDaPartida.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.idDaPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idDaPartida.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.idDaPartida.Location = new System.Drawing.Point(649, 87);
            this.idDaPartida.Margin = new System.Windows.Forms.Padding(4);
            this.idDaPartida.Name = "idDaPartida";
            this.idDaPartida.ReadOnly = true;
            this.idDaPartida.Size = new System.Drawing.Size(133, 25);
            this.idDaPartida.TabIndex = 9;
            this.idDaPartida.TextChanged += new System.EventHandler(this.idDaPartida_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(647, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(1009, 518);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "1.0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(773, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 75);
            this.button2.TabIndex = 15;
            this.button2.Text = "Chama o form 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(13, 195);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Jogador:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(203, 281);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Criar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nomeDoJogador
            // 
            this.nomeDoJogador.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeDoJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeDoJogador.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.nomeDoJogador.Location = new System.Drawing.Point(17, 218);
            this.nomeDoJogador.Margin = new System.Windows.Forms.Padding(4);
            this.nomeDoJogador.Name = "nomeDoJogador";
            this.nomeDoJogador.Size = new System.Drawing.Size(133, 25);
            this.nomeDoJogador.TabIndex = 19;
            this.nomeDoJogador.TextChanged += new System.EventHandler(this.textBox1_TextChanged_3);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(184, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Senha:";
            // 
            // confirmarSenha
            // 
            this.confirmarSenha.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.confirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmarSenha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.confirmarSenha.Location = new System.Drawing.Point(187, 218);
            this.confirmarSenha.Margin = new System.Windows.Forms.Padding(4);
            this.confirmarSenha.Name = "confirmarSenha";
            this.confirmarSenha.Size = new System.Drawing.Size(133, 25);
            this.confirmarSenha.TabIndex = 21;
            this.confirmarSenha.TextChanged += new System.EventHandler(this.textBox1_TextChanged_4);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(9, 332);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Cartas:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(645, 195);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "ID do jogador:";
            // 
            // TXB_IDJogador
            // 
            this.TXB_IDJogador.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TXB_IDJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_IDJogador.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.TXB_IDJogador.Location = new System.Drawing.Point(651, 218);
            this.TXB_IDJogador.Margin = new System.Windows.Forms.Padding(4);
            this.TXB_IDJogador.Name = "TXB_IDJogador";
            this.TXB_IDJogador.ReadOnly = true;
            this.TXB_IDJogador.Size = new System.Drawing.Size(133, 25);
            this.TXB_IDJogador.TabIndex = 25;
            this.TXB_IDJogador.TextChanged += new System.EventHandler(this.TXB_IDJogador_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(439, 195);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "Senha do jogador:";
            // 
            // TXB_SenhaJogador
            // 
            this.TXB_SenhaJogador.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TXB_SenhaJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_SenhaJogador.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.TXB_SenhaJogador.Location = new System.Drawing.Point(443, 218);
            this.TXB_SenhaJogador.Margin = new System.Windows.Forms.Padding(4);
            this.TXB_SenhaJogador.Name = "TXB_SenhaJogador";
            this.TXB_SenhaJogador.ReadOnly = true;
            this.TXB_SenhaJogador.Size = new System.Drawing.Size(133, 25);
            this.TXB_SenhaJogador.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(392, 364);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 28;
            this.button3.Text = "Iniciar partida";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TXB_Cartas
            // 
            this.TXB_Cartas.FormattingEnabled = true;
            this.TXB_Cartas.ItemHeight = 16;
            this.TXB_Cartas.Location = new System.Drawing.Point(13, 355);
            this.TXB_Cartas.Name = "TXB_Cartas";
            this.TXB_Cartas.Size = new System.Drawing.Size(212, 180);
            this.TXB_Cartas.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 355);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 31;
            // 
            // personagens
            // 
            this.personagens.BackColor = System.Drawing.SystemColors.InfoText;
            this.personagens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personagens.FormattingEnabled = true;
            this.personagens.ItemHeight = 16;
            this.personagens.Location = new System.Drawing.Point(936, 488);
            this.personagens.Name = "personagens";
            this.personagens.Size = new System.Drawing.Size(10, 0);
            this.personagens.TabIndex = 29;
            this.personagens.SelectedIndexChanged += new System.EventHandler(this.personagens_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TXB_Cartas);
            this.Controls.Add(this.personagens);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TXB_SenhaJogador);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TXB_IDJogador);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.confirmarSenha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nomeDoJogador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idDaPartida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomeDoGrupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.senhaDaPartida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeDaPartida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPartida);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "Form1";
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeDaPartida;
        private System.Windows.Forms.TextBox senhaDaPartida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeDoGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idDaPartida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nomeDoJogador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox confirmarSenha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXB_IDJogador;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXB_SenhaJogador;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox TXB_Cartas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox personagens;
    }
}

