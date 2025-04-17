namespace ProjetoArrays
{
    partial class frmMatrizes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatrizes));
            this.btnCarregaMatriz = new System.Windows.Forms.Button();
            this.ltbListaMatriz = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbListaMatriz = new System.Windows.Forms.GroupBox();
            this.lblLinha = new System.Windows.Forms.Label();
            this.txtLinha = new System.Windows.Forms.TextBox();
            this.txtColuna = new System.Windows.Forms.TextBox();
            this.lblColuna = new System.Windows.Forms.Label();
            this.gpbListaMatriz.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarregaMatriz
            // 
            this.btnCarregaMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaMatriz.Location = new System.Drawing.Point(12, 381);
            this.btnCarregaMatriz.Name = "btnCarregaMatriz";
            this.btnCarregaMatriz.Size = new System.Drawing.Size(200, 57);
            this.btnCarregaMatriz.TabIndex = 0;
            this.btnCarregaMatriz.Text = "Carrega Matriz";
            this.btnCarregaMatriz.UseVisualStyleBackColor = true;
            this.btnCarregaMatriz.Click += new System.EventHandler(this.btnCarregaMatriz_Click);
            // 
            // ltbListaMatriz
            // 
            this.ltbListaMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaMatriz.FormattingEnabled = true;
            this.ltbListaMatriz.ItemHeight = 20;
            this.ltbListaMatriz.Location = new System.Drawing.Point(497, 5);
            this.ltbListaMatriz.Name = "ltbListaMatriz";
            this.ltbListaMatriz.Size = new System.Drawing.Size(200, 344);
            this.ltbListaMatriz.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(257, 381);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(200, 57);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(497, 381);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(200, 57);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gpbListaMatriz
            // 
            this.gpbListaMatriz.Controls.Add(this.txtColuna);
            this.gpbListaMatriz.Controls.Add(this.lblColuna);
            this.gpbListaMatriz.Controls.Add(this.txtLinha);
            this.gpbListaMatriz.Controls.Add(this.lblLinha);
            this.gpbListaMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbListaMatriz.Location = new System.Drawing.Point(10, 5);
            this.gpbListaMatriz.Name = "gpbListaMatriz";
            this.gpbListaMatriz.Size = new System.Drawing.Size(471, 344);
            this.gpbListaMatriz.TabIndex = 4;
            this.gpbListaMatriz.TabStop = false;
            this.gpbListaMatriz.Text = "Lista matriz";
            // 
            // lblLinha
            // 
            this.lblLinha.AutoSize = true;
            this.lblLinha.Location = new System.Drawing.Point(35, 53);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(48, 20);
            this.lblLinha.TabIndex = 0;
            this.lblLinha.Text = "Linha";
            // 
            // txtLinha
            // 
            this.txtLinha.Location = new System.Drawing.Point(85, 50);
            this.txtLinha.MaxLength = 100;
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(100, 26);
            this.txtLinha.TabIndex = 1;
            // 
            // txtColuna
            // 
            this.txtColuna.Location = new System.Drawing.Point(85, 104);
            this.txtColuna.MaxLength = 100;
            this.txtColuna.Name = "txtColuna";
            this.txtColuna.Size = new System.Drawing.Size(100, 26);
            this.txtColuna.TabIndex = 3;
            // 
            // lblColuna
            // 
            this.lblColuna.AutoSize = true;
            this.lblColuna.Location = new System.Drawing.Point(24, 107);
            this.lblColuna.Name = "lblColuna";
            this.lblColuna.Size = new System.Drawing.Size(59, 20);
            this.lblColuna.TabIndex = 2;
            this.lblColuna.Text = "Coluna";
            // 
            // frmMatrizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.gpbListaMatriz);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.ltbListaMatriz);
            this.Controls.Add(this.btnCarregaMatriz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMatrizes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrizes";
            this.gpbListaMatriz.ResumeLayout(false);
            this.gpbListaMatriz.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarregaMatriz;
        private System.Windows.Forms.ListBox ltbListaMatriz;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gpbListaMatriz;
        private System.Windows.Forms.TextBox txtColuna;
        private System.Windows.Forms.Label lblColuna;
        private System.Windows.Forms.TextBox txtLinha;
        private System.Windows.Forms.Label lblLinha;
    }
}