using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistradoraSJ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int menu;
            string loop = "s";

            while (loop == "s")
           
            {
                Console.Clear();
                Console.WriteLine("Bem vindo seu João!\n");
                Console.WriteLine("Escolha a opção desejada:\n");
                Console.WriteLine("1- Cadastrar novos produtos: ");
                Console.WriteLine("2- Realizar venda de produtos: ");
                Console.WriteLine("3- Gerar relatorio de produtos:");
                Console.WriteLine("Escolha uma opção: ");
                menu = int.Parse(Console.ReadLine());


                if (menu == 1)
                {
                    Console.WriteLine(" Você escolheu CADASTRAR NOVOS PRODUTOS: ");
                }
                else if (menu == 2)
                {
                    Console.WriteLine(" Você escolheu REALIZAR VENDA DE PRODUTOS: ");
                }
                else if (menu == 3)
                {
                    Console.WriteLine("Você escolheu gerar RELATORIO DE PRODUTOS: ");
                }
                else
                {
                    Console.WriteLine("OPÇÃO INVALIDA!");
                }

                Console.WriteLine("Deseja continuar no sistema (s/n) ");
                loop = Console.ReadLine();


            }


            


            Console.WriteLine("Pressione <enter> para finalizar...");
            Console.ReadKey();
        }
    }
}
