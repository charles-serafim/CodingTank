/*
DESAFIO 06:

Elabore um algoritmo que dada a idade de um nadador, classifique-o em uma das 
seguintes categorias:
Infantil A = 5 a 7 anos.
Infantil B = 8 a 11 anos.
Juvenil A = 12 a 13 anos.
Juvenil B = 14 a 17 anos.
Adultos = Maiores de 18 anos.
Apresentar as mensagens no console com a classificação.
*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Desafio06
{
    class Program
    {
        static void Main(string[] args)
        {
            bool read = true;
            int count = 0;
            List<Swimmer> swimmerList = new List<Swimmer>();

            while(read)
            {
                Console.Clear();
                
                string name = ReadName();
                int age = ReadAge();
                Swimmer newSwimmer = new Swimmer(name, age);

                swimmerList.Add(newSwimmer);

                Console.WriteLine();
                Console.WriteLine($"Atleta: {swimmerList[count].Name}");
                Console.WriteLine($"Idade: {swimmerList[count].Age}");
                Console.WriteLine($"Categoria: {swimmerList[count].Category}");
                Console.WriteLine();

                count++;

                Console.WriteLine("Registrar novo nadador? (s/n)");
                read = ReadOption();
            }

            Console.Clear();
            PrintSwimmerList(swimmerList);
        }

        static string ReadName()
        {
            string name;

            while(true)
            {
                Console.WriteLine("Nome: ");
                name = Console.ReadLine();

                if (!Regex.IsMatch(name, @"\d")) // Verifica se não há dígitos no nome
                {
                    return name;
                }

                Console.WriteLine();
                Console.WriteLine("Nome inválido. O nome não deve conter dígitos.");
            }

            return name;
        }

        static int ReadAge()
        {
            int age;

            while(true)
            {
                Console.WriteLine("Idade: ");

                try
                {
                    age = int.Parse(Console.ReadLine());

                    if(age < 5)
                    {
                        Console.WriteLine("O atleta não pode ter menos de 5 anos. Por favor, digite novamente.");
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

            return age;
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

        static void PrintSwimmerList(List<Swimmer> swimmerList)
        {
            int count = 1;
            Console.WriteLine("Atletas registrados:");
            Console.WriteLine();

            foreach(Swimmer entry in swimmerList)
            {
                Console.WriteLine($"{count:D3} - {entry.Name}\nIdade: {entry.Age + " anos"}\nCategoria: {entry.Category}");
                Console.WriteLine();
                count++;
            }
            
            Console.WriteLine();
        }
    }

    class Swimmer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Category { get; set; }

        public Swimmer(string name, int age)
        {
            Name = name;
            Age = age;
            Category = CaterogyClass(age);
        }

        public string CaterogyClass(int age)
        {
            string category;

            if(age <= 7) category = "Infantil A";
            else if(age <= 11) category = "Infantil B";
            else if(age <= 13) category = "Juvenil A";
            else if(age <= 17) category = "Juvenil B";
            else category = "Adultos";

            return category;
        }
    }
}