
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

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


           /*int kaç =  Cumle("Saaaaid",'a');
            Console.WriteLine(kaç);*/
            // Bir metot yazın parametre olarak bir sayi dizisi alsın Bu dizide ki tek sayıları yeni bir diziye aktarıp döndürsün
           /*int[] sayılar = { 1, 24, 24, 235, 3252, 6, 2, 31, 49, 57 };
        int[] teksayılar = Tek(sayılar);

        foreach (var i in teksayılar)
        {
            Console.WriteLine(i);
        }*/
        // Bir metot yazın parametere olarak bir sayi alsın bu sayının faktoriyelini döndürsün
            /*int i = 3;
            long fak = Faktöriyel(i);
            Console.WriteLine(fak);*/

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
            Array.Sort(say); // diziyi kucukten buyuge sıralıyorum
            return say[say.Length - 1]; // mantıken sonunucu index en büyük sayı olur ondan dolayı sonuncu indexi alıyorum

        }
         static int Cumle(string isim, char c)
        {
            int sayac = 0;
            foreach (char i in isim) // isim arrayinin içinde teker teker dolaşır
            {
                if (i == c) // metodu cagırırken ıkı parametre gireim birinci parametre isim ikinci paramatre ismin icinde aradağım harf
                // ismin içinde ki harf c de gecıyosa donguye girip sayacı arttırır
                {
                    sayac++;
                }
                
            }
            return sayac; // en son kaç tane oldugunu bulup geri döner

        }

        static int[] Tek(int[] sayı)
        {
            int[] yeniDizi = new int[sayı.Length]; // yeni dizimize sayının boyutunu verıyoruz
            int tekSayı = 0; // tek sayı sayacı

            foreach(var i in sayı) // foreach ıle sayıyı gezeriz
            {
                if(i % 2 == 1) // eğer tekse
                {
                    yeniDizi[tekSayı] = i; // i yi yeni dizide ki tek sayıya ata
                    tekSayı++; // tek sayıyısını her seferinde arttır
                }
            }
            int[] tekSayılar = new int[tekSayı]; // yeni bir dizi olusturuyoruz yeni dizimiz tek sayısına eşit
            Array.Copy(yeniDizi,tekSayılar,tekSayı); // yeni dizi tek sayıların kaynağı , tekSayılar hedef yani yenidiziyi tekSayılara kopyalarız ve uzunlugu tek sayı kadardır
            return tekSayılar;
            
        }

        static long Faktöriyel (int sayı)
        {
           long faktöriyel = 1; // 1 den baslıyoruz zaten 0! sonucu 1

           if(sayı == 0)
           {
            Console.WriteLine("0 faktoriyelin sonucu Birdir");
           }
           else if(sayı > 0)
           {
            for(int i = 1; i <= sayı; i++) // i elemanım girdiğim sayı kadar donucek
           {
            faktöriyel *= i; // diyelim i 3 her döngüde faktroiyele sonucları atar  // faktöriyel = i*1 // 1*1=1 faktöryiele atadaı sonrakı dongude i 2 oldu 
            // 2*2 = 4 sonra // 3*3 = 6 faktireyel i nin son değerini çarpıp aldı ve geri döndü
           } 
            Console.Write("Faktöriyelin Sonucu ");
           }
           return faktöriyel;
        
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

