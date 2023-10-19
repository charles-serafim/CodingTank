/*
02 - Escreva um programa em C# que gere e exiba os primeiros N termos da sequência de Fibonacci, onde N é especificado pelo usuário.
*/

using System.Text.RegularExpressions;

namespace Desafio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int n;

            bool read = true;

            while (read)
            {
                Console.Clear();

                Console.WriteLine("Digite o número de termos da sequência de Fibonacci (por sua conta e risco):");
                n = ReadNumber();

                Console.WriteLine();
                Console.WriteLine($"Sequência de Fibonacci com {n} termos:");
                for (int i = 0; i < n; i++) Console.Write($"{Fibonacci(i)} ");
                Console.WriteLine();

                Console.WriteLine();
                read = ReadYesOrNo("Deseja executar novamente");
            }

            Console.Clear();
        }

        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
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