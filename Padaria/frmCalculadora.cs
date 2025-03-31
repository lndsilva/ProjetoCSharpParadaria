using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padaria
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ////declarando variáveis
            ////tipo da variável e o nome da variável
            //int valor1, valor4, resp;
            //double valor2, valor5;
            //float valor3;
            //bool flag;
            //string nome;
            //char sexo;

            ////inicializar as variáveis
            //valor1 = 10;
            //valor4 = 10;

            //resp = valor1 + valor4;
            //declarando as variaveis
            double num1, num2, resp = 0;

            try
            {
                //inicializar as variaveis
                num1 = Convert.ToDouble(txtNumero1.Text);
                num2 = Convert.ToDouble(txtNumero2.Text);

                if (rdbSomar.Checked == false &&
                    rdbSubtrair.Checked == false &&
                    rdbMultiplicar.Checked == false &&
                    rdbDivisao.Checked == false)
                {
                    MessageBox.Show("Selecione uma operação",
                        "Mensagem do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                }
                else
                {

                    if (rdbSomar.Checked)
                    {
                        resp = num1 + num2;
                    }
                    if (rdbSubtrair.Checked)
                    {
                        resp = num1 - num2;
                    }
                    if (rdbMultiplicar.Checked)
                    {
                        resp = num1 * num2;
                    }
                    if (rdbDivisao.Checked)
                    {
                        if (num2 == 0)
                        {
                            MessageBox.Show("Impossível dividir por zero",
                                "Mensagem do sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);

                            resp = 0;
                        }
                        else
                        {
                            resp = num1 / num2;
                        }

                    }
                    txtResposta.Text = resp.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Insira valores válidos",
                   "Mensagem do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
                txtNumero1.Clear();
                txtNumero2.Clear();
                txtNumero1.Focus();
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpar os campos
            txtNumero1.Text = "";
            txtNumero2.Clear();
            txtResposta.Clear();

            rdbSomar.Checked = false;
            rdbSubtrair.Checked = false;
            rdbMultiplicar.Checked = false;
            rdbDivisao.Checked = false;

            txtNumero1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //sair do sistema e encerrar todos os processos
            Application.Exit();
        }
    }
}
