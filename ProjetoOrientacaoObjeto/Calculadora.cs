using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrientacaoObjeto
{
    public class Calculadora
    {

        //método somar valores
        public double somar(double num1, double num2)
        {
            return (num1 + num2);
        }
        public double subtrair(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double multiplicar(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double dividir(double num1, double num2)
        {
            return (num1 / num2);
        }
    }
}
