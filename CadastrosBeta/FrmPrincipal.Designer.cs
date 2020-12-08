namespace CadastrosBeta
{
    partial class FrmPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.LblPessoas = new System.Windows.Forms.Label();
            this.PicBPessoas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(363, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblPessoas
            // 
            this.LblPessoas.AutoSize = true;
            this.LblPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPessoas.Location = new System.Drawing.Point(12, 131);
            this.LblPessoas.Name = "LblPessoas";
            this.LblPessoas.Size = new System.Drawing.Size(158, 16);
            this.LblPessoas.TabIndex = 2;
            this.LblPessoas.Text = "Cadastro de Pessoas";
            // 
            // PicBPessoas
            // 
            this.PicBPessoas.Image = global::CadastrosBeta.Properties.Resources.pessoas;
            this.PicBPessoas.Location = new System.Drawing.Point(26, 12);
            this.PicBPessoas.Name = "PicBPessoas";
            this.PicBPessoas.Size = new System.Drawing.Size(121, 115);
            this.PicBPessoas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBPessoas.TabIndex = 1;
            this.PicBPessoas.TabStop = false;
            this.PicBPessoas.Click += new System.EventHandler(this.PicBPessoas_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 326);
            this.Controls.Add(this.LblPessoas);
            this.Controls.Add(this.PicBPessoas);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicativo de Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PicBPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PicBPessoas;
        private System.Windows.Forms.Label LblPessoas;
    }
}