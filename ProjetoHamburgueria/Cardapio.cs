using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHamburgueria
{
    public class Cardapio
    {
        List<string> Comidas = new List<string>();
        List<string> Bebidas =  new List<string>();

        public void exibirCardapio()
        {
           
            System.Console.WriteLine("Comidas:");
            for (int c = 0; c < Comidas.Count ; c++)
            {
                System.Console.WriteLine((c + 1) + "-" + Comidas[c]);
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("Bebidas:");
            for (int c = 0; c < Bebidas.Count; c++)
            {
                System.Console.WriteLine((c + 1) + "-" + Bebidas[c]);
            }
            
        }
        public void editarCardapio()
        {
            //algumas dessas verificações das opções deve ser feito no MainClass 
            //isso aqui é mais ou menos a parte do main sobre o cardapio
            //pode tomar como exemplo o efetuar pagamento da classe cliente e a 
            // relação do cliente com o pedido

            int opcaoCard;
           
            void mostrarOpcoes()
            {
                System.Console.WriteLine("Que operação deseja fazer com este item?\n");
                System.Console.WriteLine("1 - Editar item \n2 - Remover item");
            }
            exibirCardapio();
            System.Console.WriteLine("");
            System.Console.WriteLine("De qual cardápio você quer editar?\n1 - Comida \n2 - Bebida \n3 - Adicionar item ao cardápio de comidas\n 4 - Adicionar item ao cardápio de bebidas\n");
            opcaoCard = Convert.ToInt32(System.Console.ReadLine());

            if (opcaoCard == 1)
            {   //essas edições podem ser dois metodos separados
                int opcaoAcao;
                int opcaoComid;
                System.Console.WriteLine("Digite o número da comida que deseja editar:");
                for (int c = 0; c < Comidas.Count; c++)
                {
                    System.Console.WriteLine((c + 1) + "-" + Comidas[c]);
                }
                opcaoComid = Convert.ToInt32(System.Console.ReadLine());
                mostrarOpcoes();
                opcaoAcao = Convert.ToInt32(System.Console.ReadLine());
                if (opcaoAcao == 1)
                {
                    System.Console.WriteLine("Escreva o item:");
                    Comidas[opcaoComid - 1] = System.Console.ReadLine();
                    System.Console.WriteLine("Item alterado com sucesso.");
                    editarCardapio();
                }
                else if(opcaoAcao == 2)
                {
                    Comidas.RemoveAt(opcaoComid); 
                    System.Console.WriteLine("Item removido com sucesso.");
                    editarCardapio();
                }
            }
            
            if (opcaoCard == 2)
            {
                int opcaoAcao;
                int opcaoBebid;
                System.Console.WriteLine("Digite o número da bebida que deseja editar:");
                for (int c = 0; c < Bebidas.Count; c++)
                {
                    System.Console.WriteLine((c + 1) + "-" + Bebidas[c]);
                }
                opcaoBebid = Convert.ToInt32(System.Console.ReadLine());
                mostrarOpcoes();
                opcaoAcao = Convert.ToInt32(System.Console.ReadLine());
                if (opcaoAcao == 1)
                {
                    System.Console.WriteLine("Escreva o item:");
                    Bebidas[opcaoBebid - 1] = System.Console.ReadLine();
                    System.Console.WriteLine("Item alterado com sucesso.");
                    editarCardapio();
                }
                // isso um metodo remove 
                else if (opcaoAcao == 2)
                {
                    Bebidas.RemoveAt(opcaoBebid);  
                    System.Console.WriteLine("Item removido com sucesso");
                    editarCardapio();
                }

            }
            //poderia ser dois metodos add e chama-los la no MainClass
            if (opcaoCard == 3)
            {
                string adicioCom;
                System.Console.WriteLine("Digite o novo item?");
                adicioCom = System.Console.ReadLine();
                Comidas.Add(adicioCom);
                
            }

            if (opcaoCard == 4)
            {
                string adicioBeb;
                System.Console.WriteLine("Digite o novo item?");
                adicioBeb = System.Console.ReadLine();
                Bebidas.Add(adicioBeb);
                
            }
        }
    }
}
