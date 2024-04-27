using System;

namespace Calculator
{
    class Progam
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação você deseja fazer?");
            Console.WriteLine("");

            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - DIVISÃO");
            Console.WriteLine("4 - MULTIPLICAÇÃO");
            Console.WriteLine("5 - SAIR");

            Console.WriteLine("__________________");

            Console.WriteLine("Digite a opção desejada: ");
            short opcao = short.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;
                case 5:
                    System.Environment.Exit(0);break;
                default:
                    Menu();
                    break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"O resultado da soma é: {v1 + v2}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O Resultado da subtração é {v1 - v2}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            Console.WriteLine($"O resultado da divisão é {v1/v2}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo Valor:" );
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            Console.WriteLine($"O resultado da multiplicação é {v1 * v2}");
            Console.ReadKey();
            Menu();

        }
    }
}
