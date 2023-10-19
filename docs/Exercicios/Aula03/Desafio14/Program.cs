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
            for(int i = 1; i <= 100; i++) sum += i;

            Console.WriteLine($"Soma dos números de 1 a 100: {sum}");
        }
    }
}