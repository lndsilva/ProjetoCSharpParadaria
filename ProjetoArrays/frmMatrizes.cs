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
    public partial class frmMatrizes : Form
    {
        public frmMatrizes()
        {
            InitializeComponent();
        }        

        Random rnd = new Random();


        private void btnCarregaMatriz_Click(object sender, EventArgs e)
        {
            int linha = int.Parse(txtLinha.Text); 
            int coluna = int.Parse(txtColuna.Text);

            int[,] numeros = new int[linha,coluna];
           

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    numeros[linha, coluna] = rnd.Next();
                    ltbListaMatriz.Items.Add(numeros[i, j]);
                }

            }
            ltbListaMatriz.Items.Add("------");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ltbListaMatriz.Items.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
