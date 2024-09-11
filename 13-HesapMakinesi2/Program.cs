// Hesap Makinesi

// Kullanıcı ile interaktivite

Console.WriteLine("Basit Bir C# Hesap Makinesi");
Console.WriteLine("İşlem Seçiniz (+) (-) (*) (/) Çıkmak İçin Boş Geçiniz");
int sayı1, sayı2;
sayı1 = sayı2 = 0;
double result = 0;

string mathOp = "+"; // değişkeni başlangıc değeri ile tanımladım
while (mathOp != string.Empty) // boş olmadıgı sürece
{
    try
    {
        Console.ResetColor();
        // metodun geri donusunden voıd yazıyorsa metot geriye bir değer döndürmez
        Console.Write("Sayı 1 Giriniz"); // write metodu parametreli bir metotdur
        sayı1 = Convert.ToInt32(Console.ReadLine()); // readline metodu parametresiz bir metotdur

        Console.WriteLine("İşlem: ");
        mathOp = Console.ReadLine();

        // kullanıcıdan ıkıncı sayıyı alıcaz
        Console.WriteLine("2. Sayıyı Giriniz :");
        sayı2 = int.Parse(Console.ReadLine());
    }

    catch
    {
        Console.WriteLine("İşlem Yapılamadı.");
        mathOp = string.Empty;
    }

    switch (mathOp)
    {
        case "+":
           result = sayı1 + sayı2;
            Console.WriteLine($"Toplam : {result}");
            break;

        case "-":
            result = sayı1 - sayı2;
            Console.WriteLine($"Çıkarma İşleminin Sonucu: {result}");
            break;

        case "*":
            result = sayı1 * sayı2;
            Console.WriteLine($"Çarpma İşleminin Sonucu: {result} ");
            break;

        case "/":
            try
            {
                result = sayı1 / sayı2;
            }
            catch(DivideByZeroException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Bölünme Hatası: {ex.Message}");
                break;
            }
            Console.ResetColor();
            Console.WriteLine($"Bölmenin Sonucu {sayı1 / sayı2}");
            break;

        default:
            Console.WriteLine("Geçerli Bir İşlem Giriniz.");
            break;
    }

}
