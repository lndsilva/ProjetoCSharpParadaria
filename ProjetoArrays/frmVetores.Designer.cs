﻿namespace ProjetoArrays
{
    partial class frmVetores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVetores));
            this.gpbNomes = new System.Windows.Forms.GroupBox();
            this.lblListaNomes = new System.Windows.Forms.Label();
            this.ltbNomes = new System.Windows.Forms.ListBox();
            this.btnCarrega = new System.Windows.Forms.Button();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbNomes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbNomes
            // 
            this.gpbNomes.Controls.Add(this.textBox1);
            this.gpbNomes.Controls.Add(this.label1);
            this.gpbNomes.Controls.Add(this.txtTamanho);
            this.gpbNomes.Controls.Add(this.lblTamanho);
            this.gpbNomes.Controls.Add(this.lblListaNomes);
            this.gpbNomes.Controls.Add(this.ltbNomes);
            this.gpbNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNomes.Location = new System.Drawing.Point(21, 12);
            this.gpbNomes.Name = "gpbNomes";
            this.gpbNomes.Size = new System.Drawing.Size(541, 306);
            this.gpbNomes.TabIndex = 0;
            this.gpbNomes.TabStop = false;
            this.gpbNomes.Text = "Nomes";
            // 
            // lblListaNomes
            // 
            this.lblListaNomes.AutoSize = true;
            this.lblListaNomes.Location = new System.Drawing.Point(285, 22);
            this.lblListaNomes.Name = "lblListaNomes";
            this.lblListaNomes.Size = new System.Drawing.Size(109, 20);
            this.lblListaNomes.TabIndex = 1;
            this.lblListaNomes.Text = "Lista de nome";
            // 
            // ltbNomes
            // 
            this.ltbNomes.FormattingEnabled = true;
            this.ltbNomes.ItemHeight = 20;
            this.ltbNomes.Location = new System.Drawing.Point(285, 57);
            this.ltbNomes.Name = "ltbNomes";
            this.ltbNomes.Size = new System.Drawing.Size(246, 224);
            this.ltbNomes.TabIndex = 0;
            // 
            // btnCarrega
            // 
            this.btnCarrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrega.Location = new System.Drawing.Point(22, 330);
            this.btnCarrega.Name = "btnCarrega";
            this.btnCarrega.Size = new System.Drawing.Size(199, 63);
            this.btnCarrega.TabIndex = 1;
            this.btnCarrega.Text = "Carrega";
            this.btnCarrega.UseVisualStyleBackColor = true;
            this.btnCarrega.Click += new System.EventHandler(this.btnCarrega_Click);
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(24, 48);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(76, 20);
            this.lblTamanho.TabIndex = 2;
            this.lblTamanho.Text = "Tamanho";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(24, 71);
            this.txtTamanho.MaxLength = 3;
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(76, 26);
            this.txtTamanho.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 142);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 26);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Insira um nome";
            // 
            // frmVetores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.btnCarrega);
            this.Controls.Add(this.gpbNomes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVetores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vetores";
            this.gpbNomes.ResumeLayout(false);
            this.gpbNomes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbNomes;
        private System.Windows.Forms.ListBox ltbNomes;
        private System.Windows.Forms.Button btnCarrega;
        private System.Windows.Forms.Label lblListaNomes;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}