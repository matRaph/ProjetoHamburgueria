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

        public void ExibirCardapio()
        {
            Console.WriteLine("Comidas:");
            for (int c = 0; c < Comidas.Length ; c++)
            {
                Console.WriteLine((c + 1) + "-" + Comidas[c]);
            }

            Console.WriteLine("Bebidas:");
            for (int c = 0; c < Bebidas.Length; c++)
            {
                Console.WriteLine((c + 1) + "-" + Bebidas[c]);
            }
        }
    }
}
