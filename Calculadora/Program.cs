using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        enum Menu { Soma =1, Subrtração, Divisão, Multiplicação, Sair}

        static void Main(string[] args)
        {
            bool loopMenuSair = false;

            while (!loopMenuSair) {

                Console.WriteLine("Olá, seja bem-vindo ao meu programa de Calculadora!");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Selecione uma das opções abaixo, digitando o número:");
                //Mostrando as opções do Menu
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Somar();
                        break;
                    case Menu.Subrtração:
                        Subtrair();
                        break;
                    case Menu.Sair:
                        loopMenuSair = true;
                        break;
                }

                Console.Clear(); //Essa função limpa o conteúdo

            }
        }

        // Função para Somar Dois Números
        static void Somar()
        {
            Console.WriteLine("----- SOMA -----");
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            int resultado = n1 + n2;
            Console.WriteLine("O resultado da Soma é: " + resultado);
            Console.WriteLine("Aperte ENTER para retornar!");

            Console.ReadLine();

        }
        // Função para Subrair Dois Números
        static void Subtrair()
        {
            Console.WriteLine("----- SUBTRAÇÃO -----");
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            int resultado = n1 - n2;
            Console.WriteLine("O resultado da Subtração é: " + resultado);
            Console.WriteLine("Aperte ENTER para retornar!");

            Console.ReadLine();

        }

    }
}
