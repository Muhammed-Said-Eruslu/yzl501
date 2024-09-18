

using System.Text.Json;

namespace _25_HesapMakinesii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool deavMı = true;
            while (deavMı)
            {
                Hesapla();
                deavMı = SorDevamMı();
            }
        }

        private static void Hesapla()
        {
            double sayı1, sayı2;
            string islem;

            Bilgi(); // output
            Console.WriteLine("Lütfen Bir Sayı Giriniz ");
            sayı1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen Bir İşlem Seçiniz");
            islem = Console.ReadLine();

            Console.WriteLine("İkinci Sayıyı Giriniz");
            sayı2 = Convert.ToDouble(Console.ReadLine());

            if (islem == "+")
            {
                Console.WriteLine($"Sonuç : {Toplam(sayı1, sayı2)} ");
            }
            else if (islem == "-")
            {
                Console.WriteLine($"Sonuç {Fark(sayı1, sayı2)}");
            }
            else if (islem == "*")
            {
                Console.WriteLine($"Sonuç : {Çarp(sayı1,sayı2)}");
            }
            else if (islem == "/")
            {
                Console.WriteLine($"Sonuç : {Böl(sayı1,sayı2)}");
            }
        }

        private static double Fark(double sayı1, double sayı2)
        {
            return sayı1 + sayı2;
        }

        private static double Toplam(double sayı1, double sayı2)
        {
            return sayı1 - sayı2;
        }

        private static void Bilgi()
        {
            Console.WriteLine("Basit Bir Hesap Makinasi");
            Console.WriteLine("İşlem [ Topla (+) Fark(-) Çarp(*) Böl(/) ]");
        }

        private static double Çarp(double sayı1, double sayı2)
        {
            return sayı1 * sayı2;
        }
        private static double Böl(double say1, double sayı2)
        {
            return say1 / sayı2;
        }
        private static bool SorDevamMı()
        {
            Console.WriteLine("Devam Etmek İster Misin (E/H)");
            return (Console.ReadLine().ToLower() == "e");
        }
    }
}
