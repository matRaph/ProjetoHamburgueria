using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

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
        public void cozinheiro_toJson(List<Cozinheiro> lista)
        {
            string s = JsonSerializer.Serialize<List<Cozinheiro>>(lista);
            File.WriteAllText("Cozinheiros.json", s);
        }
    }

}