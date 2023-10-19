/*
DESAFIO 08:

Um aluno realizou três provas de uma determinada disciplina. Levando em consideração o
critério apresentado a seguir, faça um programa que mostre se ele ficou para exame final,
e caso positivo, que nota o aluno precisará obter para passar de ano.

"Média = (Prova 1 + Prova 2 + Prova 3) / 3"

A média deve ser igual ou maior que 7,0. Caso o aluno não consiga, a nova média deve ser:

"Final = (Média + Exame) / 2"

A média final para a aprovação deve ser igual ou maior que 5,0.
*/


namespace Desafio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double media = 0;

            for(int i = 0; i < 3; i++)
            {
                media += ReadScore(i+1);
            }

            media = media/3;

            Console.WriteLine($"Média das provas: {media:F2}");

            if(media < 7)
            {
                double examScore = CalculateNecessaryScore(media);
                Console.WriteLine($"Nota necessária no Exame Final: {examScore:F2}");
            }
            else Console.WriteLine("Aprovado!");
        }

        // função que trata exceções da entrada das médias
        static double ReadScore(int i)
        {
            double score;

            while(true)
            {
                Console.WriteLine($"Nota {i}: ");

                try
                {
                    score = double.Parse(Console.ReadLine());

                    if(score < 0 || score > 10)
                    {
                        Console.WriteLine("A nota deve ser algum número entre 0 e 10. Digite novamente.");
                        Console.WriteLine();
                        continue;
                    }

                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número entre 0 e 10.");
                    Console.WriteLine();
                }
            }

            return score;
        }

        // função para calcular quanto o aluno precisa pra passar
        static double CalculateNecessaryScore(double media)
        {
            double examScore = 10 - media;
            return examScore;
        }
    }
}