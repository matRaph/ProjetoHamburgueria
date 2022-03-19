using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace ProjetoHamburgueria
{
    class Atendente : Funcionario
    {

        public List<Pedido> pedidos = new();
        
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
        public void atendente_toJson(List<Atendente> lista)
        {
            string s = JsonSerializer.Serialize<List<Atendente>>(lista);
            File.WriteAllText("Atendentes.json", s);
        }

    }

}