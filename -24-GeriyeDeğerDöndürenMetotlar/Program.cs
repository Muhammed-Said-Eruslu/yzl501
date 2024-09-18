using System.Net.Mail;

namespace GeriDegerDöndürenMetotlar
{
    internal class Program
    {
        // Sınıfın içindeki üyeler vardır .Metotlar,Properties,Constant
        // Constructor Method,fields
        static void Main(string[] args)
        {
            //EkranaYaz(); // Parametre almayan ve geriye değer döndürmeyen bir metodu çağırıyoruz
            //int toplam = Topla(321, 123);
            // double bolme =  Bolme(89, 65);
            // Console.WriteLine("Bir Sayı Giriniz");
            // int sayı = int.Parse(Console.ReadLine());
            // Console.WriteLine( CıftMI(sayı) ? "Sayı Çift" : "Sayı Tek");
            Console.WriteLine("MailAdress Adresleri :(virgül ile ayırark giriniz)");
            string mailAdresleri = Console.ReadLine();
            string[] mailAdresiDizisi = Ayrıstirici(mailAdresleri);
            MailGönder(mailAdresiDizisi);
            int domaınID = Thread.GetDomainID();
            Console.WriteLine("Domaın ID", domaınID);
        }
        static void EkranaYaz()
        {
            Console.WriteLine("Hesap Makinesi");
        }
        /// <summary>
        /// Verilen Parametreler Doğrultusunda toplama işlemi yapar
        /// </summary>
        /// <param name="sayı1"></param> sayı bir toplama işleminin birinci sayısı
        /// <param name="sayı2"></param> sayı ıkı toplama işleminin ıkıncı sayısı
        /// <returns></returns>

        static int Topla(int sayı1, int sayı2)
        {
            int sonuc;
            sonuc = sayı1 + sayı2;
            return sonuc;

        }
        private static double Bolme(double sayı1, double sayı2)
        {
            return sayı1 / sayı2;
        }

        static bool CıftMI(int sayı)
        {
            return (sayı % 2 == 0);
        }

        private static string[] Ayrıstirici(string mailAdresleri)
        {
            return mailAdresleri.Split(',', ';');
        }
        private static void MailGönder(string[] mailAdresiDizisi)
        {
            foreach (var mail in mailAdresiDizisi)
            {
                Console.WriteLine("Mail Gönder " +mail);
                Thread.Sleep(1000); // thread sleep bin ms 1 saniye 1 saniye arayla at demek
                
            }
        }
    }
}
