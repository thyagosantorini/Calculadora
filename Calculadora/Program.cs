using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        enum Menu { Soma =1, Subrtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair}

        static void Main(string[] args)
        {
            bool loopMenuSair = false;

            while (!loopMenuSair) {

                Console.WriteLine("Olá, seja bem-vindo ao meu programa de Calculadora!");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Selecione uma das opções abaixo, digitando o número:");
                //Mostrando as opções do Menu
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potenciação\n6-Radiciação\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Somar();
                        break;
                    case Menu.Subrtracao:
                        Subtrair();
                        break;
                    case Menu.Divisao:
                        Dividir();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicar();
                        break;
                    case Menu.Potencia:
                        Potencializar();
                        break;
                    case Menu.Raiz:
                        Radiacilizar();
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
        // Função para Dividir Dois Números
        static void Dividir()
        {
            Console.WriteLine("----- DIVISÃO -----");
            Console.WriteLine("Digite o primeiro número:");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            double n2 = double.Parse(Console.ReadLine());
            double resultado = n1 / n2;
            Console.WriteLine("O resultado da Divisão é: " + resultado);
            Console.WriteLine("Aperte ENTER para retornar!");

            Console.ReadLine();

        }
        // Função para Multiplicar Dois Números
        static void Multiplicar()
        {
            Console.WriteLine("----- MULTIPLICAÇÃO -----");
            Console.WriteLine("Digite o primeiro número:");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            double n2 = double.Parse(Console.ReadLine());
            double resultado = n1 * n2;
            Console.WriteLine("O resultado da Multiplicação é: " + resultado);
            Console.WriteLine("Aperte ENTER para retornar!");

            Console.ReadLine();

        }
        // Função para Potencializar um Número
        static void Potencializar()
        {
            Console.WriteLine("----- POTENCIALIZAÇÃO -----");
            Console.WriteLine("Digite a base numérica:");
            int baseNumerica = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente da sua base:");
            int expoente = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNumerica, expoente);
            Console.WriteLine("O resultado da Potenciação é: " + resultado);
            Console.WriteLine("Aperte ENTER para retornar!");

            Console.ReadLine();

        }
        // Função de Radiciação um Número
        static void Radiacilizar()
        {
            Console.WriteLine("----- RADICIAÇÃO -----");
            Console.WriteLine("Digite o número:");
            int numero = int.Parse(Console.ReadLine());;
            double resultado = Math.Sqrt(numero);
            Console.WriteLine("O resultado da Radiciação é: " + resultado);
            Console.WriteLine("Aperte ENTER para retornar!");

            Console.ReadLine();

        }
    }
}
