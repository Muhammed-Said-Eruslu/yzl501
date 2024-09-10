// See https://aka.ms/new-console-template for more information
// Do while tamamen while gibi çalışır aralarında kı tek fark while döngüsünün deyimi içerisnde ki
// kontrol döngüyü





// 1 den 100 e kadar olan sayılarının kuplerının toplamını bulan porgram

#region Örnek3
/*int i = 1;
int toplam = 0;

while (i <= 100)
{
    toplam = (int)Math.Pow(i, 3);
    i++;
}
Console.WriteLine(toplam);
*/

#endregion


#region Örne4

// dogum tarihi girilen kişinin yaşını hesaplayan program


/*bool kontr;
DateTime dt;

do
{
    Console.WriteLine("Dogum Tarihinizi Giriniz  :");
    kontr = DateTime.TryParse(Console.ReadLine(),out dt); // birinca parametrede ki değer date time donusuyosa dt ye gelen değeri atıyor gerıyede true olarak donuyoe
   
  
} while (!kontr);
Console.WriteLine($"Yaşınız {DateTime.Now.Year - dt.Year}");
*/
#endregion

#region Örnek5
// girilen sayının faktöriyel olup olmadıgını bulan program

/*Console.WriteLine("Sayı Giriniz");
ulong sayı = ulong.Parse(Console.ReadLine());
ulong faktoriyel = 1;
for (uint i = 1; i <= sayı; i++)
{
    faktoriyel *= i;*/

/*}
Console.WriteLine($"Faktöriyel {sayı = faktoriyel}");*/
#endregion


#region Örnek6
// çarpma işlemini toplama kullanarak bulan program
/*int toplam = 0;
bool he = false;
do
{
    Console.WriteLine("Çarpmak İstediğiniz sayıyı giriniz");
    int sayı = int.Parse(Console.ReadLine());
    int sayı2 = int.Parse(Console.ReadLine());

    for (int i = 1; i <= 3; i++)
    {
        toplam += sayı;
    }
    Console.WriteLine($"{toplam}");
} while (he);*/

#endregion

#region Örnek7
// bölme işlemini çıkarma işlemi yaparak çıkartın
/*
Console.WriteLine("Birinci Sayıyı Giriniz");
int sayı1 = int.Parse(Console.ReadLine());
Console.WriteLine("İkinci Sayıyı Giriniz");
int sayı2 = int.Parse(Console.ReadLine());
int sayac = 0;

if(sayı1 > 0)
{
    while (sayı1 > 0)
    {
        sayı1 -= sayı2;
        sayac++;
    }

}
else if(sayı2 > sayı1)
{
    sayı2 = int.Parse(Console.ReadLine());
    sayac--;
}
Console.WriteLine(sayac);*/
#endregion

#region Örnek8
// girilen sayının kaç basamaklı oldugunu bulan program
/*basadon:
try
{
    Console.WriteLine("Bir Sayı Giriniz");
    int sayı = int.Parse(Console.ReadLine());
    int basamak = 0;

    if (sayı == 0)
    {
        basamak = 1;

    }
    else
    {
        while (sayı != 0)
        {
            sayı /= 10;
            basamak++; // basamak sayısını bulmak için

        }
    }
    Console.WriteLine($"Basamak Sayısı {basamak}");
}
catch(FormatException)
{
    Console.WriteLine("Yanlış Sayı Girdiniz");
    goto basadon;
}*/
#endregion

#region Soru9
/*// 10 ile 1000 arasında kı tam kare sayıları ekrana yazdırın

for (int i = 4; i <= 100; i++)
{
    if(i*i <= 1000)
    {
        Console.WriteLine(i * i);
    }
    
    
}*/

#endregion

#region Soru10
// klavyden girilen 25 adet sayı içersinden negatif olanların toplamı ile çıft olanların çarpımını
// 7 ye eşit olanların adetinin bulup ekrana yazdıran program
using System.Runtime;

/*int toplamnegatif = 0;
int toplamcift = 1;
int sayaç = 1;
for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Sayı Giriniz");
    int sayı = int.Parse(Console.ReadLine());
    if(sayı < 0)
    {
        toplamnegatif += sayı;
        Console.WriteLine($"Negatif olanların Toplamı {toplamnegatif}");
    }
    if(sayı % 2 == 0)
    {
        toplamcift *= sayı;
        Console.WriteLine($"Çift  olanların Çarpımı {toplamcift}");
    }
    if(sayı == 7)
    {
        Console.WriteLine($"7 ye Eşit olanlar: {sayaç}");
        sayaç++;
    }

}*/
#endregion

#region Soru11
//Girilen sayının 5 in kuvveti olup olmadıgını bulan program

Console.WriteLine("Bir Sayı Giriniz");
int sayı = int.Parse(Console.ReadLine());
int kuvvet = 2;
int sonuc = sayı * kuvvet;

if(sonuc != 25)
{
    Console.WriteLine("5in kuveti değil");
}
#endregion