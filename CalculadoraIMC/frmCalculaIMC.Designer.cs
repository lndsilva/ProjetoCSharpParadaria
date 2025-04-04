namespace CalculadoraIMC
{
    partial class frmCalculaIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculaIMC));
            this.gpbSelecioneSexo = new System.Windows.Forms.GroupBox();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCalculaIMC = new System.Windows.Forms.Panel();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.pctIMC = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.mskAltura = new System.Windows.Forms.MaskedTextBox();
            this.mskPeso = new System.Windows.Forms.MaskedTextBox();
            this.mskIdade = new System.Windows.Forms.MaskedTextBox();
            this.gpbSelecioneSexo.SuspendLayout();
            this.pnlCalculaIMC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIMC)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbSelecioneSexo
            // 
            this.gpbSelecioneSexo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbSelecioneSexo.Controls.Add(this.rdbMasculino);
            this.gpbSelecioneSexo.Controls.Add(this.rdbFeminino);
            this.gpbSelecioneSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbSelecioneSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSelecioneSexo.Location = new System.Drawing.Point(14, 65);
            this.gpbSelecioneSexo.Name = "gpbSelecioneSexo";
            this.gpbSelecioneSexo.Size = new System.Drawing.Size(438, 66);
            this.gpbSelecioneSexo.TabIndex = 0;
            this.gpbSelecioneSexo.TabStop = false;
            this.gpbSelecioneSexo.Text = "Selecione o sexo:";
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(105, 28);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(92, 24);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(235, 28);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(98, 24);
            this.rdbMasculino.TabIndex = 2;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(7, 10);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(135, 50);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(297, 10);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(135, 50);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(152, 10);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(135, 50);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(172, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(128, 25);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Calcula IMC";
            // 
            // pnlCalculaIMC
            // 
            this.pnlCalculaIMC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCalculaIMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCalculaIMC.Controls.Add(this.mskIdade);
            this.pnlCalculaIMC.Controls.Add(this.mskPeso);
            this.pnlCalculaIMC.Controls.Add(this.mskAltura);
            this.pnlCalculaIMC.Controls.Add(this.txtResultado);
            this.pnlCalculaIMC.Controls.Add(this.lblResultado);
            this.pnlCalculaIMC.Controls.Add(this.pctIMC);
            this.pnlCalculaIMC.Controls.Add(this.lblPeso);
            this.pnlCalculaIMC.Controls.Add(this.lblAltura);
            this.pnlCalculaIMC.Controls.Add(this.lblIdade);
            this.pnlCalculaIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCalculaIMC.Location = new System.Drawing.Point(14, 137);
            this.pnlCalculaIMC.Name = "pnlCalculaIMC";
            this.pnlCalculaIMC.Size = new System.Drawing.Size(438, 217);
            this.pnlCalculaIMC.TabIndex = 3;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(45, 31);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(50, 20);
            this.lblIdade.TabIndex = 0;
            this.lblIdade.Text = "Idade";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(44, 79);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(51, 20);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(50, 130);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(45, 20);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso";
            // 
            // pctIMC
            // 
            this.pctIMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctIMC.Location = new System.Drawing.Point(227, 28);
            this.pctIMC.Name = "pctIMC";
            this.pctIMC.Size = new System.Drawing.Size(187, 122);
            this.pctIMC.TabIndex = 6;
            this.pctIMC.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Location = new System.Drawing.Point(14, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 71);
            this.panel1.TabIndex = 8;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(13, 173);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 20);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(101, 170);
            this.txtResultado.MaxLength = 3;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(313, 26);
            this.txtResultado.TabIndex = 7;
            // 
            // mskAltura
            // 
            this.mskAltura.Location = new System.Drawing.Point(101, 76);
            this.mskAltura.Mask = "99.99";
            this.mskAltura.Name = "mskAltura";
            this.mskAltura.Size = new System.Drawing.Size(100, 26);
            this.mskAltura.TabIndex = 5;
            // 
            // mskPeso
            // 
            this.mskPeso.Location = new System.Drawing.Point(101, 127);
            this.mskPeso.Mask = "999";
            this.mskPeso.Name = "mskPeso";
            this.mskPeso.Size = new System.Drawing.Size(100, 26);
            this.mskPeso.TabIndex = 6;
            // 
            // mskIdade
            // 
            this.mskIdade.Location = new System.Drawing.Point(101, 28);
            this.mskIdade.Mask = "999";
            this.mskIdade.Name = "mskIdade";
            this.mskIdade.Size = new System.Drawing.Size(100, 26);
            this.mskIdade.TabIndex = 4;
            // 
            // frmCalculaIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 437);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCalculaIMC);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gpbSelecioneSexo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalculaIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCalculaIMC_Load);
            this.gpbSelecioneSexo.ResumeLayout(false);
            this.gpbSelecioneSexo.PerformLayout();
            this.pnlCalculaIMC.ResumeLayout(false);
            this.pnlCalculaIMC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIMC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbSelecioneSexo;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCalculaIMC;
        private System.Windows.Forms.PictureBox pctIMC;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.MaskedTextBox mskAltura;
        private System.Windows.Forms.MaskedTextBox mskIdade;
        private System.Windows.Forms.MaskedTextBox mskPeso;
    }
}