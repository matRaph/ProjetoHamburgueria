using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHamburgueria
{
    public class Cardapio
    {
        string[] Comidas = {"Hamb1", "Hamb2", "Hamb3", "Hamb4" };
        string[] Bebidas = { "Bebida1", "Bebida2", "Bebida3", "Bebida4" };

        public void exibirCardapio()
        {
           
            System.Console.WriteLine("Comidas:");
            for (int c = 0; c < Comidas.Length ; c++)
            {
                System.Console.WriteLine((c + 1) + "-" + Comidas[c]);
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("Bebidas:");
            for (int c = 0; c < Bebidas.Length; c++)
            {
                System.Console.WriteLine((c + 1) + "-" + Bebidas[c]);
            }
            
        }
        public void editarCardapio()
        {
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
            {
                int opcaoAcao;
                int opcaoComid;
                System.Console.WriteLine("Digite o número da comida que deseja editar:");
                for (int c = 0; c < Comidas.Length; c++)
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
                    Comidas.ToList().RemoveAt(opcaoComid); //Remover item de indice opcaoComid em array Comidas
                    System.Console.WriteLine("Item removido com sucesso.");
                    editarCardapio();
                }
            }
            if (opcaoCard == 2)
            {
                int opcaoAcao;
                int opcaoBebid;
                System.Console.WriteLine("Digite o número da bebida que deseja editar:");
                for (int c = 0; c < Bebidas.Length; c++)
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
                else if (opcaoAcao == 2)
                {
                    Bebidas.ToList().RemoveAt(opcaoBebid);  //Remover item de indice opcaoBebid em array Bebidas
                    System.Console.WriteLine("Item removido com sucesso");
                    editarCardapio();
                }

            }
            if (opcaoCard == 3)
            {
                string adicioCom;
                System.Console.WriteLine("Digite o novo item?");
                adicioCom = System.Console.ReadLine();
                //Adicionar item string adicioCom em array Comidas
            }

            if (opcaoCard == 4)
            {
                string adicioBeb;
                System.Console.WriteLine("Digite o novo item?");
                adicioBeb = System.Console.ReadLine();
                //Adicionar item string adicioBeb em array Bebidas
            }
        }
    }
}
