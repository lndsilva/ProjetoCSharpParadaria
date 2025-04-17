using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoArrays
{
    public partial class frmNumAleatorio : Form
    {
        public frmNumAleatorio()
        {
            InitializeComponent();
            //executando o método desativar campos
            desativarCampos();
        }

        Random rnd = new Random();
        int tamanho;

        private void btnGerar_Click(object sender, EventArgs e)
        {

            if (rdbInteirosAleatorios.Checked)
            {
                int num = rnd.Next();
                ltbMostraNumero.Items.Add(num);
                txtInsiraNumero.Clear();
                txtInsiraNumero.Focus();
            }
            if (rdbVariosInteirosAleatorios.Checked)
            {
                try
                {
                    int valor = int.Parse(txtInsiraNumero.Text);
                    int num = rnd.Next(valor);
                    ltbMostraNumero.Items.Add(num);
                    txtInsiraNumero.Clear();
                    txtInsiraNumero.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("Favor inserir um número interiro");
                    txtInsiraNumero.Clear();
                    txtInsiraNumero.Focus();
                }

            }
            if (rdbInteirosAleatoriosIntervalos.Checked)
            {
                try
                {
                    int valor1 = int.Parse(txtMinimo.Text);
                    int valor2 = int.Parse(txtMaximo.Text);
                    int num = rnd.Next(valor1, valor2);
                    ltbMostraNumero.Items.Add(num);
                    txtInsiraNumero.Clear();
                    txtInsiraNumero.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("Favor inserir um número interiro");
                    txtInsiraNumero.Clear();
                    txtInsiraNumero.Focus();
                }

            }
            if (rdbGerarFloatsAleatorios.Checked)
            {

                double num = rnd.NextDouble();
                ltbMostraNumero.Items.Add(num);
                txtInsiraNumero.Clear();
                txtInsiraNumero.Focus();
            }
            if (rdbAleatoriosRepeticao.Checked)
            {
                try
                {
                    int valor = int.Parse(txtInsiraNumero.Text);
                    tamanho = Convert.ToInt32(txtTamanho.Text);

                    for (int i = 0; i < tamanho; i++)
                    {
                        ltbMostraNumero.Items.Add(rnd.Next(valor));

                    }
                    ltbMostraNumero.Items.Add("-------");
                }
                catch (Exception)
                {
                    MessageBox.Show("Insira a quantidade de repetições");
                    txtTamanho.Focus();
                }

            }
        }

        public void desativarCampos()
        {
            txtInsiraNumero.Enabled = false;
            txtMaximo.Enabled = false;
            txtMinimo.Enabled = false;
            txtTamanho.Enabled = false;
            rdbGerarFloatsAleatorios.Checked = false;
            rdbInteirosAleatorios.Checked = false;
            rdbInteirosAleatoriosIntervalos.Checked = false;
            rdbVariosInteirosAleatorios.Checked = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ltbMostraNumero.Items.Clear();
            txtInsiraNumero.Clear();
            txtMaximo.Clear();
            txtMinimo.Clear();
            txtInsiraNumero.Focus();
            rdbGerarFloatsAleatorios.Checked = false;
            rdbInteirosAleatorios.Checked = false;
            rdbInteirosAleatoriosIntervalos.Checked = false;
            rdbVariosInteirosAleatorios.Checked = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbInteirosAleatorios_CheckedChanged(object sender, EventArgs e)
        {
            //não precisa ativar  
        }

        private void rdbVariosInteirosAleatorios_CheckedChanged(object sender, EventArgs e)
        {
            txtInsiraNumero.Enabled = true;
            txtInsiraNumero.Focus();
        }

        private void rdbInteirosAleatoriosIntervalos_CheckedChanged(object sender, EventArgs e)
        {
            txtMaximo.Enabled = true;
            txtMinimo.Enabled = true;
            txtMinimo.Focus();
        }

        private void rdbGerarFloatsAleatorios_CheckedChanged(object sender, EventArgs e)
        {
            //não precisa ativar  
        }

        private void rdbAleatoriosRepeticao_CheckedChanged(object sender, EventArgs e)
        {
            txtTamanho.Enabled = true;
            txtInsiraNumero.Enabled=true;
            txtTamanho.Focus();
        }
    }
}
