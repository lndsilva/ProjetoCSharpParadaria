using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrientacaoObjeto
{
    public partial class frmExecutaPessoa : Form
    {
        public frmExecutaPessoa()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa ps = new Pessoa();
            try
            {
                ps.setNome(txtNome.Text);

                lblMostraNome.Text = ps.getNome();

                ps.setEmail(txtEmail.Text);

                lblMostraEmail.Text = ps.getEmail();

                ps.setTelefone(mskTelefone.Text);

                lblMostraTelefone.Text = ps.getTelefone();

                ps.setCPF(mskCPF.Text);

                lblMostraCPF.Text = ps.getCPF();

                ps.setIdade(Convert.ToInt32(txtIdade.Text));

                lblMostraIdade.Text = ps.getIdade().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir valores válidos.",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtEmail.Clear();

            mskCPF.Clear();
            mskTelefone.Clear();

            lblMostraNome.Text = "Nome";
            lblMostraEmail.Text = "E-mail";
            lblMostraIdade.Text = "Idade";
            lblMostraTelefone.Text = "Telefone";

            txtNome.Focus();    
        }

        private void txtIdade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
    }
}
