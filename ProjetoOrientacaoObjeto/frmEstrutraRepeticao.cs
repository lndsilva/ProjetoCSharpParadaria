using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrientacaoObjeto
{
    public partial class frmEstrutraRepeticao : Form
    {
        public frmEstrutraRepeticao()
        {
            InitializeComponent();
        }

        private void btnCarregaEstado_Click(object sender, EventArgs e)
        {
            //executando o método carrega combo
            carregaCombo();

        }

        //criando o método carrega combo
        public void carregaCombo()
        {
            cbbEstado.Items.Clear();
            cbbEstado.Items.Add("Capão Redondo");
            cbbEstado.Items.Add("São Luiz");
            cbbEstado.Items.Add("Campo Grande");
            cbbEstado.Items.Add("Piraporinha");
            cbbEstado.Items.Add("Jardim Angela");
            cbbEstado.Items.Add("Vila Remo");
            cbbEstado.Items.Add("Capelinha");
            cbbEstado.Items.Add("Campo Limpo");
            cbbEstado.Items.Add("Jardim Jacira");
            cbbEstado.Items.Add("Jardim Nakamura");
        }

       
    }
}
