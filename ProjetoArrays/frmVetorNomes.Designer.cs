namespace ProjetoArrays
{
    partial class frmVetorNomes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVetorNomes));
            this.brnCarregaNomes = new System.Windows.Forms.Button();
            this.lblDigiteSeuNome = new System.Windows.Forms.Label();
            this.txtNomes = new System.Windows.Forms.TextBox();
            this.ltbNomes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // brnCarregaNomes
            // 
            this.brnCarregaNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnCarregaNomes.Location = new System.Drawing.Point(61, 355);
            this.brnCarregaNomes.Name = "brnCarregaNomes";
            this.brnCarregaNomes.Size = new System.Drawing.Size(212, 64);
            this.brnCarregaNomes.TabIndex = 1;
            this.brnCarregaNomes.Text = "Carrega nomes";
            this.brnCarregaNomes.UseVisualStyleBackColor = true;
            this.brnCarregaNomes.Click += new System.EventHandler(this.brnCarregaNomes_Click);
            // 
            // lblDigiteSeuNome
            // 
            this.lblDigiteSeuNome.AutoSize = true;
            this.lblDigiteSeuNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteSeuNome.Location = new System.Drawing.Point(61, 72);
            this.lblDigiteSeuNome.Name = "lblDigiteSeuNome";
            this.lblDigiteSeuNome.Size = new System.Drawing.Size(124, 20);
            this.lblDigiteSeuNome.TabIndex = 1;
            this.lblDigiteSeuNome.Text = "Digite seu nome";
            // 
            // txtNomes
            // 
            this.txtNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomes.Location = new System.Drawing.Point(61, 105);
            this.txtNomes.MaxLength = 30;
            this.txtNomes.Name = "txtNomes";
            this.txtNomes.Size = new System.Drawing.Size(199, 26);
            this.txtNomes.TabIndex = 0;
            // 
            // ltbNomes
            // 
            this.ltbNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbNomes.FormattingEnabled = true;
            this.ltbNomes.ItemHeight = 20;
            this.ltbNomes.Location = new System.Drawing.Point(348, 53);
            this.ltbNomes.Name = "ltbNomes";
            this.ltbNomes.Size = new System.Drawing.Size(279, 264);
            this.ltbNomes.TabIndex = 2;
            // 
            // frmVetorNomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 439);
            this.Controls.Add(this.ltbNomes);
            this.Controls.Add(this.txtNomes);
            this.Controls.Add(this.lblDigiteSeuNome);
            this.Controls.Add(this.brnCarregaNomes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVetorNomes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vetor de Nomes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnCarregaNomes;
        private System.Windows.Forms.Label lblDigiteSeuNome;
        private System.Windows.Forms.TextBox txtNomes;
        private System.Windows.Forms.ListBox ltbNomes;
    }
}