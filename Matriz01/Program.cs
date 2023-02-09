using System;
using System.Globalization;


namespace Matriz01
{
    class Program
    {
        static void Main(string[] args)
        {

            //03
            int N = int.Parse(Console.ReadLine());


            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            int[] mat1 = new int[A];
            int[] mat2 = new int[B];

            for (int i = 0; i < A; i++)
            {
                valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat1[i] = int.Parse(valores[i]);
                    mat2[2] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("soma");
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int soma = mat1[i] + mat2[j];
                }
            }
        }
    }
}
