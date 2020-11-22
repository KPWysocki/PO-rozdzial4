using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile elementów ma być w tablicy?");
            int n = int.Parse(Console.ReadLine());
            int[] tab1 = new int[n];
            int[] tab2 = new int[n];
            while (n == 0)
            {
                Console.WriteLine("Prosze podac liczbe wieksza od 0");
                n = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i<n; i++)
            {
                Console.WriteLine("Podaj {0} element listy", i + 1);
                tab1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (i != n)
                {
                    tab2[i+1] = tab1[i];
                }
                tab2[0] = tab1[n-1];
            }
            Console.WriteLine("Wartosci tablicy docelowej:");
            for (int i=0;i<n;i++)
            {

                Console.Write(tab2[i]+", ");
            }
            Console.ReadKey();
        }
    }
}
