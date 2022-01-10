using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHamburgueria
{
    class Cliente : Pessoa
    {
        public Cliente(string nome, int cpf, int idade, char sexo) : base(nome, cpf, idade, sexo)
        {

        }

        public void ExibirCardapio(string[] cardapio)
        {
            for (int c = 0; c < cardapio.Length; c++)
            {
                Console.WriteLine( (c+1) + "-" + cardapio[c]);
            }
        }

        public void RealizarPedido(){


        }

        public void EfetuarPagamento(){
            

        }



    }

}