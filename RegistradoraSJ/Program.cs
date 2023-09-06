using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace RegistradoraSJ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int menu;
            string produto1 = "Coxinha", produto2 = "Coca-Cola", produto3 = "Água";
            double valor1 = 5, valor2 = 6, valor3 = 3, precototal1, precototal2, precototal3;
            int quantidade1 = 10, quantidade2 = 10, quantidade3 = 10, venda;
            double compra1, compra2, compra3;
            double valorpago1, troco1, valorpago2, troco2, valorpago3, troco3;
            string loop = "s";



            Console.WriteLine(" Você deseja ir para o menu s/n ");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\r\n   _____ _     _                              _           _____                    _        /\\/|       \r\n  / ____(_)   | |                            | |         / ____|                  | |      |/\\/        \r\n | (___  _ ___| |_ ___ _ __ ___   __ _     __| | ___    | (___   ___ _   _        | | ___   __ _  ___  \r\n  \\___ \\| / __| __/ _ | '_ ` _ \\ / _` |   / _` |/ _ \\    \\___ \\ / _ | | | |   _   | |/ _ \\ / _` |/ _ \\ \r\n  ____) | \\__ | ||  __| | | | | | (_| |  | (_| | (_) |   ____) |  __| |_| |  | |__| | (_) | (_| | (_) |\r\n |_____/|_|___/\\__\\___|_| |_| |_|\\__,_|   \\__,_|\\___/   |_____/ \\___|\\__,_|   \\____/ \\___/ \\__,_|\\___/ \r\n                                                                                                       \r\n                                                                                                       \r\n");
            Console.ResetColor();


            while (loop.ToLower() == "s")

            {
                //MENU
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Escolha a opção desejada:\n");
                Console.ResetColor();
                Console.WriteLine("1- Cadastrar novos produtos: ");
                Console.WriteLine("2- Realizar venda de produtos: ");
                Console.WriteLine("3- Gerar relatorio de produtos:");
                Console.Write("Escolha uma opção: ");
                menu = int.Parse(Console.ReadLine());


                //PRIMEIRA OPÇÃO DO MENU
                if (menu == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\n CADASTRAR NOVOS PRODUTOS: ");
                    Console.ResetColor();

                    //PRIMEIRO PRODUTO
                    Console.Write("\nNome primeiro produto: ");
                    produto1 = Console.ReadLine();

                    Console.Write("Digite a quantidade de estoque do primeiro produto: ");
                    quantidade1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do produto: ");
                    valor1 = double.Parse(Console.ReadLine());



                    //SEGUNDO PRODUTO
                    Console.Write("\nNome do novo produto: ");
                    produto2 = Console.ReadLine();

                    Console.Write("Digite a quantidade de estoque do produto: ");
                    quantidade2 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do produto: ");
                    valor2 = double.Parse(Console.ReadLine());



                    //TERCEIRO PRODUTO
                    Console.Write("\nNome do novo produto: ");
                    produto3 = Console.ReadLine();

                    Console.Write("Digite a quantidade de estoque do produto: ");
                    quantidade3 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do produto: ");
                    valor3 = double.Parse(Console.ReadLine());

                }

                //SEGUNDA OPÇÃO DO MENU
                else if (menu == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(" Você escolheu REALIZAR VENDA DE PRODUTOS: ");
                    Console.ResetColor();

                    Console.Write("1-" + produto1 + "\n2-" + produto2 + "\n3-" + produto3 + " \nDigite o código do produto: ");
                    venda = int.Parse(Console.ReadLine());

                    if (venda == 1)
                    {
                        Console.WriteLine("Produto:" + produto1 + "\nValor:" + valor1);
                        Console.Write("\nQual é a quantidade de " + produto1 + ":");
                        compra1 = int.Parse(Console.ReadLine());

                        if (compra1 <= quantidade1)
                        {
                            precototal1 = compra1 * valor1;
                            Console.WriteLine("Valor total a pagar:R$" + precototal1);

                            Console.Write("\nQual o valor recebido:R$");
                            valorpago1 = double.Parse(Console.ReadLine());

                            if (valorpago1 < precototal1)
                            {
                                Console.Write("Valor insuficiente!");
                            }
                            else if (valorpago1 > precototal1)
                            {
                                troco1 = valorpago1 - precototal1;
                                Console.WriteLine("Seu troco:R$" + troco1);

                            }
                            else if (valorpago1 == precototal1)
                            {
                                Console.WriteLine("Transação aprovada!");
                            }

                        }
                        else
                        {
                            Console.WriteLine("\nQuantidade de produto indisponivél em estoque! ");
                        }

                    }
                    else if (venda == 2)
                    {
                        Console.Write("Produto: " + produto2 + "\nValor: " + valor2);
                        Console.Write("\nQual é a quantidade de " + produto2 + ":");
                        compra2 = int.Parse(Console.ReadLine());

                        if (compra2 <= quantidade2)
                        {
                            precototal2 = compra2 * valor2;
                            Console.WriteLine("Valor total a pagar:R$" + precototal2);

                            Console.Write("\nQual o valor recebido:R$");
                            valorpago2 = double.Parse(Console.ReadLine());

                            if (valorpago2 < precototal2)
                            {
                                Console.Write("Valor insuficiente!");
                            }
                            else if (valorpago2 > precototal2)
                            {
                                troco2 = valorpago2 - precototal2;
                                Console.WriteLine("Seu troco:R$" + troco2);

                            }
                            else if (valorpago2 == precototal2)
                            {
                                Console.WriteLine("Transação aprovada!");
                            }


                        }
                        else if (venda == 3)
                        {
                            Console.Write("Produto: " + produto3 + "\nValor: " + valor3);
                            Console.Write("\nQual é a quantidade de " + produto3 + ":");
                            compra3 = int.Parse(Console.ReadLine());

                            if (compra3 <= quantidade3)
                            {
                                precototal3 = compra3 * valor3;
                                Console.WriteLine("Valor total a pagar:R$" + precototal3);

                                Console.Write("\nQual o valor recebido:R$");
                                valorpago3 = double.Parse(Console.ReadLine());

                                if (valorpago3 < precototal3)
                                {
                                    Console.Write("Valor insuficiente!");
                                }
                                else if (valorpago3 > precototal3)
                                {
                                    troco3 = valorpago3 - precototal3;
                                    Console.WriteLine("Seu troco:R$" + troco3);

                                }
                                else if (valorpago3 == precototal3)
                                {
                                    Console.WriteLine("Transação aprovada!");
                                }


                            }
                            else
                            {
                                Console.Write("Opção invalida, PRODUTO SEM CADASRTRO! ");
                            }


                            //TERCEIRA OPÇÃO DO MENU
                        }
                    }
                }
                else if (menu == 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\n RELATORIO DE PRODUTOS: ");
                    Console.ResetColor();
                    Console.WriteLine("\n1-Produto: " + produto1 + "  Estoque: " + quantidade1 + "  Valor: " + valor1);
                    Console.WriteLine("\n2-Produto: " + produto2 + "  Estoque: " + quantidade2 + "  Valor: " + valor2);
                    Console.WriteLine("\n3-Produto: " + produto3 + "  Estoque: " + quantidade3 + "  Valor: " + valor3);
                }
                else
                {
                    Console.WriteLine("OPÇÃO INVALIDA!");
                }

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\nDeseja continuar no sistema (s/n) ");
                Console.ResetColor();
                loop = Console.ReadLine();



            }




            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Pressione <enter> para finalizar...");
            Console.ResetColor();
            Console.ReadKey();


        }



    }
}
