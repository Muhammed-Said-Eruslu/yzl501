// See https://aka.ms/new-console-template for more information
// Swich case if else ile neredeyse aynıdır
// arada ki fark if else büyüklük kücüklük durumlarını kontrol ederken
// swich case sadece eşitlik durumlarını kontrol eder
// kendisine ait bir indexleme mekanızması kullanılır

// Sözdizimi
// Swich(kosul)
// case "a" statement; break;
// case "b" statement; break;
// case "c" statement; break;
// default: statement; break;

#region Ornek1

// Dışarıdan bir mevsim giriniz aylar ekrana yazılsın

/*Console.WriteLine("Bir Mevsim Giriniz: ");
string mevsim = Console.ReadLine();

switch (mevsim)
{
    case "Kış":
        Console.WriteLine("Aralık-Ocak-Şubat");
        break;
    case "İlkbahar":
        Console.WriteLine("Mart-Nisan-Mayıs");
        break;
    case "Yaz":
        Console.WriteLine("Haziran-Temmuz-Ağustos");
        break;
    case "Sonbahar":
        Console.WriteLine("Eylül-Ekim-Kasım");
        break;
    default:
        Console.WriteLine("Böyle Bir Mevsim Yok");
        break;
}*/

// 1 [C#] 2 [VB] 3 [Java] 4 [Java]

/*Console.WriteLine("Bir Proglama Dili Seçiniz  C# VB Java C: ");
int dil = int.Parse(Console.ReadLine());

switch(dil)
{
    case 1:
    Console.WriteLine("Girdiğiniz Dil C# ' dır" );
    break;
     case 2:
    Console.WriteLine("Girdiğiniz Dil VB ' dır");
    break;
     case 3:
    Console.WriteLine("Girdiğiniz Dil Java ' dır");
    break;
     case 4:
    Console.WriteLine("Girdiğiniz Dil C ' dır");
    break;

    default:
    Console.WriteLine("Böyle Bir Dil Yok: ");
    break;
}*/

// /Eğer kullanici "Admin", "Yonetici", "CEO", "Başkan" ise
// "Yönetim paneline hoşgeldiniz.
//Eğer "uye" ise "Ana sayfaya hosgeldiniz
// hoşgeldiniz."
//Hiçbiri ise "Bu siteye giriş yetkiniz yok".

/*Console.WriteLine("Giriş Şeklinizi Giriniz (Yönetim/Üye) :");
string yönetim = Console.ReadLine();
string üye = Console.ReadLine();

switch(yönetim)
{
    case "Yönetim":
        Console.WriteLine("Yönetim Paneline Hoş Geldiniz :");
        break;
    default:
        Console.WriteLine("Yönetim girişi yapılamadı.");
        break;
}

switch(üye)
{
    case "Üye":
        Console.WriteLine("Anasayfaya Hoş Geldiniz");
        break;
    default:
        Console.WriteLine("Bu siteye giriş izniniz yok");
        break;
}*/

////Kullanicidan not isteyin A-B-C-D-E-F, A,B,C girerse
// "Geçtiniz", D girerse ortalama ile geçtiniz, E,F girerse kaldınız. yazdıran program.


Console.WriteLine("Notunuzu Giriniz A/B/C/D/E/F");
string geçtiniz = Console.ReadLine();
string ortalama = Console.ReadLine();
string kaldınız = Console.ReadLine();

switch(geçtiniz)
{
    case "A":
    Console.WriteLine("Ortlamanız A");
    break;
    case "B":
    Console.WriteLine("Ortlamanız B");
    break;
    case "C":
    Console.WriteLine("Ortlamanız C");
    break;
}
switch(ortalama)
{
    case "D":
    Console.WriteLine("Ortlama ile geçtiniz ortalamanız D");
    break;
}
switch(kaldınız)
{
    case "F":
    Console.WriteLine("Kaldınız ortalamanız F");
    break;
    case "E":
    Console.WriteLine("Kaldınız ortalamanız E");
    break;
}

#endregion