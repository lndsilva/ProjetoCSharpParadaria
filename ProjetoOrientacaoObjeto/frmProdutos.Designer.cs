namespace ProjetoOrientacaoObjeto
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.gpbProdutos = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gpbInformacoesProduto = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblMostraDataSaida = new System.Windows.Forms.Label();
            this.lblMostraDataEntrada = new System.Windows.Forms.Label();
            this.lblMostraTotal = new System.Windows.Forms.Label();
            this.lblMostraQuantidade = new System.Windows.Forms.Label();
            this.lblMostraValor = new System.Windows.Forms.Label();
            this.lblMostraDescricao = new System.Windows.Forms.Label();
            this.lblMostraCodigo = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gpbProdutos.SuspendLayout();
            this.gpbInformacoesProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbProdutos
            // 
            this.gpbProdutos.Controls.Add(this.dtpDataSaida);
            this.gpbProdutos.Controls.Add(this.lblDataSaida);
            this.gpbProdutos.Controls.Add(this.dtpDataEntrada);
            this.gpbProdutos.Controls.Add(this.lblDataEntrada);
            this.gpbProdutos.Controls.Add(this.txtQuantidade);
            this.gpbProdutos.Controls.Add(this.lblQuantidade);
            this.gpbProdutos.Controls.Add(this.txtValor);
            this.gpbProdutos.Controls.Add(this.lblValor);
            this.gpbProdutos.Controls.Add(this.txtDescricao);
            this.gpbProdutos.Controls.Add(this.lblDescricao);
            this.gpbProdutos.Controls.Add(this.txtCodigo);
            this.gpbProdutos.Controls.Add(this.lblCodigo);
            this.gpbProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProdutos.Location = new System.Drawing.Point(13, 13);
            this.gpbProdutos.Name = "gpbProdutos";
            this.gpbProdutos.Size = new System.Drawing.Size(645, 184);
            this.gpbProdutos.TabIndex = 0;
            this.gpbProdutos.TabStop = false;
            this.gpbProdutos.Text = "Informações do produto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(96, 38);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(68, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(31, 41);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // gpbInformacoesProduto
            // 
            this.gpbInformacoesProduto.Controls.Add(this.label7);
            this.gpbInformacoesProduto.Controls.Add(this.lblMostraDataSaida);
            this.gpbInformacoesProduto.Controls.Add(this.label6);
            this.gpbInformacoesProduto.Controls.Add(this.lblMostraCodigo);
            this.gpbInformacoesProduto.Controls.Add(this.lblMostraDataEntrada);
            this.gpbInformacoesProduto.Controls.Add(this.label5);
            this.gpbInformacoesProduto.Controls.Add(this.lblMostraDescricao);
            this.gpbInformacoesProduto.Controls.Add(this.lblMostraTotal);
            this.gpbInformacoesProduto.Controls.Add(this.label4);
            this.gpbInformacoesProduto.Controls.Add(this.lblMostraValor);
            this.gpbInformacoesProduto.Controls.Add(this.lblMostraQuantidade);
            this.gpbInformacoesProduto.Controls.Add(this.label3);
            this.gpbInformacoesProduto.Controls.Add(this.label2);
            this.gpbInformacoesProduto.Controls.Add(this.label1);
            this.gpbInformacoesProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacoesProduto.Location = new System.Drawing.Point(13, 204);
            this.gpbInformacoesProduto.Name = "gpbInformacoesProduto";
            this.gpbInformacoesProduto.Size = new System.Drawing.Size(645, 177);
            this.gpbInformacoesProduto.TabIndex = 8;
            this.gpbInformacoesProduto.TabStop = false;
            this.gpbInformacoesProduto.Text = "Valores registrados";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(283, 38);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(342, 26);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(197, 41);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(83, 87);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(110, 26);
            this.txtValor.TabIndex = 3;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(31, 90);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 20);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(327, 87);
            this.txtQuantidade.MaxLength = 10;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(107, 26);
            this.txtQuantidade.TabIndex = 4;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(229, 90);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(92, 20);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(31, 141);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(127, 20);
            this.lblDataEntrada.TabIndex = 9;
            this.lblDataEntrada.Text = "Data de Entrada";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(162, 138);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(107, 26);
            this.dtpDataEntrada.TabIndex = 6;
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaida.Location = new System.Drawing.Point(402, 138);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(107, 26);
            this.dtpDataSaida.TabIndex = 7;
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Location = new System.Drawing.Point(282, 141);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(111, 20);
            this.lblDataSaida.TabIndex = 11;
            this.lblDataSaida.Text = "Data da Saída";
            // 
            // lblMostraDataSaida
            // 
            this.lblMostraDataSaida.AutoSize = true;
            this.lblMostraDataSaida.Location = new System.Drawing.Point(475, 139);
            this.lblMostraDataSaida.Name = "lblMostraDataSaida";
            this.lblMostraDataSaida.Size = new System.Drawing.Size(0, 20);
            this.lblMostraDataSaida.TabIndex = 18;
            // 
            // lblMostraDataEntrada
            // 
            this.lblMostraDataEntrada.AutoSize = true;
            this.lblMostraDataEntrada.Location = new System.Drawing.Point(179, 139);
            this.lblMostraDataEntrada.Name = "lblMostraDataEntrada";
            this.lblMostraDataEntrada.Size = new System.Drawing.Size(0, 20);
            this.lblMostraDataEntrada.TabIndex = 17;
            // 
            // lblMostraTotal
            // 
            this.lblMostraTotal.AutoSize = true;
            this.lblMostraTotal.Location = new System.Drawing.Point(514, 88);
            this.lblMostraTotal.Name = "lblMostraTotal";
            this.lblMostraTotal.Size = new System.Drawing.Size(0, 20);
            this.lblMostraTotal.TabIndex = 16;
            // 
            // lblMostraQuantidade
            // 
            this.lblMostraQuantidade.AutoSize = true;
            this.lblMostraQuantidade.Location = new System.Drawing.Point(295, 88);
            this.lblMostraQuantidade.Name = "lblMostraQuantidade";
            this.lblMostraQuantidade.Size = new System.Drawing.Size(0, 20);
            this.lblMostraQuantidade.TabIndex = 15;
            // 
            // lblMostraValor
            // 
            this.lblMostraValor.AutoSize = true;
            this.lblMostraValor.Location = new System.Drawing.Point(92, 88);
            this.lblMostraValor.Name = "lblMostraValor";
            this.lblMostraValor.Size = new System.Drawing.Size(0, 20);
            this.lblMostraValor.TabIndex = 14;
            // 
            // lblMostraDescricao
            // 
            this.lblMostraDescricao.AutoSize = true;
            this.lblMostraDescricao.Location = new System.Drawing.Point(281, 39);
            this.lblMostraDescricao.Name = "lblMostraDescricao";
            this.lblMostraDescricao.Size = new System.Drawing.Size(0, 20);
            this.lblMostraDescricao.TabIndex = 13;
            // 
            // lblMostraCodigo
            // 
            this.lblMostraCodigo.AutoSize = true;
            this.lblMostraCodigo.Location = new System.Drawing.Point(92, 39);
            this.lblMostraCodigo.Name = "lblMostraCodigo";
            this.lblMostraCodigo.Size = new System.Drawing.Size(0, 20);
            this.lblMostraCodigo.TabIndex = 12;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(13, 387);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(193, 51);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(242, 387);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(193, 51);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(465, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 51);
            this.button2.TabIndex = 11;
            this.button2.Text = "&Sair";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data de Entrada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data da Saída";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(459, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Total";
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gpbInformacoesProduto);
            this.Controls.Add(this.gpbProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.gpbProdutos.ResumeLayout(false);
            this.gpbProdutos.PerformLayout();
            this.gpbInformacoesProduto.ResumeLayout(false);
            this.gpbInformacoesProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbProdutos;
        private System.Windows.Forms.GroupBox gpbInformacoesProduto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblMostraDataSaida;
        private System.Windows.Forms.Label lblMostraCodigo;
        private System.Windows.Forms.Label lblMostraDataEntrada;
        private System.Windows.Forms.Label lblMostraDescricao;
        private System.Windows.Forms.Label lblMostraTotal;
        private System.Windows.Forms.Label lblMostraValor;
        private System.Windows.Forms.Label lblMostraQuantidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}