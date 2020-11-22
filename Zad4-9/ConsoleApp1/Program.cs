using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst;
            Console.WriteLine("Wprowadź tekst:");
            tekst = Console.ReadLine();
            int licznik = 1;
            foreach (char litera in tekst)
                if (litera == ' ')
                {
                    licznik++;
                }
            Console.WriteLine("Wprowadzony tekst zawiera {0} wyrazów", licznik);
            Console.ReadKey();
        }
    }
}
