using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHamburgueria
{
    class Cozinheiro : Funcionario
    {
        public List<Pedido> pedidos;
        public Cozinheiro(int idFuncionario, double salario, string nome, string cpf, int idade, char sexo) : base(idFuncionario, salario, nome, cpf, idade, sexo)
        {

        }

        public void receberPedido(List<Pedido> pedidos){
            this.pedidos = pedidos;

        }
    //metodo que muda com base no seu id infomado o status do pedido e apaga os itens nele
        public void finalizarPedidoX(int idPedido ){
            for(int c = 0; c < pedidos.Count; c++){
                    if(pedidos[c].idpedido == idPedido){
                        pedidos[c].finalizarPedido();
                    }
                    else{
                    System.Console.WriteLine("id do pedido n�o encontrado");

                    }

            }
            

        }
    }

}