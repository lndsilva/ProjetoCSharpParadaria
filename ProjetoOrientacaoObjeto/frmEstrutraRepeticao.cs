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
        //método construtor da classe
        public frmEstrutraRepeticao()
        {
            InitializeComponent();
            //executar o método carrega comboEstados
            carregaCombo();
            //carregaListaEstado();
            txtInserirEstado.Focus();

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
        //criando método carregaLista
        public void carregaListaEstado()
        {
            ltbListaEstados.Items.Clear();
            ltbListaEstados.Items.Add("Pinheiros");
            ltbListaEstados.Items.Add("Ibirapuera");
            ltbListaEstados.Items.Add("Moema");
            ltbListaEstados.Items.Add("Borba Gato");
            ltbListaEstados.Items.Add("Granja Julieta");
            ltbListaEstados.Items.Add("Morumbi");
            ltbListaEstados.Items.Add("Alto da Boa Vista");
            ltbListaEstados.Items.Add("Vila Olimpia");
            ltbListaEstados.Items.Add("Brooklin");
            ltbListaEstados.Items.Add("Cidade Jardim");
        }
        private void btnCarregaListaEstados_Click(object sender, EventArgs e)
        {
            //executando o método carrega lista
            //carregaListaEstado();
        }

        private void btnInserirEstado_Click(object sender, EventArgs e)
        {
            if (txtInserirEstado.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir um estado");
            }
            else
            {
                inserirEstado();
            }
        }
        public void inserirEstado()
        {
            ltbListaEstados.Items.Add(txtInserirEstado.Text);
            txtInserirEstado.Clear();
            txtInserirEstado.Focus();
        }
        private void txtInserirEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtInserirEstado.Text != "")
            {
                inserirEstado();
            }
        }

        private void btnLimparEstado_Click(object sender, EventArgs e)
        {
            ltbListaEstados.Items.Clear();
        }

        private void btnLimpaItemSelecionado_Click(object sender, EventArgs e)
        {

            try
            {
                ltbListaEstados.Items.RemoveAt(ltbListaEstados.SelectedIndex);

            }
            catch (Exception)
            {

                MessageBox.Show("Favor selecionar um item da lista");
            }
            
        }
    }
}
