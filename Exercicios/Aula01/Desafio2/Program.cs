/*
Desafio 2: Calculadora de Idade

Objetivo: Escrever um programa que solicite ao usuário o ano atual e o ano de nascimento 
e calcule a idade.

Instruções:

Solicite ao usuário que insira o ano atual.
Solicite ao usuário que insira o ano de nascimento.
Calcule a idade subtraindo o ano de nascimento do ano atual.
Exiba a idade no console.

Dica: Use variáveis para armazenar os valores de entrada e os resultados intermediários.
*/

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao = 's';
            int anoAtual, anoNascimento;

            while(opcao == 's')
            {
                Console.Clear();

                Console.WriteLine("Digite o ano atual: ");
                anoAtual = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o ano de nascimento: ");
                anoNascimento = int.Parse(Console.ReadLine());

                Console.WriteLine("Idade: " + CalcularIdade(anoAtual, anoNascimento));

                Console.WriteLine("Deseja continuar? (s/n)");
                opcao = char.Parse(Console.ReadLine());
            }
        }

        static int CalcularIdade(int anoAtual, int anoNascimento)
        {
            return anoAtual - anoNascimento;
        }
    }
}