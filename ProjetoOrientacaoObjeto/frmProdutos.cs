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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        public void limparCampos()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtQuantidade.Clear();
            //txtTotal.Clear();
            txtValor.Clear();
            dtpDataEntrada.Value = DateTime.Now;
            dtpDataSaida.Value = DateTime.Now;

            txtCodigo.Focus();

            lblMostraCodigo.Text = "";
            lblMostraDescricao.Text = "";
            lblMostraValor.Text = "";
            lblMostraQuantidade.Text = "";
            lblMostraTotal.Text = "";
            lblMostraDataEntrada.Text = "";
            lblMostraDataSaida.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produtos pd = new Produtos();

            try
            {

                //Entradas
                pd.setCodigo(Convert.ToInt32(txtCodigo.Text));
                pd.setDescricao(txtDescricao.Text);
                pd.setValor(Convert.ToDouble(txtValor.Text));
                pd.setQuantidade(Convert.ToInt32(txtQuantidade.Text));
                // pd.setTotal(Convert.ToDouble(txtTotal.Text));
                pd.setDataEntrada(dtpDataEntrada.Value.ToString());
                pd.setDataSaida(dtpDataSaida.Value.ToString());

                //Saídas
                lblMostraCodigo.Text = pd.getCodigo().ToString();
                lblMostraDescricao.Text = pd.getDescricao();
                lblMostraValor.Text = pd.getValor().ToString();
                lblMostraQuantidade.Text = pd.getQuantidade().ToString();
                lblMostraTotal.Text = (pd.getValor() * pd.getQuantidade()).ToString();
                lblMostraDataEntrada.Text = pd.getDataEntrada().ToString();
                lblMostraDataSaida.Text = pd.getDataSaida().ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir valores válidos.",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparCampos();
            }

        }
    }
}
