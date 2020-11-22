using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = { 0, 1, 2, -3, 4, 5, -6, 7, -8, -9 };
            int[] tab2 = new int[10];

            for (int i=0; i<10; i++)
            {
                if (tab1[i]>0)
                {
                    tab2[i] = tab1[i];
                }
                else
                {
                    tab2[i] = 0;
                }
            }
            for (int i=0; i<10;i++)
            {
                Console.Write(tab2[i] + ", ");
            }
            Console.ReadKey();
        }
    }
}
