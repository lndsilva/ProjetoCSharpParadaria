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

        private void btnCarregaMatriz_Click(object sender, EventArgs e)
        {      

            int[,] numeros = new int[3,4];

            numeros[0, 0] = 1;
            numeros[0, 1] = 2;
            numeros[0, 2] = 3;
            numeros[0, 3] = 4;
            numeros[1, 0] = 5;
            numeros[1, 1] = 6;
            numeros[1, 2] = 7;
            numeros[1, 3] = 8;
            numeros[2, 0] = 9;
            numeros[2, 1] = 10;
            numeros[2, 2] = 11;
            numeros[2, 3] = 12;


            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    
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
