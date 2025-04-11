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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstrutraRepeticao));
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.ltbListaEstados = new System.Windows.Forms.ListBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblListaEstados = new System.Windows.Forms.Label();
            this.btnCarregaEstado = new System.Windows.Forms.Button();
            this.btnCarregaListaEstados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInserirEstado = new System.Windows.Forms.TextBox();
            this.btnInserirEstado = new System.Windows.Forms.Button();
            this.btnLimparEstado = new System.Windows.Forms.Button();
            this.btnLimpaItemSelecionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbEstado
            // 
            this.cbbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(38, 50);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(192, 28);
            this.cbbEstado.TabIndex = 0;
            this.cbbEstado.TabStop = false;
            // 
            // ltbListaEstados
            // 
            this.ltbListaEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaEstados.FormattingEnabled = true;
            this.ltbListaEstados.ItemHeight = 20;
            this.ltbListaEstados.Location = new System.Drawing.Point(300, 50);
            this.ltbListaEstados.Name = "ltbListaEstados";
            this.ltbListaEstados.Size = new System.Drawing.Size(212, 204);
            this.ltbListaEstados.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(38, 27);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado";
            // 
            // lblListaEstados
            // 
            this.lblListaEstados.AutoSize = true;
            this.lblListaEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaEstados.Location = new System.Drawing.Point(300, 27);
            this.lblListaEstados.Name = "lblListaEstados";
            this.lblListaEstados.Size = new System.Drawing.Size(106, 20);
            this.lblListaEstados.TabIndex = 3;
            this.lblListaEstados.Text = "Lista Estados";
            // 
            // btnCarregaEstado
            // 
            this.btnCarregaEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaEstado.Location = new System.Drawing.Point(38, 328);
            this.btnCarregaEstado.Name = "btnCarregaEstado";
            this.btnCarregaEstado.Size = new System.Drawing.Size(192, 56);
            this.btnCarregaEstado.TabIndex = 3;
            this.btnCarregaEstado.Text = "Carrega Estado";
            this.btnCarregaEstado.UseVisualStyleBackColor = true;
            this.btnCarregaEstado.Click += new System.EventHandler(this.btnCarregaEstado_Click);
            // 
            // btnCarregaListaEstados
            // 
            this.btnCarregaListaEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaListaEstados.Location = new System.Drawing.Point(300, 328);
            this.btnCarregaListaEstados.Name = "btnCarregaListaEstados";
            this.btnCarregaListaEstados.Size = new System.Drawing.Size(212, 56);
            this.btnCarregaListaEstados.TabIndex = 4;
            this.btnCarregaListaEstados.Text = "Carrega Lista de Estados";
            this.btnCarregaListaEstados.UseVisualStyleBackColor = true;
            this.btnCarregaListaEstados.Click += new System.EventHandler(this.btnCarregaListaEstados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite o estado";
            // 
            // txtInserirEstado
            // 
            this.txtInserirEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInserirEstado.Location = new System.Drawing.Point(38, 166);
            this.txtInserirEstado.MaxLength = 30;
            this.txtInserirEstado.Name = "txtInserirEstado";
            this.txtInserirEstado.Size = new System.Drawing.Size(238, 26);
            this.txtInserirEstado.TabIndex = 1;
            this.txtInserirEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInserirEstado_KeyDown);
            // 
            // btnInserirEstado
            // 
            this.btnInserirEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirEstado.Location = new System.Drawing.Point(38, 198);
            this.btnInserirEstado.Name = "btnInserirEstado";
            this.btnInserirEstado.Size = new System.Drawing.Size(116, 33);
            this.btnInserirEstado.TabIndex = 2;
            this.btnInserirEstado.Text = "Inserir Estado";
            this.btnInserirEstado.UseVisualStyleBackColor = true;
            this.btnInserirEstado.Click += new System.EventHandler(this.btnInserirEstado_Click);
            // 
            // btnLimparEstado
            // 
            this.btnLimparEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparEstado.Location = new System.Drawing.Point(160, 198);
            this.btnLimparEstado.Name = "btnLimparEstado";
            this.btnLimparEstado.Size = new System.Drawing.Size(116, 33);
            this.btnLimparEstado.TabIndex = 7;
            this.btnLimparEstado.Text = "Limpar Estado";
            this.btnLimparEstado.UseVisualStyleBackColor = true;
            this.btnLimparEstado.Click += new System.EventHandler(this.btnLimparEstado_Click);
            // 
            // btnLimpaItemSelecionado
            // 
            this.btnLimpaItemSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaItemSelecionado.Location = new System.Drawing.Point(42, 237);
            this.btnLimpaItemSelecionado.Name = "btnLimpaItemSelecionado";
            this.btnLimpaItemSelecionado.Size = new System.Drawing.Size(234, 33);
            this.btnLimpaItemSelecionado.TabIndex = 8;
            this.btnLimpaItemSelecionado.Text = "Limpa Item Selecionado";
            this.btnLimpaItemSelecionado.UseVisualStyleBackColor = true;
            this.btnLimpaItemSelecionado.Click += new System.EventHandler(this.btnLimpaItemSelecionado_Click);
            // 
            // frmEstrutraRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 405);
            this.Controls.Add(this.btnLimpaItemSelecionado);
            this.Controls.Add(this.btnLimparEstado);
            this.Controls.Add(this.btnInserirEstado);
            this.Controls.Add(this.txtInserirEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCarregaListaEstados);
            this.Controls.Add(this.btnCarregaEstado);
            this.Controls.Add(this.lblListaEstados);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.ltbListaEstados);
            this.Controls.Add(this.cbbEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEstrutraRepeticao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estrutra de Repetição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.ListBox ltbListaEstados;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblListaEstados;
        private System.Windows.Forms.Button btnCarregaEstado;
        private System.Windows.Forms.Button btnCarregaListaEstados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInserirEstado;
        private System.Windows.Forms.Button btnInserirEstado;
        private System.Windows.Forms.Button btnLimparEstado;
        private System.Windows.Forms.Button btnLimpaItemSelecionado;
    }
}