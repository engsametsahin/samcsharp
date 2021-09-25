using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayı : " + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata : " + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem Tamam");
            }

            try
            {
                 //int a = int.Parse(null);
                 //int a = int.Parse("Test");
                 int a = int.Parse("-2127657907655444");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Hatalı Format");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Değer limit dışında");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem Tamam");
            }

        }
    }
}
