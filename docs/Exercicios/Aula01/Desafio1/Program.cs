/*
Desafio 1: Calculadora

Objetivo: Escrever um programa que solicite ao usuário dois números e realize operações 
simples de adição, subtração, multiplicação e divisão.

Instruções:

Solicite ao usuário que insira dois números.
Realize as operações de adição, subtração, multiplicação e divisão entre esses números.
Exiba os resultados das operações no console.

Dica: Use variáveis para armazenar os números de entrada e os resultados intermediários.
*/


namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao = 's';
            double a, b;

            while(opcao == 's')
            {
                //limpar a tela
                Console.Clear();
                
                //ler as entradas do usuario
                Console.WriteLine("Digite o primeiro numero: ");
                a = ReadNumber();
                Console.WriteLine("Digite o segundo numero: ");
                b = a = ReadNumber();

                //chamar as funcoes
                Console.WriteLine($"{a} + {b} = " + Soma(a, b));
                Console.WriteLine($"{a} - {b} = " + Subtracao(a, b));
                Console.WriteLine($"{a} * {b} = " + Multiplicacao(a, b));
                Console.WriteLine($"{a} / {b} = " + ((b == 0) ? "Não é possível dividir por zero." : Divisao(a, b)));

                //perguntar se o usuario quer continuar
                Console.WriteLine("Deseja continuar? (s/n)");
                opcao = char.Parse(Console.ReadLine());
            }
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

        static int Soma(int a, int b)
        {
            return a + b;
        }

        static int Subtracao(int a, int b)
        {
            return a - b;
        }

        static int Multiplicacao(int a, int b)
        {
            return a * b;
        }

        static int Divisao(int a, int b)
        {
            return a / b;
        }
    }
}
