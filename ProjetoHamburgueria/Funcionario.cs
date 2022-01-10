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
        private float salario;

        public Funcionario(int idFuncionario, float salario, string nome, int cpf, int idade, char sexo) : base(nome, cpf, idade, sexo)
        {
            this.idFuncionario = idFuncionario;
            this.salario = salario;
        }

        public void ListarPedidos(List<Pedido> pedidos){
        for (int c = 0; c < pedidos.Count; c++)
            {
                System.Console.WriteLine((c + 1) + "-" + pedidos[c]);
            }

        }




    }
}
