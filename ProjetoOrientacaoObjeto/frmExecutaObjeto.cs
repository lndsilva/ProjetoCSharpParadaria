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
    public partial class frmExecutaObjeto : Form
    {
        public frmExecutaObjeto()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double num1 = 40.50, num2 = 20.50, resp =0;

            Calculadora calc = new Calculadora();

            resp = calc.somar(num1,num2);

            lblResposta.Text = resp.ToString();

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double num1 = 40.50, num2 = 20.50, resp = 0;

            Calculadora calc = new Calculadora();

            resp = calc.subtrair(num1, num2);

            lblResposta.Text = resp.ToString();

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1 = 40.50, num2 = 20.50, resp = 0;

            Calculadora calc = new Calculadora();

            resp = calc.multiplicar(num1, num2);

            lblResposta.Text = resp.ToString();

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1 = 40.50, num2 = 20.50, resp = 0;

            Calculadora calc = new Calculadora();

            resp = calc.dividir(num1, num2);

            lblResposta.Text = resp.ToString();

        }
    }
}
