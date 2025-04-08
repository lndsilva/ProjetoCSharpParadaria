using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrientacaoObjeto
{
    public class Pessoa
    {
        //criando os atributos da classe
        private string nome;
        private string email;
        private string cpf;
        private string telefone;
        private int idade;

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return this.email;
        }
        public void setCPF(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCPF()
        {
            return this.cpf;
        }
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public string getTelefone()
        {
            return this.telefone;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public int getIdade()
        {
            return this.idade;
        }
    }
}
