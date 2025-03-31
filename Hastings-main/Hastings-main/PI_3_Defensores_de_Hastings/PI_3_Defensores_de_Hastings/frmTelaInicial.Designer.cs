namespace PI_3_Defensores_de_Hastings
{
    partial class frmTelaInicial
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
            this.btnAbrirLobby = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblControleVersao = new System.Windows.Forms.Label();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirLobby
            // 
            this.btnAbrirLobby.Font = new System.Drawing.Font("Sitka Display", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirLobby.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAbrirLobby.Location = new System.Drawing.Point(352, 342);
            this.btnAbrirLobby.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbrirLobby.Name = "btnAbrirLobby";
            this.btnAbrirLobby.Size = new System.Drawing.Size(227, 72);
            this.btnAbrirLobby.TabIndex = 0;
            this.btnAbrirLobby.Text = "Lobby";
            this.btnAbrirLobby.UseVisualStyleBackColor = true;
            this.btnAbrirLobby.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Edwardian Script ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(295, 22);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(324, 94);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "King Me!";
            // 
            // lblControleVersao
            // 
            this.lblControleVersao.AutoSize = true;
            this.lblControleVersao.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControleVersao.Location = new System.Drawing.Point(864, 615);
            this.lblControleVersao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControleVersao.Name = "lblControleVersao";
            this.lblControleVersao.Size = new System.Drawing.Size(61, 23);
            this.lblControleVersao.TabIndex = 2;
            this.lblControleVersao.Text = "Versao";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCriarPartida.Font = new System.Drawing.Font("Sitka Display", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPartida.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCriarPartida.Location = new System.Drawing.Point(352, 205);
            this.btnCriarPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(227, 76);
            this.btnCriarPartida.TabIndex = 3;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(934, 658);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.lblControleVersao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAbrirLobby);
            this.Font = new System.Drawing.Font("Sitka Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.Tela2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirLobby;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblControleVersao;
        private System.Windows.Forms.Button btnCriarPartida;
    }
}