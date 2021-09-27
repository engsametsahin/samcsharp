using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int t = 0;
            int sayi= int.Parse(Console.ReadLine());
            while(i <= sayi)
            {
                t = t + i;
                i++;
            }
            Console.WriteLine("ortalama : " + t / sayi);

        char character = 'a';
        while (character <= 'z')
        {
            Console.Write(character);
            character++;
        }

        Console.WriteLine("-- Foreach --");
        string [] arabalar = {"BMV","Ford","Toyota","Nissan"};

        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }

        

        }

    }
}
