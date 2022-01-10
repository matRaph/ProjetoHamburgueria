using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHamburgueria
{
    public class Pedido
    {
            private int idPedido;
            private Boolean status;
            private string nomeCliente;
            private List<int> pedidoComida;
            private List<int> pedidoBebida;

    public Pedido(string nomeCliente, int idPedido) {
            this.nomeCliente = nomeCliente;
            this.idPedido = idPedido;
            this.status= true;
        }

        public Pedido()
        {
        }

        public string idpedido{
             get { return idpedido; }
             set { idpedido = value; }

        }
    
    public void removerBebida(int codItem){
        pedidoBebida.RemoveAt(codItem);
    }

    public void adicionarBebida(int codItem){
        pedidoBebida.Add(codItem);
    }
    public void removerComida(int codItem){
        pedidoComida.RemoveAt(codItem);
    }

    public void adicionarComida(int codItem){
        pedidoComida.Add(codItem);
    }

    public void finalizarPedido(){
        pedidoBebida.RemoveRange(0,pedidoBebida.Count);
        pedidoComida.RemoveRange(0,pedidoComida.Count);
        this.status = false;
    }




    }

}