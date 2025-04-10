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
            this.btnVoltaJogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPartida
            // 
            this.btnPartida.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPartida.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartida.Font = new System.Drawing.Font("Sitka Display", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPartida.ForeColor = System.Drawing.Color.Black;
            this.btnPartida.Location = new System.Drawing.Point(13, 490);
            this.btnPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPartida.Name = "btnPartida";
            this.btnPartida.Size = new System.Drawing.Size(182, 71);
            this.btnPartida.TabIndex = 0;
            this.btnPartida.TabStop = false;
            this.btnPartida.Text = "Criar";
            this.btnPartida.UseVisualStyleBackColor = false;
            this.btnPartida.Click += new System.EventHandler(this.btnPartida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Partida:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomeDaPartida
            // 
            this.nomeDaPartida.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeDaPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeDaPartida.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.nomeDaPartida.Location = new System.Drawing.Point(14, 103);
            this.nomeDaPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nomeDaPartida.Name = "nomeDaPartida";
            this.nomeDaPartida.Size = new System.Drawing.Size(182, 23);
            this.nomeDaPartida.TabIndex = 2;
            this.nomeDaPartida.TextChanged += new System.EventHandler(this.nomeDaPartida_TextChanged);
            // 
            // senhaDaPartida
            // 
            this.senhaDaPartida.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.senhaDaPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhaDaPartida.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.senhaDaPartida.Location = new System.Drawing.Point(14, 190);
            this.senhaDaPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.senhaDaPartida.Name = "senhaDaPartida";
            this.senhaDaPartida.Size = new System.Drawing.Size(182, 23);
            this.senhaDaPartida.TabIndex = 4;
            this.senhaDaPartida.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(13, 166);
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
            this.nomeDoGrupo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.nomeDoGrupo.Location = new System.Drawing.Point(15, 271);
            this.nomeDoGrupo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nomeDoGrupo.Name = "nomeDoGrupo";
            this.nomeDoGrupo.Size = new System.Drawing.Size(181, 23);
            this.nomeDoGrupo.TabIndex = 6;
            this.nomeDoGrupo.Text = "Defensores de Hastings";
            this.nomeDoGrupo.TextChanged += new System.EventHandler(this.nomeDoGrupo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(11, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grupo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Diagram;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Edwardian Script ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(231, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(480, 76);
            this.label4.TabIndex = 7;
            this.label4.Text = "Defensores de Hastings\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // idDaPartida
            // 
            this.idDaPartida.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.idDaPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idDaPartida.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.idDaPartida.Location = new System.Drawing.Point(15, 362);
            this.idDaPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idDaPartida.Name = "idDaPartida";
            this.idDaPartida.ReadOnly = true;
            this.idDaPartida.Size = new System.Drawing.Size(181, 23);
            this.idDaPartida.TabIndex = 9;
            this.idDaPartida.TextChanged += new System.EventHandler(this.idDaPartida_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(13, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID:";
            // 
            // btnVoltaJogo
            // 
            this.btnVoltaJogo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVoltaJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltaJogo.Font = new System.Drawing.Font("Sitka Display", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnVoltaJogo.ForeColor = System.Drawing.Color.Black;
            this.btnVoltaJogo.Location = new System.Drawing.Point(722, 489);
            this.btnVoltaJogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltaJogo.Name = "btnVoltaJogo";
            this.btnVoltaJogo.Size = new System.Drawing.Size(182, 71);
            this.btnVoltaJogo.TabIndex = 16;
            this.btnVoltaJogo.TabStop = false;
            this.btnVoltaJogo.Text = "Voltar";
            this.btnVoltaJogo.UseVisualStyleBackColor = false;
            this.btnVoltaJogo.Click += new System.EventHandler(this.btnChamaForms2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(934, 658);
            this.Controls.Add(this.btnVoltaJogo);
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
            this.Font = new System.Drawing.Font("Sitka Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(949, 693);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnVoltaJogo;
    }
}

