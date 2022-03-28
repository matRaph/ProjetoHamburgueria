using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace ProjetoHamburgueria
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Atendente> atendentes = new List<Atendente>();
            List<Cozinheiro> cozinheiros = new List<Cozinheiro>();
            List<Cardapio> cardapios = new List<Cardapio>();


            //A Hamburgueria
            Atendente atendente;
            Cozinheiro cozinheiro;
            Cardapio cardapio = new Cardapio();
            Cliente cliente = new Cliente("Tonhão", "123.456.789-12", 24, 'M');
            int idpedidos = 1;
            int op = 0, op2 = 0;
            int id;
            string nome;
            Bebida bebida;
            Comida comida;
            while (op != 4)
            {
                System.Console.WriteLine("1 - cliente\n2 - atendente\n3 - cozinheiro\n4 - finalizar");
                op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    int continua = 1;
                    while (continua != 2)
                    {
                        System.Console.WriteLine("1 - Ver cardápio\n2 - realizar pedido comida\n3 - realizar pedido da bebida\n4 - finalizar pedido\n5 - sair");
                        int op1 = Convert.ToInt32(Console.ReadLine());
                        switch (op1)
                        {
                            case 1:
                                cliente.VerCardapio(cardapio);

                                System.Console.WriteLine("realizar outra operação ?\n 1 - sim\n2 - não");
                                continua = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                int pass = 1;
                                while (pass == 1)
                                {
                                    System.Console.WriteLine("informe o codigo da comida");
                                    int item = Convert.ToInt32(Console.ReadLine());
                                    item -= 1;
                                    cliente.RealizarPedidoComida(item);
                                    System.Console.WriteLine("adicionar outra comida ?\n 1 - sim\n2 - não");
                                    pass = Convert.ToInt32(Console.ReadLine());
                                }

                                System.Console.WriteLine("realizar outra operação ?\n 1 - sim\n2 - não");
                                continua = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                pass = 1;
                                while (pass == 1)
                                {
                                    System.Console.WriteLine("informe o codigo da bebida");
                                    int item = Convert.ToInt32(Console.ReadLine());
                                    item -= 1;
                                    cliente.RealizarPedidoBebida(item);
                                    System.Console.WriteLine("adicionar outra bebida ?\n 1 - sim\n2 - não");
                                    pass = Convert.ToInt32(Console.ReadLine());
                                }

                                System.Console.WriteLine("realizar outra operação ?\n 1 - sim\n2 - não");
                                continua = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 4:
                                cliente.pedido.idpedido = idpedidos++;
                                idpedidos++;
                                cliente.terminarPedido(atendentes[0]);
                                //cliente.terminarPedido(atendentes[0].receberPedido(cliente.pedido));

                                System.Console.WriteLine("realizar outra operação ?\n 1 - sim\n2 - não");
                                continua = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 5:
                                continua = 2;
                                break;

                        }

                    }


                }

                else if (op == 2)
                {
                    int continua = 1;
                    while (continua != 2)
                    {
                        //listar pedidos , criar/editar cardapio, remove 
                        Console.WriteLine("1 - Cadastrar atendente \n2 - Listar pedidos\n3 - Enviar pedidos \n4 - Editar cardápio\n5 - sair ");
                        op2 = Convert.ToInt32(Console.ReadLine());
                        
                        switch (op2)
                        {
                            case 1:
                                int pass = 1;
                                while (pass == 1)
                                {
                                    System.Console.WriteLine("Digite respectivamente, o ID, salario, nome, cpf, idade, e sexo do(a) atendente:");
                                    int id1 = Convert.ToInt32(Console.ReadLine());
                                    double salario1 = Convert.ToDouble(Console.ReadLine());
                                    string nome1 = Console.ReadLine();
                                    string cpf1 = Console.ReadLine();
                                    int idade1 = Convert.ToInt32(Console.ReadLine());
                                    char sexo1 = Convert.ToChar(Console.ReadLine());
                                    atendente = new Atendente(id1, salario1, nome1, cpf1, idade1, sexo1);
                                    atendentes.Add(atendente);
                                    System.Console.WriteLine("Cadastrar outro(a) atendente?\n 1 - sim\n2 - não");
                                    pass = Convert.ToInt32(Console.ReadLine());
                                }
                                //Arquivo atendente
                                string s = JsonSerializer.Serialize<List<Atendente>>(atendentes);
                                File.WriteAllText("Atendentes.json", s);

                                System.Console.WriteLine("realizar outra operação ?\n 1 - sim\n2 - não");
                                continua = Convert.ToInt32(Console.ReadLine());
                                break;

                            case 2:
                                atendentes[0].ListarPedidos(atendentes[0].pedidos);

                                System.Console.WriteLine("realizar outra operação ?\n 1 - sim\n2 - não");
                                continua = Convert.ToInt32(Console.ReadLine());
                                break;

                            case 3:
                                atendentes[0].enviarPedido(cozinheiros[0]);
                                System.Console.WriteLine("realizar outra operação ?\n 1 - sim\n2 - não");
                                continua = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 4:
                                System.Console.WriteLine("deseja editar uma bebida ou comida ?\n");
                                System.Console.WriteLine("1 - Adicionar Bebida\n2 - adicionar Comida\n3 - editar Comida\n4 - editar bebida\n5 - remover Comida\n6 - remover Bebida");
                                op2 = Int32.Parse(Console.ReadLine());
                                switch (op2)
                                {
                                    //adicionar bebida
                                    case 1:
                                        Console.WriteLine("id da bebida");
                                        id = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("nome da bebida");
                                        nome = Console.ReadLine();
                                        bebida = new Bebida(id, nome);
                                        cardapio.addBebida(bebida);
                                        break;
                                    //adicionar comida
                                    case 2:
                                        Console.WriteLine("id da comida");
                                        id = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("nome da comida");
                                        nome = Console.ReadLine();
                                        comida = new Comida(id, nome);
                                        cardapio.addComida(comida);
                                        break;
                                    //listar cardapio
                                    //editar comida
                                    case 3:
                                        //mostra os bagulho
                                        System.Console.WriteLine("Comidas:");
                                        for (int c = 0; c < cardapio.getComidas().Count; c++)
                                        {
                                            System.Console.WriteLine(cardapio.getComidas()[c].id + " - " + cardapio.getComidas()[c].nome);
                                        }
                                        //vai editar
                                        Console.WriteLine("id da comida");
                                        id = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Novo nome da comida");
                                        nome = Console.ReadLine();
                                        cardapio.editarcomida(id, nome);
                                        break;
                                    // edita bebida
                                    case 4:
                                        //mostra os bagulho
                                        System.Console.WriteLine("Bebidas:");
                                        for (int c = 0; c < cardapio.getBebidas().Count; c++)
                                        {
                                            System.Console.WriteLine(cardapio.getBebidas()[c].id + " - " + cardapio.getBebidas()[c].nome);
                                        }
                                        //vai editar
                                        Console.WriteLine("id da bebida");
                                        id = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Novo nome da bebida");
                                        nome = Console.ReadLine();
                                        cardapio.editarbebida(id, nome);
                                        break;
                                    //remove comida
                                    case 5:

                                        cardapio.ListarCardapio();
                                        //vai remover
                                        Console.WriteLine("id da comida a ser removida");
                                        id = Int32.Parse(Console.ReadLine());
                                        cardapio.removecomida(id);
                                        break;
                                    // remove bebida
                                    case 6:
                                        cardapio.ListarCardapio();
                                        //vai remover
                                        Console.WriteLine("id da comida a ser removida");
                                        id = Int32.Parse(Console.ReadLine());
                                        cardapio.removebebida(id);
                                        break;


                                }
                                cardapio.Comidas_toJson();
                                cardapio.Bebidas_toJson();

                                System.Console.WriteLine("realizar outra operação ?\n 1 - sim\n2 - não");
                                continua = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 5:
                                continua = 2;
                                break;
                        }

                    }
                }
                else if (op == 3)
                {
                    int continua = 1;
                    while (continua != 2)
                    {
                        //listar pedidos , criar/editar cardapio, remove 
                        Console.WriteLine("1 - Cadastrar cozinheiro \n2 - Listar pedidos\n3 - finalizar pedido \n4 - Editar cardápio\n5 - sair");
                        int op3 = Convert.ToInt32(Console.ReadLine());
                        switch (op3)
                        {
                            case 1:
                                int pass = 1;
                                while (pass == 1)
                                {
                                    System.Console.WriteLine("Digite respectivamente, o ID, salario, nome, cpf, idade, e sexo do(a) cozinheiro(a):");
                                    int id2 = Convert.ToInt32(Console.ReadLine());
                                    double salario2 = Convert.ToDouble(Console.ReadLine()); ;
                                    string nome2 = Console.ReadLine(); ;
                                    string cpf2 = Console.ReadLine();
                                    int idade2 = Convert.ToInt32(Console.ReadLine());
                                    char sexo2 = Convert.ToChar(Console.ReadLine());
                                    cozinheiro = new Cozinheiro(id2, salario2, nome2, cpf2, idade2, sexo2);
                                    cozinheiros.Add(cozinheiro);
                                    //Arquivo cozinheiros
                                    string s = JsonSerializer.Serialize<List<Cozinheiro>>(cozinheiros);
                                    File.WriteAllText("Cozinheiros.json", s);

                                    System.Console.WriteLine("Cadastrar outro(a) atendente?\n 1 - sim\n2 - não");
                                    pass = Convert.ToInt32(Console.ReadLine());
                                }
                                break;
                            case 2:
                                cozinheiros[0].ListarPedidos(cozinheiros[0].pedidos);
                                break;
                            case 3:
                                int pedidoF = Convert.ToInt32(Console.ReadLine());
                                cozinheiros[0].finalizarPedidoX(pedidoF);
                                break;
                            case 4:
                                switch (op2)
                                {
                                    //adicionar bebida
                                    case 1:
                                        Console.WriteLine("id da bebida");
                                        id = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("nome da bebida");
                                        nome = Console.ReadLine();
                                        bebida = new Bebida(id, nome);
                                        cardapio.addBebida(bebida);
                                        break;
                                    //adicionar comida
                                    case 2:
                                        Console.WriteLine("id da comida");
                                        id = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("nome da comida");
                                        nome = Console.ReadLine();
                                        comida = new Comida(id, nome);
                                        cardapio.addComida(comida);
                                        break;
                                    //editar comida
                                    case 3:
                                        //mostra os bagulho
                                        System.Console.WriteLine("Comidas:");
                                        for (int c = 0; c < cardapio.getComidas().Count; c++)
                                        {
                                            System.Console.WriteLine(cardapio.getComidas()[c].id + " - " + cardapio.getComidas()[c].nome);
                                        }
                                        //vai editar
                                        Console.WriteLine("id da comida");
                                        id = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Novo nome da comida");
                                        nome = Console.ReadLine();
                                        cardapio.editarcomida(id, nome);
                                        break;
                                    // edita bebida
                                    case 4:
                                        cardapio.ListarCardapio();
                                        //vai editar
                                        Console.WriteLine("id da bebida");
                                        id = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Novo nome da bebida");
                                        nome = Console.ReadLine();
                                        cardapio.editarbebida(id, nome);
                                        break;
                                    //remove comida
                                    case 5:
                                        cardapio.ListarCardapio();
                                        //vai remover
                                        Console.WriteLine("id da comida a ser removida");
                                        id = Int32.Parse(Console.ReadLine());
                                        cardapio.removecomida(id);
                                        break;
                                    // remove bebida
                                    case 6:
                                        System.Console.WriteLine("Bebidas:");
                                        for (int c = 0; c < cardapio.getBebidas().Count; c++)
                                        {
                                            System.Console.WriteLine(cardapio.getBebidas()[c].id + " - " + cardapio.getBebidas()[c].nome);
                                        }
                                        //vai remover
                                        Console.WriteLine("id da comida a ser removida");
                                        id = Int32.Parse(Console.ReadLine());
                                        cardapio.removebebida(id);
                                        break;

                                }
                                System.Console.WriteLine("realizar outra operação ?\n 1 - sim\n2 - não");
                                continua = Convert.ToInt32(Console.ReadLine());
                                break;

                            case 5:
                                continua = 2;
                                break;
                        }
                        break;


                    }
                }
            }

        }

    }
}

