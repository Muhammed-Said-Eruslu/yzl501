using System;
using System.Collections.Immutable;
using System.Threading.Channels;

namespace MetotÖrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // iki sayıyı alıp ve bu sayıları çarparak ve kareköünü geri döndüren metodun bulundugu uygulamayı yazınız

            /*int toplam = Toplam(3, 3);
            Console.WriteLine(KareKök(toplam));
            */
            // Bir metot yazın parametre olarak bir sayı dizisi alsın ve bu dizideki en büyük sayıyı döndürsün

            /*int[] sayılar = { 3, 45, 5, 35634, 324234, 4, 23 };
           int en = Dizii(sayılar);
            Console.WriteLine(en);*/
            // Bir metot yazın parametere olarak bir cümle ve bir harf alsın Bu cümledeki belirtilen harfin kaç kez geçildiğini döndürsün


           int kaç =  Cumle("Saaaaid",'a');
            Console.WriteLine(kaç);



        }
        static int Toplam(int sayı1, int sayı2)
        {
            int toplam = 0;
            return toplam = sayı1 * sayı1;
        }
        static double KareKök(double kök)
        {
            kök = Math.Sqrt(kök);
            return kök;

        }

        static int Dizii(int[] say)
        {
            Array.Sort(say);
            return say[say.Length - 1];

        }
         static int Cumle(string isim, char c)
        {
            int sayac = 0;
            foreach (char i in isim)
            {
                if (i == c)
                {
                    sayac++;
                }
                
            }
            return sayac;

        }

    }
}



// iki sayıyı alıp ve bu sayıları çarparak ve kareköünü geri döndüren metodun bulundugu uygulamayı yazınız

// Bir metot yazın parametre olarak bir sayı dizisi alsın ve bu dizideki en büyük sayıyı döndürsün

// Bir metot yazın parametere olarak bir cümle ve bir harf alsın Bu cümledeki belirtilen harfin kaç kez geçildiğini döndürsün

// Bir metot yazın parametre olarak bir sayi dizisi alsın Bu dizide ki tek sayıları yeni bir diziye aktarıp döndürsün

// Bir metot yazın parametere olarak bir sayi alsın bu sayının faktoriyelini döndürsün

// Bir metot yazın parametere olarak bir string alıp bu stringin palindrom olup olmadıgını kontrol etsin polindrom terseten okunusu radar

// Bir metot yazın parametre olarak bir sayi dizisi alsın ve bu dızının ortalamasını  alsın

// Bir metot yazın parametre olarak bir sayı alıp o sayıya kadar olan fıbonaccı dizisini döndürsün

// bir metot yazın parametre olarak bir sayıyı alıp bu sayının asal olup olmadıgını döndürsün