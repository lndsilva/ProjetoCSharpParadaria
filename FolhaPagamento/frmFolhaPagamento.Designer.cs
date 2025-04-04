namespace FolhaPagamento
{
    partial class frmFolhaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaPagamento));
            this.lblDataFolha = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblImpostoRenda = new System.Windows.Forms.Label();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.lblClubeLazer = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.dtpDataFolha = new System.Windows.Forms.DateTimePicker();
            this.txtImpostoRenda = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtSalarioFolha = new System.Windows.Forms.TextBox();
            this.chkPlanoSaude = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cbbClubeLazer = new System.Windows.Forms.ComboBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDataFolha
            // 
            this.lblDataFolha.AutoSize = true;
            this.lblDataFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFolha.Location = new System.Drawing.Point(31, 22);
            this.lblDataFolha.Name = "lblDataFolha";
            this.lblDataFolha.Size = new System.Drawing.Size(105, 20);
            this.lblDataFolha.TabIndex = 0;
            this.lblDataFolha.Text = "Data da folha";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(261, 176);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(107, 20);
            this.lblSalarioLiquido.TabIndex = 1;
            this.lblSalarioLiquido.Text = "Salário liquido";
            // 
            // lblImpostoRenda
            // 
            this.lblImpostoRenda.AllowDrop = true;
            this.lblImpostoRenda.AutoSize = true;
            this.lblImpostoRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpostoRenda.Location = new System.Drawing.Point(261, 100);
            this.lblImpostoRenda.Name = "lblImpostoRenda";
            this.lblImpostoRenda.Size = new System.Drawing.Size(134, 20);
            this.lblImpostoRenda.TabIndex = 2;
            this.lblImpostoRenda.Text = "Imposto de renda";
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFolha.Location = new System.Drawing.Point(261, 24);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(97, 20);
            this.lblSalarioFolha.TabIndex = 3;
            this.lblSalarioFolha.Text = "Salário folha";
            // 
            // lblClubeLazer
            // 
            this.lblClubeLazer.AutoSize = true;
            this.lblClubeLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubeLazer.Location = new System.Drawing.Point(31, 219);
            this.lblClubeLazer.Name = "lblClubeLazer";
            this.lblClubeLazer.Size = new System.Drawing.Size(110, 20);
            this.lblClubeLazer.TabIndex = 4;
            this.lblClubeLazer.Text = "Clube de lazer";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(31, 98);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(58, 20);
            this.lblSalario.TabIndex = 5;
            this.lblSalario.Text = "Salário";
            // 
            // dtpDataFolha
            // 
            this.dtpDataFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFolha.Location = new System.Drawing.Point(31, 45);
            this.dtpDataFolha.Name = "dtpDataFolha";
            this.dtpDataFolha.Size = new System.Drawing.Size(105, 26);
            this.dtpDataFolha.TabIndex = 0;
            this.dtpDataFolha.TabStop = false;
            // 
            // txtImpostoRenda
            // 
            this.txtImpostoRenda.Enabled = false;
            this.txtImpostoRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpostoRenda.Location = new System.Drawing.Point(261, 124);
            this.txtImpostoRenda.MaxLength = 10;
            this.txtImpostoRenda.Name = "txtImpostoRenda";
            this.txtImpostoRenda.Size = new System.Drawing.Size(134, 26);
            this.txtImpostoRenda.TabIndex = 5;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioLiquido.Location = new System.Drawing.Point(261, 201);
            this.txtSalarioLiquido.MaxLength = 10;
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(134, 26);
            this.txtSalarioLiquido.TabIndex = 6;
            // 
            // txtSalarioFolha
            // 
            this.txtSalarioFolha.Enabled = false;
            this.txtSalarioFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioFolha.Location = new System.Drawing.Point(261, 47);
            this.txtSalarioFolha.MaxLength = 10;
            this.txtSalarioFolha.Name = "txtSalarioFolha";
            this.txtSalarioFolha.Size = new System.Drawing.Size(134, 26);
            this.txtSalarioFolha.TabIndex = 4;
            // 
            // chkPlanoSaude
            // 
            this.chkPlanoSaude.AutoSize = true;
            this.chkPlanoSaude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPlanoSaude.Location = new System.Drawing.Point(31, 174);
            this.chkPlanoSaude.Name = "chkPlanoSaude";
            this.chkPlanoSaude.Size = new System.Drawing.Size(138, 24);
            this.chkPlanoSaude.TabIndex = 2;
            this.chkPlanoSaude.Text = "Plano de saúde";
            this.chkPlanoSaude.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(416, 24);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(125, 67);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(416, 113);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 67);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(416, 205);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(125, 67);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cbbClubeLazer
            // 
            this.cbbClubeLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbClubeLazer.FormattingEnabled = true;
            this.cbbClubeLazer.Items.AddRange(new object[] {
            "Clube A",
            "Clube B",
            "Clube C"});
            this.cbbClubeLazer.Location = new System.Drawing.Point(31, 242);
            this.cbbClubeLazer.Name = "cbbClubeLazer";
            this.cbbClubeLazer.Size = new System.Drawing.Size(147, 28);
            this.cbbClubeLazer.TabIndex = 3;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(31, 122);
            this.txtSalario.MaxLength = 10;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(134, 26);
            this.txtSalario.TabIndex = 1;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // frmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 352);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.cbbClubeLazer);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.chkPlanoSaude);
            this.Controls.Add(this.txtSalarioFolha);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtImpostoRenda);
            this.Controls.Add(this.dtpDataFolha);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblClubeLazer);
            this.Controls.Add(this.lblSalarioFolha);
            this.Controls.Add(this.lblImpostoRenda);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblDataFolha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFolhaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folha de Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataFolha;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblImpostoRenda;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.Label lblClubeLazer;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.DateTimePicker dtpDataFolha;
        private System.Windows.Forms.TextBox txtImpostoRenda;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalarioFolha;
        private System.Windows.Forms.CheckBox chkPlanoSaude;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cbbClubeLazer;
        private System.Windows.Forms.TextBox txtSalario;
    }
}