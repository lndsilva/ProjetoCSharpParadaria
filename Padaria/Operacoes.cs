using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria
{
    public class Operacoes
    {
        //é o método construtor da classe
        public Operacoes()
        {
        }
        public double somarValor(double v1, double v2)
        {
            return (v1 + v2);
        }
        public double subtracaoValor(double v1, double v2)
        {
            return (v1 - v2);
        }
        public double multiplicacaoValor(double v1, double v2)
        {
            return (v1 * v2);
        }
        public double divisaoValor(double v1, double v2)
        {
            return (v1 / v2);

        }
    }
}
