/*
EXERCÍCIO 04

Faça um algoritmo que leia números até o usuário digitar 0, após
finalizar, mostre quantos números lidos, a soma e quantos são pares.
*/

namespace Desafio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            List<double> numberList = new List<double>();
            double number;
            double sum = 0;
            int count = 0;
            int evenCount = 0;

            Console.WriteLine("Digite os números (digite 0 para encerrar):");

            do
            {
                number = ReadNumber();
                numberList.Add(number);
                sum += number;
                count++;
                if(number % 2 == 0) evenCount++;
            } while(number != 0 || number != 0.0);

            Console.Clear();
            Console.Write("Lista de números: {");

            // utilizar join
            for(int i = 0; i < numberList.Count - 2; i++) Console.Write($"{numberList[i]}; ");
            Console.WriteLine($"{numberList[numberList.Count - 2]}" + "}\n");

            Console.WriteLine($"Quantidade de números lidos: {count - 1}"); // pra não contar o 0
            Console.WriteLine($"Quantidade de números pares: {evenCount - 1}"); // pra não contar o 0
            Console.WriteLine($"Soma total: {sum:F3}");

        }

        static double ReadNumber()
        {
            double number;

            while(true)
            {
                try
                {
                    number = double.Parse(Console.ReadLine());
                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                    Console.WriteLine();
                }
            }
            return number;
        }

        static void PrintNumberList(List<double> numberList)
        {
            Console.Write("Lista de números: {");
            foreach(double number in numberList) Console.Write($"{number}, ");
        }
    }
}