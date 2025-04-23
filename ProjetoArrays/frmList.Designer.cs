namespace ProjetoArrays
{
    partial class frmList
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
            this.btnCarregaLista = new System.Windows.Forms.Button();
            this.lstList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCarregaLista
            // 
            this.btnCarregaLista.Location = new System.Drawing.Point(21, 349);
            this.btnCarregaLista.Name = "btnCarregaLista";
            this.btnCarregaLista.Size = new System.Drawing.Size(254, 87);
            this.btnCarregaLista.TabIndex = 0;
            this.btnCarregaLista.Text = "Carrega Lista";
            this.btnCarregaLista.UseVisualStyleBackColor = true;
            this.btnCarregaLista.Click += new System.EventHandler(this.btnCarregaLista_Click);
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.Location = new System.Drawing.Point(317, 27);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(462, 407);
            this.lstList.TabIndex = 1;
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.btnCarregaLista);
            this.Name = "frmList";
            this.Text = "frmList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarregaLista;
        private System.Windows.Forms.ListBox lstList;
    }
}