namespace PI_3_Defensores_de_Hastings
{
    partial class frmLobby
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPartidas = new System.Windows.Forms.DataGridView();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtbSenhaDaSala = new System.Windows.Forms.TextBox();
            this.txtbNomeDoJogador = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPartidas
            // 
            this.dgvPartidas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPartidas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPartidas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPartidas.GridColor = System.Drawing.Color.White;
            this.dgvPartidas.Location = new System.Drawing.Point(12, 12);
            this.dgvPartidas.Name = "dgvPartidas";
            this.dgvPartidas.Size = new System.Drawing.Size(501, 426);
            this.dgvPartidas.TabIndex = 0;
            this.dgvPartidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(560, 281);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(228, 59);
            this.btnEntrarPartida.TabIndex = 1;
            this.btnEntrarPartida.Text = "Entrar";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(560, 379);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(228, 59);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtbSenhaDaSala
            // 
            this.txtbSenhaDaSala.Location = new System.Drawing.Point(560, 107);
            this.txtbSenhaDaSala.Name = "txtbSenhaDaSala";
            this.txtbSenhaDaSala.Size = new System.Drawing.Size(228, 20);
            this.txtbSenhaDaSala.TabIndex = 18;
            // 
            // txtbNomeDoJogador
            // 
            this.txtbNomeDoJogador.Location = new System.Drawing.Point(560, 48);
            this.txtbNomeDoJogador.Name = "txtbNomeDoJogador";
            this.txtbNomeDoJogador.Size = new System.Drawing.Size(228, 20);
            this.txtbNomeDoJogador.TabIndex = 17;
            this.txtbNomeDoJogador.TextChanged += new System.EventHandler(this.txtbNomeDoJogador_TextChanged);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(557, 91);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(80, 13);
            this.lblSenha.TabIndex = 16;
            this.lblSenha.Text = "Senha da Sala:";
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(557, 32);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(94, 13);
            this.lblNomeJogador.TabIndex = 15;
            this.lblNomeJogador.Text = "Nome do Jogador:";
            // 
            // frmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbSenhaDaSala);
            this.Controls.Add(this.txtbNomeDoJogador);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.dgvPartidas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmLobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLobby";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPartidas;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtbSenhaDaSala;
        private System.Windows.Forms.TextBox txtbNomeDoJogador;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNomeJogador;
    }
}