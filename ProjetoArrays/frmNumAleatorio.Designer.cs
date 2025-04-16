namespace ProjetoArrays
{
    partial class frmNumAleatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNumAleatorio));
            this.gbpAleatorio = new System.Windows.Forms.GroupBox();
            this.ltbMostraNumero = new System.Windows.Forms.ListBox();
            this.lblInsiraNumero = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtInsiraNumero = new System.Windows.Forms.TextBox();
            this.gbpAleatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbpAleatorio
            // 
            this.gbpAleatorio.BackColor = System.Drawing.Color.Gainsboro;
            this.gbpAleatorio.Controls.Add(this.txtInsiraNumero);
            this.gbpAleatorio.Controls.Add(this.ltbMostraNumero);
            this.gbpAleatorio.Controls.Add(this.lblInsiraNumero);
            this.gbpAleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbpAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpAleatorio.Location = new System.Drawing.Point(12, 16);
            this.gbpAleatorio.Name = "gbpAleatorio";
            this.gbpAleatorio.Size = new System.Drawing.Size(468, 232);
            this.gbpAleatorio.TabIndex = 0;
            this.gbpAleatorio.TabStop = false;
            this.gbpAleatorio.Text = "Valores";
            // 
            // ltbMostraNumero
            // 
            this.ltbMostraNumero.FormattingEnabled = true;
            this.ltbMostraNumero.ItemHeight = 20;
            this.ltbMostraNumero.Location = new System.Drawing.Point(250, 39);
            this.ltbMostraNumero.Name = "ltbMostraNumero";
            this.ltbMostraNumero.Size = new System.Drawing.Size(199, 184);
            this.ltbMostraNumero.TabIndex = 2;
            this.ltbMostraNumero.TabStop = false;
            // 
            // lblInsiraNumero
            // 
            this.lblInsiraNumero.AutoSize = true;
            this.lblInsiraNumero.Location = new System.Drawing.Point(16, 39);
            this.lblInsiraNumero.Name = "lblInsiraNumero";
            this.lblInsiraNumero.Size = new System.Drawing.Size(119, 20);
            this.lblInsiraNumero.TabIndex = 0;
            this.lblInsiraNumero.Text = "Insira o número";
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(12, 266);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(152, 48);
            this.btnGerar.TabIndex = 3;
            this.btnGerar.Text = "&Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(170, 266);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(152, 48);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(328, 266);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(152, 48);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtInsiraNumero
            // 
            this.txtInsiraNumero.Location = new System.Drawing.Point(16, 62);
            this.txtInsiraNumero.MaxLength = 12;
            this.txtInsiraNumero.Name = "txtInsiraNumero";
            this.txtInsiraNumero.Size = new System.Drawing.Size(187, 26);
            this.txtInsiraNumero.TabIndex = 1;
            // 
            // frmNumAleatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 328);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.gbpAleatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNumAleatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aleatório";
            this.gbpAleatorio.ResumeLayout(false);
            this.gbpAleatorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbpAleatorio;
        private System.Windows.Forms.ListBox ltbMostraNumero;
        private System.Windows.Forms.Label lblInsiraNumero;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtInsiraNumero;
    }
}