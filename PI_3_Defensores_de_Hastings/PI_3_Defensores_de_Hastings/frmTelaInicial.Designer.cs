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
            this.btnAbrirLobby.Location = new System.Drawing.Point(18, 160);
            this.btnAbrirLobby.Name = "btnAbrirLobby";
            this.btnAbrirLobby.Size = new System.Drawing.Size(194, 65);
            this.btnAbrirLobby.TabIndex = 0;
            this.btnAbrirLobby.Text = "Lobby";
            this.btnAbrirLobby.UseVisualStyleBackColor = true;
            this.btnAbrirLobby.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(120, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "King Me!";
            // 
            // lblControleVersao
            // 
            this.lblControleVersao.AutoSize = true;
            this.lblControleVersao.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControleVersao.Location = new System.Drawing.Point(741, 421);
            this.lblControleVersao.Name = "lblControleVersao";
            this.lblControleVersao.Size = new System.Drawing.Size(47, 20);
            this.lblControleVersao.TabIndex = 2;
            this.lblControleVersao.Text = "Versao";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(18, 63);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(194, 65);
            this.btnCriarPartida.TabIndex = 3;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.lblControleVersao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAbrirLobby);
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