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
            int a, b;

            while(opcao == 's')
            {
                //limpar a tela
                Console.Clear();
                
                //ler as entradas do usuario
                Console.WriteLine("Digite o primeiro numero: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                b = int.Parse(Console.ReadLine());

                //chamar as funcoes
                Console.WriteLine("Soma: " + Soma(a, b));
                Console.WriteLine("Subtracao: " + Subtracao(a, b));
                Console.WriteLine("Multiplicacao: " + Multiplicacao(a, b));
                Console.WriteLine("Divisao: " + Divisao(a, b));

                //perguntar se o usuario quer continuar
                Console.WriteLine("Deseja continuar? (s/n)");
                opcao = char.Parse(Console.ReadLine());
            }
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
