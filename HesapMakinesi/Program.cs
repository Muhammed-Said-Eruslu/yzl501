// See https://aka.ms/new-console-template for more information
// Değişkenler-Öperatörler-TipDönüşümleri-KararYapıları
//iki sayı ve 1 işlem

Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz\nToplama\nÇıkarma\nBölme\nÇarpma\nModalma");

string islem = Console.ReadLine();

Console.WriteLine("Birinci Sayıyı Giriniz");
int sayı1 = int.Parse(Console.ReadLine());

Console.WriteLine("İkinci Sayıyı Giriniz");
int sayı2 = int.Parse(Console.ReadLine());

switch (islem)
{
    case "Toplama":
        Console.WriteLine($"Toplama Sonucu : {sayı1 + sayı2}");
        break;
    case "Çıkarma":
        Console.WriteLine($"Çıkarma Sonucu : {sayı1 - sayı2}");
        break;
    case "Bölme":
        Console.WriteLine($"Bölme Sonucu : {sayı1 / sayı2}");
        break;
    case "Çarpma":
        Console.WriteLine($"Çarpma Sonucu : {sayı1 * sayı2}");
        break;
    case "Modalma":
        Console.WriteLine($"Mod Sonucu : {sayı1 % sayı2}");
        break;
    default:
        Console.WriteLine("Geçersiz İşlem Seçimi");
        break;
}