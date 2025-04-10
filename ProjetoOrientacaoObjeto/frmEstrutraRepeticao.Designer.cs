namespace ProjetoOrientacaoObjeto
{
    partial class frmEstrutraRepeticao
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
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.ltbListaDesejos = new System.Windows.Forms.ListBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblListaDesejos = new System.Windows.Forms.Label();
            this.btnCarregaEstado = new System.Windows.Forms.Button();
            this.btnCarregaListaDesejos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbEstado
            // 
            this.cbbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(76, 57);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(192, 28);
            this.cbbEstado.TabIndex = 0;
            // 
            // ltbListaDesejos
            // 
            this.ltbListaDesejos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaDesejos.FormattingEnabled = true;
            this.ltbListaDesejos.ItemHeight = 20;
            this.ltbListaDesejos.Location = new System.Drawing.Point(335, 56);
            this.ltbListaDesejos.Name = "ltbListaDesejos";
            this.ltbListaDesejos.Size = new System.Drawing.Size(202, 204);
            this.ltbListaDesejos.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(72, 34);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado";
            // 
            // lblListaDesejos
            // 
            this.lblListaDesejos.AutoSize = true;
            this.lblListaDesejos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDesejos.Location = new System.Drawing.Point(331, 33);
            this.lblListaDesejos.Name = "lblListaDesejos";
            this.lblListaDesejos.Size = new System.Drawing.Size(124, 20);
            this.lblListaDesejos.TabIndex = 3;
            this.lblListaDesejos.Text = "Lista de desejos";
            // 
            // btnCarregaEstado
            // 
            this.btnCarregaEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaEstado.Location = new System.Drawing.Point(76, 318);
            this.btnCarregaEstado.Name = "btnCarregaEstado";
            this.btnCarregaEstado.Size = new System.Drawing.Size(174, 56);
            this.btnCarregaEstado.TabIndex = 4;
            this.btnCarregaEstado.Text = "Carrega Estado";
            this.btnCarregaEstado.UseVisualStyleBackColor = true;
            this.btnCarregaEstado.Click += new System.EventHandler(this.btnCarregaEstado_Click);
            // 
            // btnCarregaListaDesejos
            // 
            this.btnCarregaListaDesejos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaListaDesejos.Location = new System.Drawing.Point(363, 318);
            this.btnCarregaListaDesejos.Name = "btnCarregaListaDesejos";
            this.btnCarregaListaDesejos.Size = new System.Drawing.Size(174, 56);
            this.btnCarregaListaDesejos.TabIndex = 5;
            this.btnCarregaListaDesejos.Text = "Carrega Lista Desejos";
            this.btnCarregaListaDesejos.UseVisualStyleBackColor = true;
            // 
            // frmEstrutraRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 405);
            this.Controls.Add(this.btnCarregaListaDesejos);
            this.Controls.Add(this.btnCarregaEstado);
            this.Controls.Add(this.lblListaDesejos);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.ltbListaDesejos);
            this.Controls.Add(this.cbbEstado);
            this.Name = "frmEstrutraRepeticao";
            this.Text = "frmEstrutraRepeticao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.ListBox ltbListaDesejos;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblListaDesejos;
        private System.Windows.Forms.Button btnCarregaEstado;
        private System.Windows.Forms.Button btnCarregaListaDesejos;
    }
}