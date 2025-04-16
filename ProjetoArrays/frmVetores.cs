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

        }

        public void carregaVetores()
        {
            int tamanho = int.Parse(txtTamanho.Text);

            //criando um vetor ou array de linha
            string[] nome = new string[tamanho];

            //inserindo valores manualmente no vetor
            for (int i = 0; i < nome.Length; i++)
            {
                nome[i] = txtInsiraNome.Text;
            }

            //nome[0] = "Larissa";
            //nome[1] = "Dharla";
            //nome[2] = "Cauã";
            //nome[3] = "Eduardo";
            //nome[4] = "Letícia";
            //nome[5] = "Edna";
            //nome[6] = "Hugo";
            //nome[7] = "Pedro";
            //nome[8] = "João";
            //nome[9] = "Giovanne";

            ltbNomes.Items.Clear();
            ////percorrendo o vetor ou array de linha
            for (int i = 0; i < nome.Length; i++)
            {
                ltbNomes.Items.Add(nome[i]);
            }
        }

        private void btnInserirNome_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                nomes[i] = txtInsiraNome.Text;
                ltbNomes.Items.Add(nomes[i]);

            }

            MessageBox.Show(nomes[0]);

        }
    }
}