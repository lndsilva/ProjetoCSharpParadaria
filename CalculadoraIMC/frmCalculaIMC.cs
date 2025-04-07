using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class frmCalculaIMC : Form
    {
        public frmCalculaIMC()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskAltura.Clear();
            mskIdade.Clear();
            mskPeso.Clear();

            mskIdade.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double imc = 0, peso, altura;

            try
            {

                peso = Convert.ToDouble(mskPeso.Text);
                altura = Convert.ToDouble(mskAltura.Text);

                imc = peso / (altura * altura);

                

                txtResultado.Text = imc.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir valores válidos.",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                
                mskAltura.Clear();
                mskIdade.Clear();
                mskPeso.Clear();
                mskIdade.Focus();
            }
        }

        private void frmCalculaIMC_Load(object sender, EventArgs e)
        {
            rdbFeminino.Checked = false;
            rdbMasculino.Checked = false;
        }
    }
}
