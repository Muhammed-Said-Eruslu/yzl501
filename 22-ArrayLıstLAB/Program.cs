// İçeriğini sizin karar vereceğiniz bir sayıysal dizi olsuturun ve bu dızın en kucuk ve en büyük elemanını yazdırın

/*int[] sayılar = { 1, 34, 354, 674, 423, 12315, 63532, 423 };

Array.Sort(sayılar);
Console.WriteLine($"En Küçük Sayı {sayılar[0]}");
Console.WriteLine($"En Küçük Sayı: {sayılar[7]}");

*/
// Kullanıcı Öğrenci Adı doğum tarıhı final notu girecek
// dizinin kaç oğrenci gireceği başlangıçta belli değil 
// ilgili verilerine göre bu üç veriyi her öğrenci için
// tutacağınız ve en son ekrana yazacağınız uygulama

string[] ogrencıAdı = new string[1];
DateTime[] dogumTarihi = new DateTime[1];
int[] finalNotu = new int[1];

Console.WriteLine("Adınızı Giriniz");

ogrencıAdı[0] = Console.ReadLine();

Console.WriteLine("Doğum Tarihinizi Giriniz");
dogumTarihi[0] = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Final Notunu Giriniz");
finalNotu[0] = int.Parse(Console.ReadLine());

Console.WriteLine("Ekstra Bilgi Eklemek İster misin");
string secim = Console.ReadLine();
if(secim == "Y")
{
    while(true)
    {
        Array.Resize(ref ogrencıAdı, ogrencıAdı.Length + 1);
        Array.Resize(ref dogumTarihi, dogumTarihi.Length + 1);
        Array.Resize(ref finalNotu, finalNotu.Length + 1);

        Console.WriteLine("Yeni Adınızı Giriniz");
        ogrencıAdı[ogrencıAdı.Length - 1] = Console.ReadLine();

        Console.WriteLine("Yeni Doğum Tarihinizi Giriniz");
        dogumTarihi[dogumTarihi.Length - 1] = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Yeni Final Notunu Giriniz");
        finalNotu[finalNotu.Length - 1] = int.Parse(Console.ReadLine());
        Console.WriteLine("Bitirmek İstersen N bas");
        string secım2 = Console.ReadLine();
        if(secım2 == "N")
        {
            break;
        }
    }
}

foreach (var item in ogrencıAdı)
{
    Console.WriteLine($"Öğrenci Adınız {item}");
}
foreach (var item in dogumTarihi)
{
    Console.WriteLine($"Doğum Tarihiniz {item}");
}
foreach (var item in finalNotu)
{
    Console.WriteLine($"Final Notunuz {item}");
}