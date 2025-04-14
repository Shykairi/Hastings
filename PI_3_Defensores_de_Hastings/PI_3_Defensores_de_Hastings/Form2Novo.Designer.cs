namespace PI_3_Defensores_de_Hastings
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnColocarPerso = new System.Windows.Forms.Button();
            this.btnPromover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 721);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnColocarPerso
            // 
            this.btnColocarPerso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnColocarPerso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColocarPerso.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnColocarPerso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColocarPerso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColocarPerso.Location = new System.Drawing.Point(615, 585);
            this.btnColocarPerso.Name = "btnColocarPerso";
            this.btnColocarPerso.Size = new System.Drawing.Size(75, 23);
            this.btnColocarPerso.TabIndex = 1;
            this.btnColocarPerso.Text = "Colocar Personagem";
            this.btnColocarPerso.UseVisualStyleBackColor = false;
            this.btnColocarPerso.Click += new System.EventHandler(this.btnColocarPerso_Click);
            // 
            // btnPromover
            // 
            this.btnPromover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPromover.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPromover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromover.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromover.Location = new System.Drawing.Point(615, 547);
            this.btnPromover.Name = "btnPromover";
            this.btnPromover.Size = new System.Drawing.Size(75, 23);
            this.btnPromover.TabIndex = 2;
            this.btnPromover.Text = "Promover";
            this.btnPromover.UseVisualStyleBackColor = false;
            this.btnPromover.Click += new System.EventHandler(this.btnPromover_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(802, 721);
            this.Controls.Add(this.btnPromover);
            this.Controls.Add(this.btnColocarPerso);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnColocarPerso;
        private System.Windows.Forms.Button btnPromover;
    }
}