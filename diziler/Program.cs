using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler = new string[5];//5 elemanlı string dizi tanımlıyoruz

            string[] hayvanlar = {"kedi","köpek","kuş","maymun"};//elemanlarını belirleyip string dizi tanımlıyoruz

            int[] dizi;
            dizi = new int[5];

            //dizilere değer atama ve erişim
            renkler[0] = "Mavi";

            Console.WriteLine(renkler[0]);
            Console.WriteLine(hayvanlar[0]);

            dizi[3] = 10;
            Console.WriteLine(dizi[3]);

            //döngülerle dizi
            //klavye ile girilen n sayısının ortalaması
            Console.Write("dizi 0'dan kaça kadar gitsin?");
            int diziuzunlugu = int.Parse(Console.ReadLine()) + 1;

            int[] sayidizisi = new int[diziuzunlugu];

            for(int i = 0; i < diziuzunlugu; i++)
            {
                sayidizisi[i] = i;
                Console.Write(sayidizisi[i] + "-");
            }

            int toplam = 0;
            foreach (var sayi in sayidizisi)
            {
                toplam = toplam + sayi;
            }

            Console.WriteLine("ortlama : " + toplam/diziuzunlugu);

            Console.Write("dizinin eleman sayısını giriniz :");
            int dizilenght = int.Parse(Console.ReadLine());
            int [] dizi2 = new int[dizilenght];

            for (int i = 0; i < dizilenght ; i ++)
            {
                Console.Write("{0}. sayıyı giriniz", i + 1);
                dizi2[i] = int.Parse(Console.ReadLine());
            }

            int tp = 0;
            foreach (var item in dizi2)
            {
                tp = tp + item;
            }

            Console.WriteLine("ortlama : " + tp/dizilenght);

        }
    }
}
