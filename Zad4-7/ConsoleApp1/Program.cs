using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] B = { { 8, 5, 6 }, { 2, 4, 5 } };
            int[,] C = new int[2, 3];
            for (int j=0; j<3; j++)
            {
                for (int i=0;i<2;i++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
                
            }
            Console.WriteLine("Macierz C");
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.Write(C[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
