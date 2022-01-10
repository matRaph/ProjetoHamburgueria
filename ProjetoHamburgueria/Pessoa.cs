using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHamburgueria
{
    public abstract class Pessoa
    {
        private string nome;
        private string cpf;
        private int idade;
        private char sexo;

        public Pessoa(string nome, string cpf, int idade, char sexo)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
            this.sexo = sexo;
        }

    }

}
