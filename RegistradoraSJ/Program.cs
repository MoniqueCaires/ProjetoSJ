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
            string produto1=" ", produto2=" ", produto3=" ";
            float  valor1= 0, valor2= 0, valor3= 0;
            int quantidade1= 0, quantidade2 = 0, quantidade3= 0, venda ;
            string loop = "s";


            Console.WriteLine("Você deseja ir para o menu s/n ");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\r\n   _____ _     _                              _           _____                    _        /\\/|       \r\n  / ____(_)   | |                            | |         / ____|                  | |      |/\\/        \r\n | (___  _ ___| |_ ___ _ __ ___   __ _     __| | ___    | (___   ___ _   _        | | ___   __ _  ___  \r\n  \\___ \\| / __| __/ _ | '_ ` _ \\ / _` |   / _` |/ _ \\    \\___ \\ / _ | | | |   _   | |/ _ \\ / _` |/ _ \\ \r\n  ____) | \\__ | ||  __| | | | | | (_| |  | (_| | (_) |   ____) |  __| |_| |  | |__| | (_) | (_| | (_) |\r\n |_____/|_|___/\\__\\___|_| |_| |_|\\__,_|   \\__,_|\\___/   |_____/ \\___|\\__,_|   \\____/ \\___/ \\__,_|\\___/ \r\n                                                                                                       \r\n                                                                                                       \r\n");
            Console.ResetColor();
            

            while (loop == "s")
           
            {
                Console.ForegroundColor= ConsoleColor.DarkMagenta;
                Console.WriteLine("Escolha a opção desejada:\n");
                Console.ResetColor();
                Console.WriteLine("1- Cadastrar novos produtos: ");
                Console.WriteLine("2- Realizar venda de produtos: ");
                Console.WriteLine("3- Gerar relatorio de produtos:");
                Console.Write("Escolha uma opção: ");
                menu = int.Parse(Console.ReadLine());


                if (menu == 1)
                {
                    Console.ForegroundColor= ConsoleColor.DarkMagenta;
                    Console.WriteLine("\n CADASTRAR NOVOS PRODUTOS: ");
                    Console.ResetColor();

                    Console.Write("\nNome primeiro produto: ");
                    produto1 = Console.ReadLine();

                    Console.Write("Digite a quantidade de estoque do primeiro produto: ");
                    quantidade1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do produto: ");
                    valor1 = float.Parse(Console.ReadLine());



                    Console.Write("\nNome do novo produto: ");
                    produto2 = Console.ReadLine();

                    Console.Write("Digite a quantidade de estoque do produto: ");
                    quantidade2 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do produto: ");
                    valor2 = float.Parse(Console.ReadLine());



                    Console.Write("\nNome do novo produto: ");
                    produto3 = Console.ReadLine();

                    Console.Write("Digite a quantidade de estoque do produto: ");
                    quantidade3 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do produto: ");
                    valor3 = float.Parse(Console.ReadLine());

                }

                else if (menu == 2)
                {
                    Console.ForegroundColor=ConsoleColor.DarkMagenta;
                    Console.WriteLine(" Você escolheu REALIZAR VENDA DE PRODUTOS: ");
                    Console.ResetColor();

                    Console.WriteLine(" 1-" + produto1 + "\n 2-" + produto2 + "\n 3- " +produto3 + "\n Digite o produto: "); 
                    venda = int.Parse (Console.ReadLine());
                    
                    if (venda == 1)
                    {
                        Console.Write(" Produto: " + produto1  + "\n Valor: " + valor1 );
                    }
                    else if(venda == 2)
                    {
                        Console.Write(" Produto: " + produto2 + "\n Valor: " + valor2 );
                    }
                    else if(venda == 3)
                    {
                        Console.Write(" Produto: " + produto3 + "\n Valor: " + valor3);
                    }
                    else
                    {
                        Console.Write(" Opção invalida, PRODUTO SEM CADASRTRO! ");
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

                Console.ForegroundColor= ConsoleColor.DarkMagenta;
                Console.WriteLine("\nDeseja continuar no sistema (s/n) ");
                Console.ResetColor();
                loop = Console.ReadLine();
                Console.Clear();


            }


            

            Console.ForegroundColor= ConsoleColor.DarkMagenta;
            Console.WriteLine("Pressione <enter> para finalizar...");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
