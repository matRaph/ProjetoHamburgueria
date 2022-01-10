using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHamburgueria
{
    public class Pessoa
    {
        private string nome;
        private int cpf;
        private int idade;
        private char sexo;

        public Pessoa(string nome, int cpf, int idade, char sexo)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
            this.sexo = sexo;
        }

    }

}
