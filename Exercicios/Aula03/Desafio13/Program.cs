/*
EXERCÍCIO 02

Crie um programa que peça 10 números inteiros
e apresente a média, a soma e o menor.

*/

using System.Text.RegularExpressions;

namespace Desafio13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool read = true;
            double average;
            int sum;
            int smaller;
            int entry;

            while (read)
            {
                Console.Clear();

                sum = 0;
                smaller = int.MaxValue;

                for (int i = 0; i < 10; i++)
                {
                    entry = ReadWithIndex("Número", i + 1);
                    sum += entry;
                    if (entry < smaller) smaller = entry;
                }

                average = sum / 10.0;

                Console.WriteLine();
                Console.WriteLine($"Média: {sum / 10.0}");
                Console.WriteLine($"Soma: {sum}");
                Console.WriteLine($"Menor: {smaller}");
                Console.WriteLine();

                read = ReadYesOrNo("Deseja executar novamente");
            }

            Console.Clear();
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

        static int ReadWithIndex(string objectDescription, int i)
        {
            int number;

            Console.Write($"{objectDescription} {i}: ");

            number = ReadNumber();

            return number;
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


    }
}