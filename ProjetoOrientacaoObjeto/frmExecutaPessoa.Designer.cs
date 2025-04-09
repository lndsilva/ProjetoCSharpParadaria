namespace ProjetoOrientacaoObjeto
{
    partial class frmExecutaPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExecutaPessoa));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbMostraRegistro = new System.Windows.Forms.GroupBox();
            this.lblMostraIdade = new System.Windows.Forms.Label();
            this.lblMostraTelefone = new System.Windows.Forms.Label();
            this.lblMostraCPF = new System.Windows.Forms.Label();
            this.lblMostraEmail = new System.Windows.Forms.Label();
            this.lblMostraNome = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbDadosPessoais.SuspendLayout();
            this.gpbMostraRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(12, 392);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(176, 46);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.Controls.Add(this.txtIdade);
            this.gpbDadosPessoais.Controls.Add(this.lblIdade);
            this.gpbDadosPessoais.Controls.Add(this.mskTelefone);
            this.gpbDadosPessoais.Controls.Add(this.lblTelefone);
            this.gpbDadosPessoais.Controls.Add(this.mskCPF);
            this.gpbDadosPessoais.Controls.Add(this.lblCPF);
            this.gpbDadosPessoais.Controls.Add(this.txtEmail);
            this.gpbDadosPessoais.Controls.Add(this.lblEmail);
            this.gpbDadosPessoais.Controls.Add(this.txtNome);
            this.gpbDadosPessoais.Controls.Add(this.lblNome);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(12, 12);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(612, 188);
            this.gpbDadosPessoais.TabIndex = 0;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados pessoais";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(90, 132);
            this.txtIdade.MaxLength = 3;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(78, 26);
            this.txtIdade.TabIndex = 5;
            this.txtIdade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdade_KeyDown);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(33, 135);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(50, 20);
            this.lblIdade.TabIndex = 8;
            this.lblIdade.Text = "Idade";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(332, 85);
            this.mskTelefone.Mask = "99999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(125, 26);
            this.mskTelefone.TabIndex = 4;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(255, 88);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(90, 85);
            this.mskCPF.Mask = "999,999,999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(125, 26);
            this.mskCPF.TabIndex = 3;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(43, 88);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 20);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(377, 36);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(209, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(319, 39);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(90, 36);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(209, 26);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(32, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // gpbMostraRegistro
            // 
            this.gpbMostraRegistro.Controls.Add(this.lblMostraIdade);
            this.gpbMostraRegistro.Controls.Add(this.lblMostraTelefone);
            this.gpbMostraRegistro.Controls.Add(this.lblMostraCPF);
            this.gpbMostraRegistro.Controls.Add(this.lblMostraEmail);
            this.gpbMostraRegistro.Controls.Add(this.lblMostraNome);
            this.gpbMostraRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMostraRegistro.Location = new System.Drawing.Point(12, 206);
            this.gpbMostraRegistro.Name = "gpbMostraRegistro";
            this.gpbMostraRegistro.Size = new System.Drawing.Size(612, 180);
            this.gpbMostraRegistro.TabIndex = 6;
            this.gpbMostraRegistro.TabStop = false;
            this.gpbMostraRegistro.Text = "Mostrar registros";
            // 
            // lblMostraIdade
            // 
            this.lblMostraIdade.AutoSize = true;
            this.lblMostraIdade.Location = new System.Drawing.Point(32, 142);
            this.lblMostraIdade.Name = "lblMostraIdade";
            this.lblMostraIdade.Size = new System.Drawing.Size(50, 20);
            this.lblMostraIdade.TabIndex = 4;
            this.lblMostraIdade.Text = "Idade";
            // 
            // lblMostraTelefone
            // 
            this.lblMostraTelefone.AutoSize = true;
            this.lblMostraTelefone.Location = new System.Drawing.Point(328, 89);
            this.lblMostraTelefone.Name = "lblMostraTelefone";
            this.lblMostraTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblMostraTelefone.TabIndex = 3;
            this.lblMostraTelefone.Text = "Telefone";
            // 
            // lblMostraCPF
            // 
            this.lblMostraCPF.AutoSize = true;
            this.lblMostraCPF.Location = new System.Drawing.Point(32, 89);
            this.lblMostraCPF.Name = "lblMostraCPF";
            this.lblMostraCPF.Size = new System.Drawing.Size(40, 20);
            this.lblMostraCPF.TabIndex = 2;
            this.lblMostraCPF.Text = "CPF";
            // 
            // lblMostraEmail
            // 
            this.lblMostraEmail.AutoSize = true;
            this.lblMostraEmail.Location = new System.Drawing.Point(328, 39);
            this.lblMostraEmail.Name = "lblMostraEmail";
            this.lblMostraEmail.Size = new System.Drawing.Size(53, 20);
            this.lblMostraEmail.TabIndex = 1;
            this.lblMostraEmail.Text = "E-mail";
            // 
            // lblMostraNome
            // 
            this.lblMostraNome.AutoSize = true;
            this.lblMostraNome.Location = new System.Drawing.Point(32, 39);
            this.lblMostraNome.Name = "lblMostraNome";
            this.lblMostraNome.Size = new System.Drawing.Size(51, 20);
            this.lblMostraNome.TabIndex = 0;
            this.lblMostraNome.Text = "Nome";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(235, 392);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(176, 46);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(448, 392);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(176, 46);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmExecutaPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 445);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gpbMostraRegistro);
            this.Controls.Add(this.gpbDadosPessoais);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmExecutaPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Executa Pessoa";
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.gpbMostraRegistro.ResumeLayout(false);
            this.gpbMostraRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpbMostraRegistro;
        private System.Windows.Forms.Label lblMostraNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblMostraIdade;
        private System.Windows.Forms.Label lblMostraTelefone;
        private System.Windows.Forms.Label lblMostraCPF;
        private System.Windows.Forms.Label lblMostraEmail;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}