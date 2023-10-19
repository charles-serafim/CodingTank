/*
01 - Escreva um programa em C# que calcule a soma dos números pares em um intervalo de números inteiros especificado pelo usuário.
*/

using System.Text.RegularExpressions;

namespace Desafio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int begin, end, sum = 0;

            bool read = true;

            while (read)
            {
                Console.Clear();

                Console.WriteLine("Digite o início do intervalo:");
                begin = ReadNumber();
                Console.WriteLine("Digite o fim do intervalo:");
                end = ReadNumber();

                for (int i = begin; i <= end; i++) if (i % 2 == 0) sum += i;

                Console.WriteLine();
                Console.WriteLine($"Soma dos números pares no intervalo de {begin} a {end}: {sum}");

                Console.WriteLine();
                read = ReadYesOrNo("Deseja executar novamente");
            }

            Console.Clear();
        }

        static int ReadNumber() // com try-catch
        {
            int number;

            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                    Console.WriteLine();
                }
            }

            return number;
        }

        static bool ReadYesOrNo(string question)
        {
            Console.WriteLine($"{question}? (s/n)");
            while (true)
            {
                string option = Console.ReadLine()?.ToLower();

                if (Regex.IsMatch(option, "^(s(im)?|n(ao|ão)|n(ao)?o?)$")) return option.StartsWith("s");

                Console.WriteLine("Entrada inválida.");
                Console.WriteLine($"{question}? (s/n)");
                Console.WriteLine();

            }
        }
    }
}