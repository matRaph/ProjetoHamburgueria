using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHamburgueria
{
    class Funcionario : Pessoa , IComparable
    {
        public int idFuncionario;
        private double salario;

        public Funcionario(int idFuncionario, double salario, string nome, string cpf, int idade, char sexo) : base(nome, cpf, idade, sexo)
        {
            this.idFuncionario = idFuncionario;
            this.salario = salario;
        }

        public void ListarPedidos(List<Pedido> pedidos, List<string> comidas, List<string> bebidas)
        {

            for (int c = 0; c < pedidos.Count; c++)
            {
                Console.WriteLine("Pedido " + (c + 1));
                Console.WriteLine("Comidas:\n");
                for (int a = 0; a < pedidos[c].pedidoComida.Count; a++)
                {
                    System.Console.WriteLine((a + 1) + "-" + (comidas[pedidos[c].pedidoComida[a]]));
                }
                Console.WriteLine("Bebidas:\n");
                for (int b = 0; b < pedidos[c].pedidoBebida.Count; b++)
                {
                    System.Console.WriteLine((b + 1) + "-" + (bebidas[pedidos[c].pedidoBebida[b]]));
                }
            }
        }
        public int CompareTo(object obj)
        {
            Funcionario a = this;
            Funcionario b = (Funcionario) obj;
            if (a.nome == b.nome) return 0;
            if(a.nome.CompareTo(b.nome) == -1) return -1;
            if(a.nome.CompareTo(b.nome) == 1) return 1;
            return 0 ;
        }


        public override string ToString()
        {
            return "ID: "+ idFuncionario + ", Nome: "+ nome;
        }

    }
}
