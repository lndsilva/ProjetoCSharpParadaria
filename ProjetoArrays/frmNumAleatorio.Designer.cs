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
            this.txtInsiraNumero = new System.Windows.Forms.TextBox();
            this.ltbMostraNumero = new System.Windows.Forms.ListBox();
            this.lblInsiraNumero = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbSeleciona = new System.Windows.Forms.GroupBox();
            this.rdbInteirosAleatorios = new System.Windows.Forms.RadioButton();
            this.rdbVariosInteirosAleatorios = new System.Windows.Forms.RadioButton();
            this.rdbGerarFloatsAleatorios = new System.Windows.Forms.RadioButton();
            this.rdbInteirosAleatoriosIntervalos = new System.Windows.Forms.RadioButton();
            this.rdbAleatoriosRepeticao = new System.Windows.Forms.RadioButton();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.gbpAleatorio.SuspendLayout();
            this.gpbSeleciona.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbpAleatorio
            // 
            this.gbpAleatorio.BackColor = System.Drawing.Color.Gainsboro;
            this.gbpAleatorio.Controls.Add(this.txtTamanho);
            this.gbpAleatorio.Controls.Add(this.lblTamanho);
            this.gbpAleatorio.Controls.Add(this.gpbSeleciona);
            this.gbpAleatorio.Controls.Add(this.txtMaximo);
            this.gbpAleatorio.Controls.Add(this.label2);
            this.gbpAleatorio.Controls.Add(this.txtMinimo);
            this.gbpAleatorio.Controls.Add(this.label1);
            this.gbpAleatorio.Controls.Add(this.txtInsiraNumero);
            this.gbpAleatorio.Controls.Add(this.ltbMostraNumero);
            this.gbpAleatorio.Controls.Add(this.lblInsiraNumero);
            this.gbpAleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbpAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpAleatorio.Location = new System.Drawing.Point(12, 16);
            this.gbpAleatorio.Name = "gbpAleatorio";
            this.gbpAleatorio.Size = new System.Drawing.Size(699, 284);
            this.gbpAleatorio.TabIndex = 0;
            this.gbpAleatorio.TabStop = false;
            this.gbpAleatorio.Text = "Valores";
            // 
            // txtInsiraNumero
            // 
            this.txtInsiraNumero.Location = new System.Drawing.Point(17, 110);
            this.txtInsiraNumero.MaxLength = 10;
            this.txtInsiraNumero.Name = "txtInsiraNumero";
            this.txtInsiraNumero.Size = new System.Drawing.Size(119, 26);
            this.txtInsiraNumero.TabIndex = 2;
            // 
            // ltbMostraNumero
            // 
            this.ltbMostraNumero.FormattingEnabled = true;
            this.ltbMostraNumero.ItemHeight = 20;
            this.ltbMostraNumero.Location = new System.Drawing.Point(480, 40);
            this.ltbMostraNumero.Name = "ltbMostraNumero";
            this.ltbMostraNumero.Size = new System.Drawing.Size(199, 224);
            this.ltbMostraNumero.TabIndex = 2;
            this.ltbMostraNumero.TabStop = false;
            // 
            // lblInsiraNumero
            // 
            this.lblInsiraNumero.AutoSize = true;
            this.lblInsiraNumero.Location = new System.Drawing.Point(17, 87);
            this.lblInsiraNumero.Name = "lblInsiraNumero";
            this.lblInsiraNumero.Size = new System.Drawing.Size(119, 20);
            this.lblInsiraNumero.TabIndex = 0;
            this.lblInsiraNumero.Text = "Insira o número";
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(12, 316);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(152, 48);
            this.btnGerar.TabIndex = 11;
            this.btnGerar.Text = "&Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(273, 316);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(152, 48);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(553, 316);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(152, 48);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(17, 172);
            this.txtMinimo.MaxLength = 10;
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(119, 26);
            this.txtMinimo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número mínimo";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(17, 238);
            this.txtMaximo.MaxLength = 10;
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(119, 26);
            this.txtMaximo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número máximo";
            // 
            // gpbSeleciona
            // 
            this.gpbSeleciona.Controls.Add(this.rdbAleatoriosRepeticao);
            this.gpbSeleciona.Controls.Add(this.rdbGerarFloatsAleatorios);
            this.gpbSeleciona.Controls.Add(this.rdbInteirosAleatoriosIntervalos);
            this.gpbSeleciona.Controls.Add(this.rdbVariosInteirosAleatorios);
            this.gpbSeleciona.Controls.Add(this.rdbInteirosAleatorios);
            this.gpbSeleciona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbSeleciona.Location = new System.Drawing.Point(209, 61);
            this.gpbSeleciona.Name = "gpbSeleciona";
            this.gpbSeleciona.Size = new System.Drawing.Size(251, 184);
            this.gpbSeleciona.TabIndex = 5;
            this.gpbSeleciona.TabStop = false;
            this.gpbSeleciona.Text = "Selecione";
            // 
            // rdbInteirosAleatorios
            // 
            this.rdbInteirosAleatorios.AutoSize = true;
            this.rdbInteirosAleatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInteirosAleatorios.Location = new System.Drawing.Point(30, 31);
            this.rdbInteirosAleatorios.Name = "rdbInteirosAleatorios";
            this.rdbInteirosAleatorios.Size = new System.Drawing.Size(143, 22);
            this.rdbInteirosAleatorios.TabIndex = 6;
            this.rdbInteirosAleatorios.Text = "Inteiros aleatórios";
            this.rdbInteirosAleatorios.UseVisualStyleBackColor = true;
            this.rdbInteirosAleatorios.CheckedChanged += new System.EventHandler(this.rdbInteirosAleatorios_CheckedChanged);
            // 
            // rdbVariosInteirosAleatorios
            // 
            this.rdbVariosInteirosAleatorios.AutoSize = true;
            this.rdbVariosInteirosAleatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVariosInteirosAleatorios.Location = new System.Drawing.Point(30, 62);
            this.rdbVariosInteirosAleatorios.Name = "rdbVariosInteirosAleatorios";
            this.rdbVariosInteirosAleatorios.Size = new System.Drawing.Size(189, 22);
            this.rdbVariosInteirosAleatorios.TabIndex = 7;
            this.rdbVariosInteirosAleatorios.Text = "Vários inteiros aleatórios";
            this.rdbVariosInteirosAleatorios.UseVisualStyleBackColor = true;
            this.rdbVariosInteirosAleatorios.CheckedChanged += new System.EventHandler(this.rdbVariosInteirosAleatorios_CheckedChanged);
            // 
            // rdbGerarFloatsAleatorios
            // 
            this.rdbGerarFloatsAleatorios.AutoSize = true;
            this.rdbGerarFloatsAleatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGerarFloatsAleatorios.Location = new System.Drawing.Point(30, 123);
            this.rdbGerarFloatsAleatorios.Name = "rdbGerarFloatsAleatorios";
            this.rdbGerarFloatsAleatorios.Size = new System.Drawing.Size(179, 22);
            this.rdbGerarFloatsAleatorios.TabIndex = 9;
            this.rdbGerarFloatsAleatorios.Text = "Gerar Floats Aleatórios";
            this.rdbGerarFloatsAleatorios.UseVisualStyleBackColor = true;
            this.rdbGerarFloatsAleatorios.CheckedChanged += new System.EventHandler(this.rdbGerarFloatsAleatorios_CheckedChanged);
            // 
            // rdbInteirosAleatoriosIntervalos
            // 
            this.rdbInteirosAleatoriosIntervalos.AutoSize = true;
            this.rdbInteirosAleatoriosIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInteirosAleatoriosIntervalos.Location = new System.Drawing.Point(30, 92);
            this.rdbInteirosAleatoriosIntervalos.Name = "rdbInteirosAleatoriosIntervalos";
            this.rdbInteirosAleatoriosIntervalos.Size = new System.Drawing.Size(210, 22);
            this.rdbInteirosAleatoriosIntervalos.TabIndex = 8;
            this.rdbInteirosAleatoriosIntervalos.Text = "Inteiros aleatórios intervalos";
            this.rdbInteirosAleatoriosIntervalos.UseVisualStyleBackColor = true;
            this.rdbInteirosAleatoriosIntervalos.CheckedChanged += new System.EventHandler(this.rdbInteirosAleatoriosIntervalos_CheckedChanged);
            // 
            // rdbAleatoriosRepeticao
            // 
            this.rdbAleatoriosRepeticao.AutoSize = true;
            this.rdbAleatoriosRepeticao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAleatoriosRepeticao.Location = new System.Drawing.Point(30, 151);
            this.rdbAleatoriosRepeticao.Name = "rdbAleatoriosRepeticao";
            this.rdbAleatoriosRepeticao.Size = new System.Drawing.Size(163, 22);
            this.rdbAleatoriosRepeticao.TabIndex = 10;
            this.rdbAleatoriosRepeticao.Text = "Aleatórios Repetição";
            this.rdbAleatoriosRepeticao.UseVisualStyleBackColor = true;
            this.rdbAleatoriosRepeticao.CheckedChanged += new System.EventHandler(this.rdbAleatoriosRepeticao_CheckedChanged);
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(17, 50);
            this.txtTamanho.MaxLength = 10;
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(119, 26);
            this.txtTamanho.TabIndex = 1;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(17, 27);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(128, 20);
            this.lblTamanho.TabIndex = 6;
            this.lblTamanho.Text = "Insira o tamanho";
            // 
            // frmNumAleatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 377);
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
            this.gpbSeleciona.ResumeLayout(false);
            this.gpbSeleciona.PerformLayout();
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
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbSeleciona;
        private System.Windows.Forms.RadioButton rdbGerarFloatsAleatorios;
        private System.Windows.Forms.RadioButton rdbInteirosAleatoriosIntervalos;
        private System.Windows.Forms.RadioButton rdbVariosInteirosAleatorios;
        private System.Windows.Forms.RadioButton rdbInteirosAleatorios;
        private System.Windows.Forms.RadioButton rdbAleatoriosRepeticao;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label lblTamanho;
    }
}