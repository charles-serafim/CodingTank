/*
Desafio 4: Conversor de Moedas

Objetivo: Escrever um programa que converta um valor em reais para outras duas moedas 
estrangeiras (por exemplo, dólar e euro).

Instruções:

Solicite ao usuário que insira um valor em reais.
Defina as taxas de conversão para dólar e euro. Por exemplo, 1 dólar = 5,50 reais e 1 euro = 6,50 reais.
Calcule o valor equivalente em dólares e euros.
Exiba os valores convertidos na tela.

Dica: Use variáveis para armazenar os valores de entrada, as taxas de conversão e os resultados intermediários.
*/

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao = 's';
            float valorReal, valorDolar, valorEuro, taxaRealDolar, taxaRealEuro;
            taxaRealDolar = 5.17F;
            taxaRealEuro = 5.45F;

            while(opcao == 's')
            {
                Console.Clear();

                Console.WriteLine("Digite o valor em reais, com as unidades decimais separadas por vírgula: ");
                valorReal = float.Parse(Console.ReadLine());

                valorDolar = CalcularValorDolar(valorReal, taxaRealDolar);
                valorEuro = CalcularValorEuro(valorReal, taxaRealEuro);
                
                Console.WriteLine($"Valor em dólares: {valorDolar:f2}");
                Console.WriteLine($"Valor em euros: {valorEuro:f2}");

                Console.WriteLine("Deseja continuar? (s/n)");
                opcao = char.Parse(Console.ReadLine());
            }
        }

        static float CalcularValorDolar(float valorReal, float taxaRealDolar)
        {
            return valorReal / taxaRealDolar;
        }

        static float CalcularValorEuro(float valorReal, float taxaRealEuro)
        {
            return valorReal / taxaRealEuro;
        }
    }
}