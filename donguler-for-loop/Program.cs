using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı giriniz :");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            {
                if (i%4 == 1)
                {
                    Console.WriteLine(i);
                }

            }
            int tektoplam = 0;
            int cifttoplam = 0;
            for (int i = 0; i <= 1000 ; i++)
            {
                if(i%2 == 1)
                {
                tektoplam = tektoplam + i;
                }
                if(i%2 == 0)
                {
                cifttoplam = cifttoplam + i;
                }
                
            }
            Console.WriteLine(tektoplam);
            Console.WriteLine(cifttoplam);

        //break, continue
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);

                if (i == 4)
                {    
                    string girdi = Console.ReadLine();
                    if (girdi == "devam")
                        {
                        continue;
                        }
                    else
                        {
                        break;
                        }
                }

            }

        }

    }

}
