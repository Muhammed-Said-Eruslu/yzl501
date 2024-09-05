// See https://aka.ms/new-console-template for more information
// regiıon ctrl + K + S
// FormatException

#region YorumSatırları
// boxing ve Unboxıng nedir
// 1- Bilinçsiz Tip Dönüşümü (Implicit Conversion)
// Düşük kapasiteli bir değişkenin yüksek kapasiteli bir değişkene herhangi bir işlem gerektirmeden atabilmek
//String interpolasyonu, C#'ta bir string içerisinde değişkenlerin veya ifadelerin 
// değerlerini doğrudan yerleştirmenin modern ve daha okunabilir bir yoludur.
// Interpolasyon, $ sembolü kullanılarak yapılır ve süslü parantezler {} içine
// yerleştirilen ifadeler otomatik olarak string içerisinde değerlendirilir.
// Boxing, performans açısından maliyetlidir çünkü değer tipi "heap" belleğine taşınır ve referans tipi haline gelir.
// Unboxing, boxing işleminin tersi olup, referans tipini tekrar değer tipine dönüştürmeyi içerir ve explicit (açık) olarak yapılmalıdır.
// Boxing, bir değer türünün (örneğin int, float, bool gibi) referans türüne (genellikle object türüne) dönüştürülmesidir.
//  int x = 123; object obj = x;  // Boxing
//Unboxing, kutulanan bir değerin referans türünden tekrar değer türüne dönüştürülmesidir. 
// object obj = 123;  // Boxing
// int y = (int)obj;  // Unboxing

// string metin = 5;
#endregion
#region ImEx
/*using System.Globalization;

short degisken1 = 12313;
int degisken2 = degisken1; // (Implicit Conversion)
Console.WriteLine("Short Değişken: {0}, int Değişkeni: {1}", degisken1, degisken2);
// string İnterpolatıon
// 2- Bilincli Tip Döşümü (Explict Conversıon)
// Bilinçli tür dönüşümü genellıkle derleyecinin izin vermediği durumlarda kulllanılır.
// Büyük değişkeni kğçğk değişkeme döndürdügümüz zaman .NET veri kaybı olma ihtimaline
// ihtimaline karşı izin vermez

degisken1 = (short)degisken2; // short tipinde gönderdik
int değişken3 = 12345546;
short değişken4 = (short)değişken3;

Console.WriteLine($"Short Değişkeni : {0}, İnt Değişkeni: {1}");
Console.WriteLine($"Short Değişkeni : {değişken4}, İnt Değişkeni: {değişken3}");

int degısken5 = 89;
int degisken6 = 77;
Console.WriteLine($"{degısken5} \n {degisken6}\t");
*/
#endregion

#region ConvertSınıfı
// ConverSınıfı
// Bir veri tipinde değişkeni bir veri tipine cevirmke için ihtiyacımız olan yardımcı sınıfıtır

/*string deger = "123";
int cevrilmisBir = Convert.ToInt32(deger);

byte cevrilmisİiki = Convert.ToByte(deger);
short cevrilmisUc = Convert.ToInt16(deger);
long cevrilmisDort = Convert.ToInt64(deger);

float cevrilmişBeş = Convert.ToSingle(deger);
double deger2 = 10.5;
int cevirİki = Convert.ToInt32(deger2);
Console.WriteLine(cevirİki);
*/

#endregion

#region PasMetodu
// Convert sınıfına benzer yanlızca gelen verinin string olması zorunludur
// convert işleyebilir ama parse exeptıon alır
/*string parseSayı = "20.5";
double parseDouble= double.Parse(parseSayı);
int parseSayı1 =int.Parse(parseSayı);
Console.WriteLine(parseSayı1);*/

/*Console.WriteLine("Adınızı ve Soy Adınız Giriniz:");
string adı = Console.ReadLine();

Console.WriteLine("Boyunuzu Giriniz: ");
float boy = float.Parse(Console.ReadLine());

Console.WriteLine("Yasınız: ");
int yas = int.Parse(Console.ReadLine());

Console.WriteLine("Robot Musun? True,False");
bool robotmu = bool.Parse(Console.ReadLine());
Console.WriteLine($"Adım Ve Soy Adım: {adı} Yasım: {yas}  Boyunuz: {boy} Robot mu: {robotmu}");
*/
#endregion

#region ToString
// Tüm değişkenleri string çevirme

/*int sayıA = 121323;
string SayıB = sayıA.ToString();
*/

#endregion
#region IfElse
// Karar yapıları (If - Else) : Programın belirli bir koşulun karşılanıp karşılanmadığı degerlendirmesi sonucunda bir karar vermesi ve o kara uygun haraket etmesidir

// 1- Belirli bir durumun gerçekleşme durumu
/*if (true)
{
    // Koşul gerçekleşiyorsa burada ki kodlar calışır 
}*/

// 2- Belirli bır durumun karşılanıp karşılanmadıgı durum
/*
 if(true)
{
     // Koşul gerçekleşiyorsa burada ki kodlar calışır 
}
else 
{
    //Koşul gerçekleşmiyorsa burada kı kodlar çalışır
}
 */
// 3- Birden fazla karar vermesi gerektiği durum olursa
/*
 if(true) // Koşul -1
 {

 }
else if(true) // Koşul -2
{

}
else if(true) // Koşul -3
{

}
else if(true) // Koşul -4
{

}
else
{

}
 */

/*Console.WriteLine("Not Giriniz: ");
Console.ReadLine();
int not1 = 75;
int not2 = 55;
int ortalama = (not1 + not2) / 2;

if (ortalama > 50)
{
    Console.WriteLine("Geçerli Not: ");
}
else
{
    Console.WriteLine("Kaldınız: ");
}
*/



/*Console.WriteLine("Haftanın Günlerini Öğrenmek İçin 1 - 7 arasınd sayı giriniz");
int gun = Convert.ToInt32(Console.ReadLine());

if(gun == 1)
{
    Console.WriteLine("Pazar");
}
else if(gun == 2)
{
    Console.WriteLine("Pazartesi");
}
else if(gun == 3)
{
    Console.WriteLine("Salı");
}
else if(gun == 4)
{
    Console.WriteLine("Çarşamba");
}
else if(gun == 5)
{
    Console.WriteLine("Perşembe");
}
else if(gun == 6)
{
    Console.WriteLine("Cuma");
}
else if(gun == 7)
{
    Console.WriteLine("Cumartesi");
}
else
{
    Console.WriteLine("Lüften Geçerli Sayı Giriniz");
}
*/

string[] gunler = { "Lütfen 1 ile 7 arasında sayı giriniz ,Pazar,Pazartesi,Salı,Çarşamba,Perşembe,Cuma,Cumartesi,Pazar" };
Console.ReadLine();
int gun = 7;

if(gun <= 1 && gun <= 7)
{
    Console.WriteLine("Günler "[gun]);
}
else
{
    Console.WriteLine("Günler"[0]);
}
#endregion