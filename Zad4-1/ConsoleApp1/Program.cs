using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile liczb ma sie znalezc w tablicy?");
            int a = int.Parse(Console.ReadLine());
            int[] tablica = new int[a];
            for (int i=0; i<a; i++)
            {
                Console.WriteLine("Podaj {0} liczbę", i + 1);
                tablica[i] = int.Parse(Console.ReadLine());
            }
            for (int i=0; i<a;i++)
            {
                Console.Write(tablica[i] + ", ");
            }
            Console.ReadKey();
        }

    }
}
