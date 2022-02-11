using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHamburgueria
{
    interface IPessoa
    {
        void Nome (string nome);
        void Cpf (string cpf);
        void Idade (int idade);
        void Sexo (char sexo);
    }
    public class Pessoa : IPessoa
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public int idade { get; set; }
        public char sexo { get; set; }

        //Constructor
        public Pessoa(string nome, string cpf, int idade, char sexo)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
            this.sexo = sexo;
        }

        void IPessoa.Nome(string nome)
        {
            this.nome = nome;
        }
        void IPessoa.Cpf(string cpf)
        {
            this.cpf = cpf;
        }
        void IPessoa.Idade(int idade)
        {
            this.idade = idade;
        }
        void IPessoa.Sexo(char sexo)
        {
            this.sexo = sexo;
        }

    }

}
