// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;
Console.WriteLine("Hello, World!");
// Değişkenler , kendisine atadığımız değerleri daha sonra kullanmak üzere saklayan veri tutucudur
// değişken tanımlama : DeğişkenTipi DeğişkenAdı = Değer;
int ilkSayım;// ilk sayım isminde bir değişken tanımladım bu değişken int tipindedir
ilkSayım = 24;  // ilk sayıma 24 değerini atadım kodda atamalar sağdan sola doğru olur
int ikinciSayım = 34; // ikinci sayım ısmındekı değişkene 34 değerini atadım ikinci sayım artık 34.Assign
// Variable , Data Type , Declatatıon , Assign
// dedğişken isimlerını camel Case olarak yazıyoruz. Değişken ismi bosluklarla yazılmaz . Bitişik olarak yazılır
// anlamlı sonradan anlıya bileceğin sekılde atanır
string metin1, metin2, metin3; // Aynı tipdeki değişkenlerı yan yana vırgulerle ayırara tanımlayabılırız.
string ad = "Said\0 " , soyad = "Eruslu\n";
/*
  1- Kesinlikle kullanmayacagımız değişkenlerı tanımlamayınız
  2- Değer aralıklarına gore uygun veri tipi secmeye ozen gosteriniz.
  3- İsimlendirme kurallarına dıkkat edin.Clean Code
 */
//string 0_ad; // değişken isimleri rakamla baslayamaz
// stirng -ad; // değişken isimlerı ozel karakterlerle baslayamaz
string _ad, ad_2; // alttan tre kullana bılırız // string ad Soyad ; arada bosluk bırakamam 
// Tam sayı Veri Tipleri
sbyte degiskensByte = 100; // Min:128 - Max: 127
byte degiskenByte = 45; // Min 0 - Max:255 2^8 // short , ushort, int, uint
short degiskenShort = -12312; // min: -32768 - max:32767
ushort degiskenUShort = 2343; // min:0 - max = 65535 2^16
int degiskenİnt = 12344; // min:-2147483648    max: 2147483647
uint degiskenUint = 324234; // min:0 max:4.2 Milyar 2^32
long degiskenLong = -12313124; // Min: -9.2 Katrilyon Max:9.2 Katrilyon
ulong degiskenULong = 4242342; // Min:0 Max:18.4 Katrilyon
double degiskenDouble = 10.95; // .dan sonra 14 hane desteği verir  8 bayt
float degiskenFloat = 10.95555555555f; // .dan sonra 7 hane alabılır 4 bayt f kullanmamız gerekir
decimal degiskenDecimal = 2.43434M; // noktadan sonra 28 hane desteği verir 16 bayt buyuk M kullanırız
                           // Metinsel Veri Tipi
               // char => üzerinde tek bir karakter tasıya bılır
char basHarfim = 'S';
                // String => ansiklopedik verileri tutar
string uzunMetin = "Muhammed Said Eruslu";
string bosMetin = "";
string ciftTırnaklıMesaj = "Benim Adım:";
string tersSlashIsareti = "Bilge\\Adam"; // \ kaçıs dizesi
string ikıSatırlıMetin = "Burası benim birinci satırm \n\t Burası benim ikinci satırım";
Console.WriteLine(ikıSatırlıMetin);
                // Mantıksal Veri Tipi
bool bugunTatılMı = false;
bool bugunGuzelGıdıyorMu = true;
bool buyukMu = 10 > 2;

/*int a = 0;
while (a < 10)
{
    a++;
    Console.WriteLine(a);
}

int b = 10;
while (b > 0)
{
    b--;
    Console.WriteLine(b);
}

string karakter = "Said";
char[] karakter1 = { 'S', 'A', 'I', 'D' };


Console.WriteLine(new string(karakter1));


Console.WriteLine(karakter);

Console.WriteLine("İsminizi giriniz:");
string isim = Console.ReadLine();


Console.WriteLine("İsminiz: {0}", isim);
int c = 30;
Console.WriteLine("1 ile 100 arasında sayı tahmini yapınız");
string input = Console.ReadLine(); 
int tahmin;

if (int.TryParse(input, out tahmin)) 
{
    if (tahmin == c)
    {
        Console.WriteLine("Doğru tahmin ettiniz!");
    }
    else
    {
        Console.WriteLine("Yanlış tahmin ettiniz. Doğru sayı {0}.", c);
    }
}
else
{
    Console.WriteLine("Geçerli bir sayı giriniz.");
}
*/

/*{
   
    Console.Write("Boyunuzu metre cinsinden girin (örn. 1.75): ");
    double boy = Convert.ToDouble(Console.ReadLine()); // ınput

    Console.Write("Kilonuzu kilogram cinsinden girin (örn. 70): ");
    double kilo = Convert.ToDouble(Console.ReadLine()); // neden cevirm yapıyorz ınput değerleri default olarak strıg tutulur

    
    double bmi = kilo / (boy * boy);

    
    Console.WriteLine("Vücut Kitle İndeksiniz: " + bmi);

    
    if (bmi < 18.5)
    {
        Console.WriteLine("Zayıf.");
    }
    else if (bmi >= 18.5 && bmi < 24.9)
    {
        Console.WriteLine("Normal kilolu.");
    }
    else if (bmi >= 25 && bmi < 29.9)
    {
        Console.WriteLine("Fazla kilolu.");
    }
    else
    {
        Console.WriteLine("Obez.");
    }
}*/

Console.Write("Kullanıcı Adınızı girin: ");
string kullanıcıAdı = Console.ReadLine();
Console.Write("Kullanıcı Adınız: ");
Console.Write(kullanıcıAdı);

Console.Write("Şifrenizi Giriniz: ");
string sifre = Console.ReadLine();
Console.Write("Şifrenizi Giriniz: ");
Console.Write(sifre);