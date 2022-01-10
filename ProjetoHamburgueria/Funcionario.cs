using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHamburgueria
{
    class Funcionario : Pessoa
    {
        private int idFuncionario;
        private double salario;

        public Funcionario(int idFuncionario, double salario, string nome, string cpf, int idade, char sexo) : base(nome, cpf, idade, sexo)
        {
            this.idFuncionario = idFuncionario;
            this.salario = salario;
        }

        public void ListarPedidos(List<Pedido> pedidos){
        for (int c = 0; c < pedidos.Count; c++)
            {
                 for (int a = 0; a < pedidos[c].pedidoBebida.Count; a++){
                     System.Console.WriteLine((c + 1) + "-" + (pedidos[c].pedidoBebida[a]+1));
                 }
                 for (int b = 0; b < pedidos[c].pedidoComida.Count; b++){
                     System.Console.WriteLine((c + 1) + "-" +( pedidos[c].pedidoComida[b] + 1));
                 }
            }

        }

    }
}
