using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHamburgueria
{
    class Pessoa
    {
        private string nome;
        private int cpf;
        private int idade;
        
        public Pessoa(string nome, int cpf, int idade)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
        }

        class Funcionario
        {
            private int idFuncionario;
            private float salario;
        }
    }
}
