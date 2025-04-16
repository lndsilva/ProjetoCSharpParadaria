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
        }

        Random rnd = new Random();

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //int num = rnd.Next();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ltbMostraNumero.Items.Clear();
            txtInsiraNumero.Clear();
            txtInsiraNumero.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
