/*
DESAFIO 11:

As Organizações Tabajara resolveram dar um aumento de salário aos seus colaboradores e  lhe contraram para desenvolver o programa que calculará os reajustes.
Faça um programa que recebe o salário de um colaborador e o reajuste segundo o seguinte  critério, baseado no salário atual:    
    - salários até R$ 280,00 (incluindo) : aumento de 20%
    - salários entre R$ 280,00 e R$ 700,00 : aumento de 15%
    - salários entre R$ 700,00 e R$ 1500,00 : aumento de 10%
    - salários de R$ 1500,00 em diante : aumento de 5%

Após o aumento ser realizado, informe na tela:
    - o salário antes do reajuste;
    - o percentual de aumento aplicado;
    - o valor do aumento;
    - o novo salário, após o aumento.
*/


using System.Text.RegularExpressions;

namespace Desafio11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool read = true;

            List<EmployeeSalary> employeeList = new List<EmployeeSalary>();

            while (read)
            {
                Console.Clear();

                Console.WriteLine("Digite o salário do funcionário: ");

                double salary = ReadNumber();
                EmployeeSalary salaryEntry = new EmployeeSalary(salary);

                salaryEntry.IncreaseSalary();

                employeeList.Add(salaryEntry);

                read = ReadYesOrNo("Registrar novo aumento");
            }

            Console.Clear();

            PrintList(employeeList, "Aumentos realizados", "Novo salário");
        }

        static bool ReadYesOrNo(string question)
        {
            Console.WriteLine($"{question}? (s/n)");
            while (true)
            {
                string option = Console.ReadLine()?.ToLower();

                if (Regex.IsMatch(option, "^(s(im)?|n(ao|ão)|n(ao)?o?)$")) return option.StartsWith("s");

                Console.WriteLine("Entrada inválida.");
                Console.WriteLine($"{question}? (s/n)");
                Console.WriteLine();

            }
        }

        static double ReadNumber() // com try-catch
        {
            double number;

            while (true)
            {
                try
                {
                    number = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                    Console.WriteLine();
                }
            }

            return number;

        }

        static void PrintList(List<EmployeeSalary> objectList, string listDescription, string typeDescription)
        {
            int count = 1;
            Console.WriteLine($"{listDescription}:");
            Console.WriteLine();

            foreach (EmployeeSalary objectInstance in objectList)
            {
                Console.WriteLine($"{count:D3} - {typeDescription}: R$ {objectInstance.Salary:F2}");
                count++;
            }

            Console.WriteLine();
        }
    }

    class EmployeeSalary
    {
        public double Salary { get; set; }
        public double RaiseRate { get; set; }

        public EmployeeSalary(double salary)
        {
            Salary = salary;
            RaiseRate = CalculateRaiseRate(salary);
        }

        public double CalculateRaiseRate(double salary)
        {
            if (salary <= 280) return 0.2;
            if (salary <= 700) return 0.15;
            if (salary <= 1500) return 0.1;
            return 0.05;
        }

        public void IncreaseSalary()
        {
            Console.WriteLine($"Salário antes do reajuste: R$ {this.Salary:F2}");
            double salaryIncrease = this.Salary * RaiseRate;
            this.Salary += salaryIncrease;

            Console.WriteLine($"Percentual de aumento aplicado: {this.RaiseRate * 100}%");
            Console.WriteLine($"Total do aumento: R$ {salaryIncrease:F2}");
            Console.WriteLine($"Salário após o reajuste: R$ {this.Salary:F2}");
            Console.WriteLine();
        }
    }
}