/*
Desafio 3: Calculadora de Gorjeta

Objetivo: Escrever um programa que calcule o valor da gorjeta a ser deixada em um 
restaurante com base no valor da conta e na porcentagem de gorjeta.

Instruções:

Solicite ao usuário que insira o valor total da conta do restaurante.
Solicite ao usuário que insira a porcentagem de gorjeta desejada 
(por exemplo, 15% ou 20%).
Calcule o valor da gorjeta multiplicando o valor da conta pela porcentagem de gorjeta 
e dividindo por 100.
Exiba o valor da gorjeta e o total a ser pago (conta + gorjeta) na tela.

Dica: Use variáveis para armazenar os valores de entrada e os resultados intermediários.
*/

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao = 's';
            float conta, porcentagemGorjeta, gorjeta, total;

            while(opcao == 's')
            {
                Console.Clear();

                Console.WriteLine("Digite o total da conta: ");
                conta = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a porcentagem da gorjeta: ");
                porcentagemGorjeta = float.Parse(Console.ReadLine());

                gorjeta = CalcularGorjeta(conta, porcentagemGorjeta);
                total = CalcularTotal(conta, gorjeta);

                Console.WriteLine($"Valor da gorjeta: R$ {gorjeta:f2}");
                Console.WriteLine($"Valor total: R$ {total:f2}");

                Console.WriteLine("Deseja continuar? (s/n)");
                opcao = char.Parse(Console.ReadLine());
            }
        }

        static float CalcularGorjeta(float conta, float porcentagemGorjeta)
        {
            return conta * porcentagemGorjeta / 100;
        }

        static float CalcularTotal(float conta, float gorjeta)
        {
            return conta + gorjeta;
        }
    }
}