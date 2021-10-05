using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametre
            string sayi = "999";
            //try prase ifadesi stringin parse edilip edilemediğini sorgular. bool ifade döndürür.
            bool sonuc = int.TryParse(sayi, out int outsayi);

            if (sonuc == true)
            {
                Console.WriteLine("TryParse başarılı");
                Console.WriteLine(outsayi);
            }else {
                Console.WriteLine("TryParse başarısız");
            }

            Metotlar metodlarIns = new Metotlar();
            metodlarIns.Topla(4, 5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metot overloading

            int ifade = 999;
            metodlarIns.EkranaYazdir(ifade);
            metodlarIns.EkranaYazdir("sa","as");



        }
    }

        class Metotlar {
            public void Topla(int a, int b, out int toplam){
                toplam = a + b;
            }

            //iki ayrı veri tipi tanımlayarak veya parametre sayisini arttirarak overload edebiliriz.
            public void EkranaYazdir(string veri) {
                Console.WriteLine(veri);
            }

            public void EkranaYazdir(int veri) {
                Console.WriteLine(veri);
            }

            public void EkranaYazdir(string veri1, string veri2) {
                Console.WriteLine(veri1 + veri2);
            }
        }

        


}
