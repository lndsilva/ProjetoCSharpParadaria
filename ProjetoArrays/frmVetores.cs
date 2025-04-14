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
    public partial class frmVetores : Form
    {
        public frmVetores()
        {
            InitializeComponent();
        }

        private void btnCarrega_Click(object sender, EventArgs e)
        {
            //criando um vetor ou array de linha
            string[] nome = new string[10];

            //inserindo valores manualmente no vetor

            nome[0] = "Larissa";
            nome[1] = "Dharla";
            nome[2] = "Cauã";
            nome[3] = "Eduardo";
            nome[4] = "Letícia";
            nome[5] = "Edna";
            nome[6] = "Hugo";
            nome[7] = "Pedro";
            nome[8] = "João";
            nome[9] = "Giovanne";

            ltbNomes.Items.Clear();
            //percorrendo o vetor ou array de linha
            for (int i = 0; i < 10; i++)
            {
                ltbNomes.Items.Add(nome[i]);
            }

        }
    }
}
