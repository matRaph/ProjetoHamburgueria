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

        public void RealizarPedido(){


        }

        public void EfetuarPagamento(){
            System.Console.WriteLine(" selecione forma de pagamento:\n 1 - cartão de credito\n 2 - cartão de debito\n 3 - dinheiro");
            String op = Console.ReadLine();
            if (op.Equals(1)){
                
            }

        }



    }

}