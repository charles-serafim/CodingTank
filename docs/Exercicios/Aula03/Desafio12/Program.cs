/*
Exercício 01: 
Faça um algoritmo que construa dois vetores A e B de 10 elementos e,
a partir deles, crie um vetor C, composto pela soma dos elementos, sendo: 

C[1] = A[1] + B[9], C[2] = A[2] + B[9], C[3] = A[3] + B[8], etc.
*/

using System.Text.RegularExpressions;

namespace Desafio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            int[] B = new int[10];
            int[] C = new int[10];

            bool read = true;

            while (read)
            {
                Console.Clear();

                InitializeArray(A);
                InitializeArray(B);

                for (int i = 0; i < 10; i++) C[i] = A[i] + B[9 - i];

                PrintArray("A", A);
                PrintArray("B", B);
                PrintArray("C", C);

                read = ReadYesOrNo("Deseja executar novamente");
            }

            Console.Clear();
            GoOn();
        }

        static void InitializeArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(100);
        }

        static void PrintArray(string arrayName, int[] array)
        {
            string formattedArray = string.Join(", ", array);
            Console.WriteLine($"Conjunto {arrayName}: {{{formattedArray}}}\n");
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


        static void GoOn()
        {
            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}