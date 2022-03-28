using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace ProjetoHamburgueria
{
    class Cardapio{

      public List<Comida> comidas = new List<Comida>();
      public List<Bebida> bebidas =  new List<Bebida>();

      public void addBebida(Bebida bebida){
        bebidas.Add(bebida);
            }
      public void addComida(Comida comida){
        comidas.Add(comida);
      }
      public List <Comida> getComidas(){
        return comidas;
      }
      public List <Bebida> getBebidas(){
        return bebidas;
      }
      public void removecomida(int id){
        comidas.RemoveAt(id-1);
      }
      public void removebebida(int id){
        bebidas.RemoveAt(id-1);
      }
      public void editarcomida(int id, string nome){
        for (int c = 0; c < comidas.Count ; c++)
          {
            if (comidas[c].id == id)comidas[c].nome = nome; 

          }
      }
      public void editarbebida(int id, string nome){
        for (int c = 0; c < comidas.Count ; c++)
          {
            if (bebidas[c].id == id)bebidas[c].nome = nome; 
      
          } 
      }
      public void ListarCardapio(){
        System.Console.WriteLine("Comidas:");
        for (int c = 0; c < comidas.Count ; c++)
        {
            System.Console.WriteLine(comidas[c].id + " - " + comidas[c].nome);
        }
        System.Console.WriteLine("Bebidas:");
        for (int c = 0; c < bebidas.Count; c++)
        {
            System.Console.WriteLine(bebidas[c].id + " - " + bebidas[c].nome);
        }
      }
        public void Comidas_toJson()
        {
            string s = JsonSerializer.Serialize<List<Comida>>(comidas);
            File.WriteAllText("Comidas.json", s);
        }        
        public void Bebidas_toJson()
        {
            string s = JsonSerializer.Serialize<List<Bebida>>(bebidas);
            File.WriteAllText("Bebidas.json", s);
        }
  
    }
}
