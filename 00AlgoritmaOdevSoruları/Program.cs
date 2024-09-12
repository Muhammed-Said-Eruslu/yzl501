/*int sayı = 0;
int sayı2 = 1;
int sonrakıSayı;

for (int i = 3; i <= 10; i++)
{
    sonrakıSayı = sayı + sayı2;
    Console.WriteLine(sonrakıSayı);
    sayı = sayı2;
    sayı2 = sonrakıSayı;
}*/

/*int toplam = 0;

int bolenToplamı = 0;
for (int i = 0; i <= 100; i = i+2)
{
    toplam += i;
}
int sayı = toplam;
for (int j = 1; j < sayı / 2; j++)
{
    if (sayı % 2 == 0)
    {
     
        bolenToplamı += j;
    }
     if(bolenToplamı == sayı)
    {
        Console.WriteLine($"Mükemmel Sayıdr {sayı} ");
    }
     else
    {
        Console.WriteLine("Mükemmel Sayı Değildir");
    }
}*/

/*Console.WriteLine("Bir Binary Sayı Giriniz");
int decImal = int.Parse(Console.ReadLine());



while (decImal > 0)
{
    int digit = decImal % 10; 
    Console.WriteLine(digit);
    decImal /= 10; 
}
if(decImal == 0 )
{

}*/

/*Console.WriteLine("Kılonuzu giriniz");
double kılo = double.Parse(Console.ReadLine());
Console.WriteLine("Boyuunuzu Giriniz");
double boy = double.Parse(Console.ReadLine());

double vki = kılo / boy;

if(vki < 18.5)
{
    Console.WriteLine("Zayıf");
}
else if(vki >= 18.5 && vki < 24.9 )
{
    Console.WriteLine("Normal Kilolu");
}
else if(vki >= 30 && vki < 34.9)
{
    Console.WriteLine("Obez");
}
else if(vki > 34.9)
{
    Console.WriteLine("Yeme Kardeşim artık git zayıfla");
}*/

// Dairenin alanını ve cevrisni

/*basaDon:
try
{
    Console.WriteLine("Yarı Çapı Giriniz");
    double yarıçapı = int.Parse(Console.ReadLine());
    double alan = Math.PI * Math.Pow(yarıçapı, 2);
    double çevresi = Math.PI * 2 * yarıçapı;
    Console.WriteLine($"Alanı: {alan} Çevrei{çevresi}");
}
catch
{
    goto basaDon;
}*/

// kenarları a b c d olan bir dıktorgenin kare olup olmadıgını bulan program


/*Console.WriteLine("A kenarını giriniz");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("B kenarını giriniz");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("C kenarını giriniz");
int c = int.Parse(Console.ReadLine());
Console.WriteLine("D kenarını giriniz");
int d = int.Parse(Console.ReadLine());

if(a == b && c == d)
{
    Console.WriteLine("Karedir");
}
else
{
    Console.WriteLine("Değildir");
}*/
/*
try
{
basaDon:
    
    int sayı = 31;
    Console.WriteLine("Sayı Bulmaca Bir Sayı Giriniz");
    int girilenSayı = int.Parse(Console.ReadLine());

    for (int kalanHak = 10; kalanHak <= 0; kalanHak--)
    {
        if (girilenSayı == sayı)
        {
            Console.WriteLine("Doğru tahmin ettiniz");
        }
        else if (girilenSayı != sayı)
        {
            Console.WriteLine("Yanlış Girdiniz");
            kalanHak++;
            goto basaDon;
        }
    }
}
catch
{

}
*/
using System.Net.NetworkInformation;
/*basaDon:
int kalanhak = 2;
kalanhak--;


int sayı = 31;
Console.WriteLine("Sayı Bulmaca Bir Sayı Giriniz");
int girilenSayı = int.Parse(Console.ReadLine());

if (girilenSayı == sayı)
{
    Console.WriteLine("Dogru Tahmin Ettiniz");
}

if (kalanhak != 0)
{
        if (girilenSayı != sayı)
        {
            goto basaDon;
        }  
}*/




for (int i = 0; i < 3; i++)
{
    int sayı = 31;
    Console.WriteLine("Sayı Bulmaca Bir Sayı Giriniz");
    int girilenSayı = int.Parse(Console.ReadLine());
    if (girilenSayı == sayı)
    {
        Console.WriteLine("Dogru Tahmin");
        break;
    }
    else if (girilenSayı != sayı)
    {
        Console.WriteLine("Yanlış Tahmin");
    }
}