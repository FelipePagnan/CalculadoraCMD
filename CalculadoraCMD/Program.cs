using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraCMD
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6, Sair = 7}

        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Seja bem-vindo a CALCULADORA, selecione uma das opções.");
                Console.WriteLine("1.Soma\n2.Subtração\n3.Divisao\n4.Multiplicacao\n5.Potência\n6.Raiz\n7.Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtracao:
                        Sub();
                        break;

                    case Menu.Divisao:
                        Div();
                        break;

                    case Menu.Multiplicacao:
                        Mult();
                        break;

                    case Menu.Potencia:
                        Pot();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }

                Console.Clear();
            }               
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros.");
            Console.WriteLine("Digite o primeiro numero: ");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            double b = int.Parse(Console.ReadLine());
            double resultado = a + b;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("Subtração de dois numeros.");
            Console.WriteLine("Digite o primeiro numero: ");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            double b = int.Parse(Console.ReadLine());
            double resultado = a - b;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("Divisão de dois numeros.");
            Console.WriteLine("Digite o primeiro numero: ");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            double b = int.Parse(Console.ReadLine());
            double resultado = a / b;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.WriteLine("Multiplicação de dois numeros.");
            Console.WriteLine("Digite o primeiro numero: ");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            double b = int.Parse(Console.ReadLine());
            double resultado = a * b;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potência de um numero.");
            Console.WriteLine("Digite a base: ");
            double baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            double expo = int.Parse(Console.ReadLine());
            double resultado = Math.Pow(baseNum, expo);
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um numero.");
            Console.WriteLine("Digite o numero: ");
            double a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }

    }
}
