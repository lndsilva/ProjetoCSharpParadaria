using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrientacaoObjeto
{
    public class Produtos
    {
        private int codigo;
        private string descricao;
        private double valor;
        private int quantidade;
        private double total;
        private string dataEntrada;
        private string dataSaida;

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public int getCodigo()
        {
            return this.codigo;
        }
        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public string getDescricao()
        {
            return this.descricao;
        }
        public void setValor(double valor)
        {
            this.valor = valor;
        }
        public double getValor()
        {
            return this.valor;
        }
        public void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }
        public int getQuantidade()
        {
            return this.quantidade;
        }
        public void setTotal(double total)
        {
            this.total = total;
        }
        public double getTotal()
        {
            return this.total;
        }
        public void setDataEntrada(string dataEntrada)
        {
            this.dataEntrada = dataEntrada;
        }
        public string getDataEntrada()
        {
            return this.dataEntrada;
        }
        public void setDataSaida(string dataSaida)
        {
            this.dataSaida = dataSaida;
        }
        public string getDataSaida()
        {
            return this.dataSaida;
        }


    }
}
