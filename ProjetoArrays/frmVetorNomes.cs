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
    public partial class frmVetorNomes : Form
    {
        public frmVetorNomes()
        {
            InitializeComponent();
        }

        private void brnCarregaNomes_Click(object sender, EventArgs e)
        {
            string [] nomes = new string[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                nomes[i] = txtNomes.Text;
            }

            for (int i = 0; i < nomes.Length; i++)
            {
                MessageBox.Show(nomes[i]);
            }
        }
    }
}
