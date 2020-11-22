using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile liczb ma sie znalezc w tablicy?");
            int rozmiar = int.Parse(Console.ReadLine());
            while (rozmiar == 0)
            {
                Console.WriteLine("Prosze podać liczbę dodatnia");
                rozmiar = int.Parse(Console.ReadLine());
            }            
            int[] tablica = new int[rozmiar];
            for (int i = 0; i < rozmiar; i++)
            {
                Console.WriteLine("Podaj {0} liczbę", i + 1);
                tablica[i] = int.Parse(Console.ReadLine());
            }
            int max = tablica[0];
            int pozycja_max = 0;
            for (int i = 0; i < rozmiar; i++)
            {
                if(max<tablica[i])
                {
                    max = tablica[i];
                    pozycja_max = i+1;
                }
                
            }
            Console.WriteLine("Najwyzsza wartość w tablicy to {0} znajduje sie na pozycji {1}", max, pozycja_max);
            int min = tablica[0];
            int pozycja_min = 0;
            for (int i = 0; i < rozmiar; i++)
            {
                if (min > tablica[i])
                {
                    min = tablica[i];
                    pozycja_min = i + 1;
                }

            }
            Console.WriteLine("Najmniejsza wartość w tablicy to {0} znajduje sie na pozycji {1}", min, pozycja_min);
            double suma = 0;
            for (int i = 0; i < rozmiar; i++)
            {
                suma = suma + tablica[i];
            }
            Console.WriteLine("Średnia wartość w tablicy to {0}", suma/rozmiar);

            int licznik = 0;
            for (int i=0; i<rozmiar;i++)
            {
                if (tablica[i]>0)
                {
                    licznik++;
                }
            }
            Console.WriteLine("W tablicy jest {0} elementow dodatnich", licznik);
            Console.ReadKey();
        }

    }
}
