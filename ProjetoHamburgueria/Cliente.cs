using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHamburgueria
{
    class Cliente : Pessoa
    {
        public Pedido pedido = new Pedido();
        public Cliente(string nome, string cpf, int idade, char sexo) : base(nome, cpf, idade, sexo)
        {

        }

        public string nome
        {
            get { return nome; }
            set { nome = value; }

        }

        public string cpf
        {
            get { return cpf; }
            set { cpf = value; }

        }
        public string idade
        {
            get { return idade; }
            set { idade = value; }

        }

        public string sexo
        {
            get { return sexo; }
            set { nome = sexo; }

        }


        // essa relação AQUI!
        public void RealizarPedidoComida(int codigo_pedido)
        {
            pedido.adicionarComida(codigo_pedido);
        }
        public void RealizarPedidoBebida(int codigo_pedido)
        {
            pedido.adicionarBebida(codigo_pedido);
        }
        // é assim que garanto que o cliente não vai ter acesso a
        // edição do cardapio 
        public void VerCardapio(Cardapio cardapio)
        {
            cardapio.exibirCardapio();
        }

        public void terminarPedido(Atendente atendente){
            atendente.receberPedido(pedido);

        }
        // AVALIAR SE VAMOS QUERER LIDAR COM DINHEIRO AGORA (PODEMOS SER CARIDOSOS E DAR COMIDA DE GRAÇA)
        public float EfetuarPagamento(int forma_pagamento, float valor)
        {
            // " selecione forma de pagamento:\n 1 - cartão de credito\n 2 - cartão de debito\n 3 - dinheiro"
            if (forma_pagamento.Equals(1))
            {
                return (float)(valor + (100 * 0.10));
            }
            else if (forma_pagamento.Equals(2))
            {
                return (float)(valor + (100 * 0.5));

            }
            else if (forma_pagamento.Equals(3))
            {
                return valor;

            }
            return 0;

        }


    }

}