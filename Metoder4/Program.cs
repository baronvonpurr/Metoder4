using System;

namespace Metoder4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal");
            double tal = double.Parse(Console.ReadLine());
            double tal2 = double.Parse(Console.ReadLine());
            Console.WriteLine(beräkning(tal, tal2));
        }

        static double beräkning(double tal, double tal2)
        {
            double tal3 = tal;
            for (int i = 0; i < tal2 - 1; i++)
            {
                tal *= tal3;
            }
            return tal;
        }
    }
}