using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)

            {
            /*
            erişim_belirteci geri_dönüştipi metot_adi(parametreListesi/arguman)
            {
                komutlar
            }
            */
            int a = 2;
            int b = 3;
            int sonuc = a + b;

            Console.WriteLine("normal toplama : " + sonuc);

            sonuc = Topla(a,b);
            Console.WriteLine("metod toplama : " + sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(sonuc.ToString());

            int sonuc2 = ornek.ArrtirVeTopla(5,6);
            Console.WriteLine(sonuc2.ToString());

            //referans vermek
            int sonuc3 = ornek.RefArtirTopla(ref a,ref b);
            Console.WriteLine(sonuc3.ToString());
            //maindeki a ve b değişkenini de değiştirdi.
            int sonuc4 = Topla(a,b);
            Console.WriteLine("referans sonrası değişen değerler toplama : " + sonuc4);

            }

            static int Topla(int deger1, int deger2)
            {
                return (deger1 + deger2);
            }

            


    }

class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public int ArrtirVeTopla(int x, int y){
        x++;
        y++;
        return x+y;
    }

    public int RefArtirTopla(ref int x, ref int y) {
        x++;
        y++;
        return x+y;
    }
}

}
