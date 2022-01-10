using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHamburgueria
{
    class Cozinheiro : Funcionario
    {
        //IMPORTANTE - VER UMA MANEIRA DE USAR APENAS UMA LISTA DE PEDIDOS 
        // PARA ATENDENTES E COZINHEIROS
        List<Pedido> pedidos = new List<Pedido>();
        public Cozinheiro(int idFuncionario, float salario, string nome, int cpf, int idade, char sexo) : base(idFuncionario, salario, nome, cpf, idade, sexo)
        {

        }

        public void receberPedido(Pedido pedido){
            this.pedidos.Add(pedido);

        }
    //metodo que muda com base no seu id infomado o status do pedido e apaga os itens nele
        public void finalizarPedidoX(int idPedido, Pedido pedido ){
            pedido.finalizarPedido();

        }
    }

}