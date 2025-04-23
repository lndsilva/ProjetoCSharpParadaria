using System;
using System.Collections;
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
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        private void btnCarregaLista_Click(object sender, EventArgs e)
        {
            List<int> l = new List<int>();            

            l.Add(10);
            l.Add(20);
            l.Add(30);
            l.Add(40);
            l.Add(50);

            foreach (int i in l)
            {
                lstList.Items.Add(i);
            }
        }
    }
}
