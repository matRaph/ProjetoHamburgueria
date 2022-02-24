﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHamburgueria
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Atendente> atendentes = new List<Atendente>() ;
            List<Cozinheiro> cozinheiros = new List<Cozinheiro>();
            List<Cardapio> cardapios = new List<Cardapio>();

            
            //A Hamburgueria
            Atendente atendente;
            Cozinheiro cozinheiro ;
            Cardapio cardapio = new Cardapio();
            Cliente cliente = new Cliente("Tonhão", "123.456.789-12", 24, 'M');
            Atendente a = new Atendente(2, 22, "breno", "123", 13, 'm');
            atendentes.Add(a);
            Atendente b =  new Atendente(1, 22, "arthur", "321", 13, 'm');
            atendentes.Add(b);
            int adat = 1;
            int idpedidos = 1;
            int op = 0;
            while(op != 4)
            {
            System.Console.WriteLine("1 - cliente\n2 - atendente\n3 - cozinheiro\n4 - finalizar");
            op = Convert.ToInt32(Console.ReadLine());
                if(op == 1){
                    int continua = 1;
                    while (continua != 2)
                    {
                        System.Console.WriteLine("1 - Ver cardápio\n2 - realizar pedido comida\n3 - realizar pedido da bebida\n4 - finalizar pedido\n5 - sair");
                        int op1 = Convert.ToInt32(Console.ReadLine());
                        switch(op1)
                        {
                            case 1:
                                cliente.VerCardapio(cardapio);
                                
                                System.Console.WriteLine("realizar outra operação ?\n 1 - sim\n2 - não");
                                continua = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                int pass = 1;
                                while(pass == 1)
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
                                while(pass == 1){
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
                                cliente.terminarPedido( atendentes[0]);
                                //cliente.terminarPedido(atendentes[0].receberPedido(cliente.pedido));

                                System.Console.WriteLine("realizar outra operação ?\n 1 - sim\n2 - não");
                                continua = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 5:
                                continua=2;
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
                        Console.WriteLine("1 - Cadastrar atendente \n2 - Listar pedidos\n3 - Enviar pedidos \n4 - Editar cardápio\n5 - ordenar e listar atendentes\n6 - sair ");
                        int op2 = Convert.ToInt32(Console.ReadLine());
                        
                        switch (op2)
                        {      
                            case 1:
                                int pass = 1;
                                while (pass == 1)
                                {
                                    System.Console.WriteLine("Digite respectivamente, o ID, salario, nome, cpf, idade, e sexo do(a) atendente:");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    double salario = Convert.ToDouble(Console.ReadLine()); ;
                                    string nome = Console.ReadLine(); ;
                                    string cpf = Console.ReadLine();
                                    int idade = Convert.ToInt32(Console.ReadLine());
                                    char sexo = Convert.ToChar(Console.ReadLine());
                                    atendente = new Atendente(id, salario, nome, cpf, idade, sexo);
                                    adat ++;
                                    atendentes[adat] = atendente;
                                    System.Console.WriteLine("Cadastrar outro(a) atendente?\n 1 - sim\n2 - não");
                                    pass = Convert.ToInt32(Console.ReadLine());
                                }
                                System.Console.WriteLine("realizar outra operação ?\n 1 - sim\n2 - não");
                                continua = Convert.ToInt32(Console.ReadLine());
                                break;

                            case 2:
                                atendentes[0].ListarPedidos(atendentes[0].pedidos, cardapio.Comidas, cardapio.Bebidas);

                                System.Console.WriteLine("realizar outra operação ?\n 1 - sim\n 2 - não");
                                continua = Convert.ToInt32(Console.ReadLine());                
                                break;

                            case 3:
                                atendentes[0].enviarPedido(cozinheiros[0]);
                                System.Console.WriteLine("realizar outra operação ?\n 1 - sim\n 2 - não");
                                continua = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 4:
                                cardapio.editarCardapio();
                                System.Console.WriteLine("realizar outra operação ?\n 1 - sim\n 2 - não");
                                continua = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 5:
                                Atendente[] newAtendentes = atendentes.ToArray();
                                Array.Sort(newAtendentes);
                                foreach(Atendente i in newAtendentes) Console.WriteLine(i.ToString());
                                break;
                            case 6:
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
                    switch(op3)
                    {
                        case 1:
                            int pass = 1;
                            while (pass == 1)
                            {
                                System.Console.WriteLine("Digite respectivamente, o ID, salario, nome, cpf, idade, e sexo do(a) cozinheiro(a):");
                                int id = Convert.ToInt32(Console.ReadLine());
                                double salario = Convert.ToDouble(Console.ReadLine()); ;
                                string nome = Console.ReadLine(); ;
                                string cpf = Console.ReadLine();
                                int idade = Convert.ToInt32(Console.ReadLine());
                                char sexo = Convert.ToChar(Console.ReadLine());
                                cozinheiro = new Cozinheiro(id, salario, nome, cpf, idade, sexo);
                                cozinheiros.Add(cozinheiro);
                                System.Console.WriteLine("Cadastrar outro(a) atendente?\n 1 - sim\n2 - não");
                                pass = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                        case 2:
                            cozinheiros[0].ListarPedidos(cozinheiros[0].pedidos, cardapio.Comidas, cardapio.Bebidas);
                            break;
                        case 3:
                            int pedidoF = Convert.ToInt32(Console.ReadLine());
                            cozinheiros[0].finalizarPedidoX(pedidoF);
                            break;
                        case 4:
                            while(continua != 2)
                            {
                                pass = 1;
                                cardapio.editarCardapio();
                                System.Console.WriteLine("realizar outra operação ?\n 1 - sim\n2 - não");
                                continua = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                            
                    
                        case 5 :
                            continua = 2;
                            break;
                    }
                    }
                }
                    




            }
            
        }
    }
}
