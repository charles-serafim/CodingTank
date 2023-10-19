/*
03 - Escreva um programa em C# que solicite ao usuário que adivinhe um número secreto entre 1 e 100. O programa deve gerar aleatoriamente o número secreto e fornecer dicas sobre se o palpite do usuário é maior ou menor do que o número secreto. O programa deve continuar pedindo palpites até que o usuário adivinhe corretamente o número secreto.
*/

using System.Text.RegularExpressions;

namespace Desafio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int secretNumber;
            int guess;
            int attempts;

            bool read = true;

            while (read)
            {
                Console.Clear();

                attempts = 0;

                Random random = new Random();
                secretNumber = random.Next(1, 101);

                Console.WriteLine("Adivinhe o número secreto entre 1 e 100:");
                guess = ReadNumber();

                while (guess != secretNumber)
                {
                    attempts++;
                    if (guess > secretNumber) Console.WriteLine("O número secreto é menor.");
                    else Console.WriteLine("O número secreto é maior.");
                    guess = ReadNumber();
                }

                attempts++;

                Console.WriteLine();
                Console.WriteLine($"Parabéns! Você acertou o número secreto ({secretNumber}) em {attempts} tentativas.");

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