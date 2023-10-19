/*
Exercício 01: 
Faça um algoritmo que construa dois vetores A e B de 10 elementos e,
a partir deles, crie um vetor C, composto pela soma dos elementos, sendo: 

C[1] = A[1] + B[9], C[2] = A[2] + B[9], C[3] = A[3] + B[8], etc.
*/

namespace Desafio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            int[] B = new int[10];
            int[] C = new int[10];

            InitializeArray(A);
            InitializeArray(B);

            for(int i = 0; i < 10; i++) C[i] = A[i] + B[9 - i];
        }

        static void InitializeArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(100);
        }


    }
}