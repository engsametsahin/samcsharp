using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] sayidizisi = {23,12,4,86,72,3,11,17};
            foreach(var item in sayidizisi)
                {
                Console.WriteLine(item);
                }
            
            //Sort
            Array.Sort(sayidizisi);
            foreach(var item in sayidizisi)
                {
                Console.WriteLine(item);
                }

            //Clear
            Array.Clear(sayidizisi,2,2);
            foreach(var item in sayidizisi)
                {
                Console.WriteLine(item);
                }

            //Reverse
            Array.Reverse(sayidizisi);
            foreach(var item in sayidizisi)
                {
                Console.WriteLine(item);
                }
            
            //IndexOf
                Console.WriteLine(Array.IndexOf(sayidizisi,23));

            //Resize
            Array.Resize <int> (ref sayidizisi,9);
            sayidizisi[8] = 99;
            foreach(var item in sayidizisi)
                {
                Console.WriteLine(item);
                }            

        }
    }
}
