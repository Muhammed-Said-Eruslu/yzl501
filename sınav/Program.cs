// See https://aka.ms/new-console-template for more information

Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.ForegroundColor = ConsoleColor.Black;
#region Sınav1
/*string kullanıAdı;
string sifre;
bool girisBasarili = false; // false olarak başlar cunku daha giriş yapmadı

do
{
    Console.WriteLine("Kullanıcı Adı: ");
    kullanıAdı = Console.ReadLine();

    Console.WriteLine("Şifre: ");
    sifre = Console.ReadLine();

    if (kullanıAdı == "admin" && sifre == "123")
    {
        girisBasarili = true; // true olur ve döngüden çıkar
        Console.WriteLine("Giriş Başarılı,Hoş Geldiniz ");
    }
    else
    {
        Console.WriteLine("Hatalı giriş, tekrar deneyiniz.");
    }

} while (!girisBasarili); // ama girişBasarılı değişkeni false oldugu sürece donguye devam eder ve bidaha alır 

//Console.WriteLine("Giriş başarılı, hoş geldiniz!");

// kullanıcıdan bir sayi alınız girilen sayı tek ise tek cift ise cift yazsın
// girilen sayı değilse lütfen sayı gırınız yazsın ve tekrar giriş istensin goto ile

/*basaDön:
try
{
    Console.Write("Lütfen bir sayı giriniz: ");
    int sayi = int.Parse(Console.ReadLine());

    if (sayi % 2 == 0)
    {
        Console.WriteLine("Girilen Sayı Çifttir.");
    }
    else
    {
        Console.WriteLine("Girilen Sayı Tektir.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
    goto basaDön;
}
*/

/*basla:
try
{
    Console.WriteLine("Lütfen Bir Sayı Giriniz :");
    int sayı = int.Parse(Console.ReadLine());

    if (sayı % 2 == 0)
    {
        Console.WriteLine("Sayı Çifttir");
    }
    else
    {
        Console.WriteLine("Sayı Tektir");
    }
}
catch(FormatException)
{
    Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz");
    goto basla;
}*/

/*string kullanıcıAdı;
string sifre;
bool girisBasarılı = false;

do
{
    Console.WriteLine("Kullanıcı Adınızı Giriniz\a");
    kullanıcıAdı = Console.ReadLine();

    Console.WriteLine("Lüfen Şifrenizi Giriniz");
    sifre = Console.ReadLine();

    if (kullanıcıAdı == "admin" && sifre == "123")
    {
        girisBasarılı = true;
        Console.WriteLine("Giriş Başarılı,Hoş Geldiniz");
    }
    else
    {
        Console.WriteLine("Hatalı Giriş Tekrar Deneyiniz");
    }
} while (!girisBasarılı);*/

#endregion

string ad = null;
Console.WriteLine(ad ?? "Boş Değer");

