using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] tab = { { 0, 1, 2, 3, 4 }, { 5, 6, 7, 8, 9 }, { 10, 11, 12, 13, 14 }, { 15, 16, 17, 18, 19 }, { 20, 21, 22, 23, 24 } };
            for (int j=0; j<5;j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(tab[i, j] + " ");
                }
                Console.Write("\n");
            }
            double suma = 0;
            for (int i = 0; i<5;i++)
            {
                suma = suma + tab[i, i];
            }
            Console.WriteLine("Suma na przekatnej wynosi {0}", suma);
            Console.ReadKey();
        }
    }
}
