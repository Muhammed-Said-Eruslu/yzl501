using System.Data.Common;
using System.Threading.Channels;

namespace _23_MetotKullanımı // Namespace tanımı
{
    // struct ya da class, interface , enum

    internal class Program // sınıf tanımladık namespace metot tanımlanmaz
    {
        static void Main(string[] args) // Metot tanımı // sınıf statıc olursa metodumuz da statıc olması lazım
        {
            #region Parametre
            //// Parametreli geri dönüşşüz metot
            //Console.WriteLine("Hello World!");

            //// Parametreli geri dönüşlü metot
            //int.Parse(Console.ReadLine());
            //// Parametresiz geri dönüşşüz metot

            //// Parametresiz geri dönüşlü metot
            //string metin = "";
            //metin.ToLower();
            // Static metodun nesnesi üretilmez
            /*
            // Parametreli Gerı Donussuz Metotlar
            string[] isimler = { "Said","Muhammed" };

            //Console Sınıfında
            Console.WriteLine("1");
            Console.SetBufferSize(120,30);
            Array.Sort(isimler);
            Array.Resize(isimler,4);
            Array.Copy(isimler);
            Array.Clear(isimler);
           

            // Parametresiz Geri Dönüssüz Metotlar
            
            //Console Sınıfında
            Console.Clear();
            Console.ResetColor();
            Console.Beep();
            Console.WriteLine();
            decimal d = -3;
  
            // Parametreli Geri Dönüşlü Metotlar

            //Math Sınıfının Altında
            Math.Pow(1,2);
            Math.Round(d);
            int.Parse(Console.ReadLine());
            Convert.ToInt32(true);
            


            // Parametresiz Geri Dönüşlü

            // Console Sınıfında
             Console.ReadLine();
             Console.Read();
             Console.ReadKey();*/
            #endregion
            //EkranaYazıYaz(); // private bir uyeye sadece kendi sinifı ıcınden ulaşabilirim // Metodu Çağırdık
            //Random random = new Random(); // Random sınıfı statıc değildir.Random sınıfının metodunu çağırmak için random sınıfından nesne üretmek gerekir
            //EkranaİsımYaz("Said",19); // parametreli geri dönüşsüz metot
            CıftTekSayı(90); // this keyword this.
        }
        #region Metot
        /*
         Metot Oluşturma
         // Erişim Belirleyici(public-private) Nitelyici
         // varsa (static) DonusTipi(void-string-int-double)
         // Metot Adı(Parametre(varsa))
        {
            Metot Çalıştığı zaman kod
        }
         
        // Metot Çağırma
        MetodAdı (Parametre(varsa))

        1-) Erişim Belirleyicisi (Access Modifer) : Metot'a kullanım yetkisi verme
        Privete : Bir metodu sadece bu sınıf içaresinde kullanılsın
        Public: Bu Metodu Herkes Kullansın

        2-) Niteliyici (static) : static anahtar kelimesini kısaca açıklamak gerekirse
        gerekirse oluşturduğumuz metodu bellekte sabit hale getitir

        3-) Dönüş Tipi: Metodun çalışması sonucu kendisinin bir bilgi verip vermeyeceğini
        belirlediğimiz yerdir eğer bir bilgi döndüreceksek int,string,double gibi değerler
        alacak.Geriye değer döndürmiyecekse void anahtar kelimesi yazılır

        4-) Metot İsmi: Metot çağırılırken kullanılacak isimdir


        
        */

        #endregion

        // Geri değer döndürmeyen parametresiz metot

        private static void EkranaYazıYaz() 
        {
            // Çalıştırılacak Kod
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Merhaba Dünya");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        
        // Geri değer döndürmeyen parametreli metot

        static void EkranaİsımYaz(string isim,int yas)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(isim);
            Console.WriteLine("Yas "+ yas);
            Console.ForegroundColor = ConsoleColor.White;
        }
        
       private static void CıftTekSayı(int sayı1)
        {
            int cıfToplam = 0;
            int tekToplam = 0;
            for(int i = 0; i <= sayı1; i++)
            {
                if(i % 2 == 0)
                {
                    cıfToplam += i;
                }
                else
                {
                    tekToplam += i;
                }
                
            }
            Console.WriteLine($"Çiftelrin Toplamı {cıfToplam}\nTeklerin Toplamı {tekToplam}");
        }

       
    }
}

