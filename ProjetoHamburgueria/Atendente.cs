using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoHamburgueria
{
    class Atendente : Funcionario
    {

        public List<Pedido> pedidos = new List<Pedido>();
        
        public Atendente(int idFuncionario, double salario, string nome, string cpf, int idade, char sexo) 
        : base(idFuncionario, salario, nome, cpf, idade, sexo)
        {

        }
        public void receberPedido(Pedido pedido){
            this.pedidos.Add(pedido);

        }
        public void enviarPedido( Cozinheiro cozinheiro){
            cozinheiro.receberPedido(pedidos);

        }


    }

}