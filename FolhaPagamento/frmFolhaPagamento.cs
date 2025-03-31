using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class frmFolhaPagamento : Form
    {
        public frmFolhaPagamento()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSalario.Clear();
            txtSalarioFolha.Clear();
            txtImpostoRenda.Clear();
            txtSalarioLiquido.Clear();
            chkPlanoSaude.Checked = false;
            cbbClubeLazer.Text = "";
            txtSalario.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salario, ir = 0;
            try
            {
                salario = Convert.ToDouble(txtSalario.Text);

                if (salario <= 2259.20)
                {
                    salario = salario - 0;
                    ir = 0;
                }
                else if (salario >= 2259.21 && salario <= 2826.65)
                {
                    ir = salario * 7.5 / 100;
                    salario = salario - (ir);
                }
                else if (salario >= 2826.66 && salario <= 3751.05)
                {
                    ir = salario * 15 / 100;
                    salario = salario - (ir);
                }
                else if (salario >= 3751.06 && salario <= 4664.68)
                {
                    ir = salario * 22.5 / 100;
                    salario = salario - (ir);
                }
                else if (salario >= 4664.69)
                {
                    ir = salario * 27.5 / 100;
                    salario = salario - (ir);
                }

                if (chkPlanoSaude.Checked)
                {
                    salario = salario - 400;
                }

                if (cbbClubeLazer.SelectedIndex == 0)
                {
                    salario = salario - 100;
                }
                if (cbbClubeLazer.SelectedIndex == 1)
                {
                    salario = salario - 50;
                }
                if (cbbClubeLazer.SelectedIndex == 2)
                {
                    salario = salario - 30;
                }

                txtImpostoRenda.Text = ir.ToString();
                txtSalarioLiquido.Text = salario.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir valores válidos",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                txtSalario.Clear();
                chkPlanoSaude.Checked = false;
                cbbClubeLazer.Text = "";
                txtSalario.Focus();

            }
        }
        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            txtSalarioFolha.Text = txtSalario.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chkPlanoSaude.Checked = false;

            if (cbbClubeLazer.SelectedIndex == 0)
            {

            }
            if (cbbClubeLazer.SelectedIndex == 1)
            {

            }
            if (cbbClubeLazer.SelectedIndex == 2)
            {

            }
        }
    }
}
