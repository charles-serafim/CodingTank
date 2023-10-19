/*
EXERCÍCIO 03

Some os números de 1 a 100 a imprima o valor.
*/

namespace Desafio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int sum = 0;

            // Soma de Gauss
            sum = Gauss(1, 100);

            Console.WriteLine($"Soma dos números de 1 a 100: {sum}");
        }

        static int Gauss(int begin, int end)
        {
            return (begin + end) * (end - begin + 1) / 2;
        }
    }
}