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
            //declarando variáveis
            //tipo da variável e o nome da variável
            int valor1, valor4, resp;
            double valor2, valor5;
            float valor3;
            bool flag;
            string nome;
            char sexo;

            //inicializar as variáveis
            valor1 = 10;
            valor4 = 10;

            resp = valor1 + valor4;
        }
    }
}
