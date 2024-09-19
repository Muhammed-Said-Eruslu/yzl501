using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace _MetotOverLoading
{
    // Erşim Belirliyecisi : public,internal,protected,private
    internal class Program
    {
        // 
        static void Main(string[] args)
        {
            // Metot Overloading (Metot Aşırı Yükleme),Bir metodun adının aynı imzasının (parametrelerin) farklı oldugu bir cok kullanım gercekleştirebiliriz

           // EkranaYaz();
           // EkranaYaz(19);
           // EkranaYaz("Said");
           // EkranaYaz("Muhammed Said", "Eruslu");
            MailOlustur("said");
            MailOlustur("said", "eruslu");
            MailOlustur("said","eruslu","@gmail.com");
        }
        private static void EkranaYaz()
        {
            Console.WriteLine("");
        }
        static void EkranaYaz(int yas)
        {
            Console.WriteLine($"Merhaba Yaşınız {yas}");
        }
        private static void EkranaYaz(string ad)
        {
            Console.WriteLine($"Merhaba Adnız {ad}");
        }

        // ad ve soyadan alan versıyonunu
        static void EkranaYaz(string ad,string soyAd)
        {
            Console.WriteLine($"Adınız {ad} Soy Adınız {soyAd}");
        }

        // Mail oluştur ve icine bir isim @bilgeadam.com ile birleştirip
        // string tipinde geri döndürecek

        /// Mail oluştur ve icine bir isim ve soyısım @bilgeadam.com ile birleştirip
        // string tipinde geri döndürecek

        static string MailOlustur(string isim)
        {
            Console.WriteLine($"Mailiniz {isim}@bilgeadam.com");
            return isim;
        }
        static string MailOlustur(string isim,string soyİsim)
        {
            Console.WriteLine($"Mailiniz {isim+ soyİsim}@bilgeadam.com");
            return isim + soyİsim;
        }
        static string MailOlustur(string isim, string soyİsim,string domainID)
        {
            
            Console.WriteLine($"Mailiniz {isim + soyİsim+domainID}");
            return isim + soyİsim+ domainID;
        }

    }
}