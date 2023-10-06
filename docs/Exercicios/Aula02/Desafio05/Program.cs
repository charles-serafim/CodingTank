/*
DESAFIO 05:

Sr. José, pescador, comprou um microcomputador para
controlar o rendimento diário de seu trabalho. Toda vez que ele traz um peso de
peixes maior que o estabelecido pelo regulamento de pesca do estado de São Paulo
(50 quilos) deve pagar uma multa de R$4,00 por quilo excedente. Sr. José, precisa que
você faça programa que leia o peso de peixes e verifique se há excesso.
Se houver, gravar o Excesso e o valor da multa que Sr. José
deverá pagar. Caso contrário mostrar os valores com o conteúdo ZERO. 
Apresentar as mensagens no console.
*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool read = true;
            int count = 0;
            List<FishEntry> fishList = new List<FishEntry>();

            while(read)
            {
                Console.Clear();

                int fishQuantity = ReadFishQuantity();

                FishEntry newEntry = new FishEntry(fishQuantity);

                fishList.Add(newEntry);

                Console.WriteLine();
                Console.WriteLine($"Quantidade de peixe: {fishList[count].Quantity} kg");
                Console.WriteLine($"Excesso: {fishList[count].Excess} kg");
                Console.WriteLine($"Multa: R$ {fishList[count].Fee:F2}");
                Console.WriteLine();

                count++;

                Console.WriteLine("Registrar nova entrada? (s/n)");
                read = ReadOption();
            }

            Console.Clear();
            PrintFishList(fishList);
        }

        static int ReadFishQuantity()
        {
            int fishQuantity;

            while(true)
            {
                Console.WriteLine("Quantidade de peixe pescada: ");

                try
                {
                    fishQuantity = int.Parse(Console.ReadLine());

                    if(fishQuantity < 0)
                    {
                        Console.WriteLine("A quantidade não pode ser negativa. Digite novamente.");
                        Console.WriteLine();
                        continue;
                    }

                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                    Console.WriteLine();
                }
            }

            return fishQuantity;
        }

        static bool ReadOption()
        {
            while(true)
            {
                string option = Console.ReadLine()?.ToLower();

                if(Regex.IsMatch(option, "^(s(im)?|n(ao|ão)|n(ao)?o?)$")) return option.StartsWith("s");

                Console.WriteLine("Entrada inválida.");
                Console.WriteLine("Registrar nova entrada? (s/n)");
                Console.WriteLine();

            }
        }

        static void PrintFishList(List<FishEntry> fishList)
        {
            int count = 1;
            Console.WriteLine("Valores registrados:");
            Console.WriteLine();

            foreach(FishEntry entry in fishList)
            {
                Console.WriteLine($"{count:D3} - Quantidade: {entry.Quantity + " kg", - 12} Excesso: {entry.Excess + " kg", - 12} Multa: R$ {entry.Fee:F2}");
                count++;
            }
            
            Console.WriteLine();
        }
    }

    class FishEntry
    {
        public int Quantity { get; set; }
        public int Excess { get; set; }
        public double Fee { get; set; }

        public FishEntry(int quantity)
        {
            Quantity = quantity;
            Excess = (quantity <= 50) ? 0 : quantity - 50;
            Fee = (quantity <= 50) ? 0 : Excess * 4;
        }
    }
}