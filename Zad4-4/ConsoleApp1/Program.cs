using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            int[] tab = new int[100];
            Random rand = new Random();
            for (i = 0; i < 100; i++)
            {
                tab[i]=rand.Next(1, 1000);
            }
            int licznik = 0;
            for (j = 0; j < tab.Length; j++)
            {
                for (k = 2; k < tab[j]; k++)

                    if (tab[j] % k == 0)
                    {

                        tab[j] = 0;
                        break;
                    }
                if (k == tab[j])
                {
                    if (tab[j] > 0)
                        tab[j] = 0 + 1;
                    licznik = licznik + tab[j];

                }
            }
            Console.WriteLine("W podanym zakresie znajduje sie {0} liczb pierwszych.", licznik);
            Console.ReadKey();
        }
           
    }
}
