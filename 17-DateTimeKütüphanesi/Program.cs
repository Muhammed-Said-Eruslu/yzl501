// DateTime => Tarih ve zamanla ilgili yapabileceğimiz tüm işlemleri ve tüm /*verileri bize teslim eden nesnemiz
/*
// Günün tarih ve saatini almak için kullanılır
Console.WriteLine(DateTime.Now);

// Günün tarihini uzun şekilde sunar
Console.WriteLine(DateTime.Now.ToLongDateString());

// Günün tarihini kısa şekilde sunar
Console.WriteLine(DateTime.Now.ToShortDateString());

// Günün tarihini uzun şekilde sunar
Console.WriteLine(DateTime.Now.ToLongTimeString());

// Günün tarihini kısa şekilde sunar
Console.WriteLine(DateTime.Now.ToShortTimeString());

// Gün
Console.WriteLine($"Gün : {DateTime.Now.Day}"); // Günü verir

// Ay
Console.WriteLine($"Ay : {DateTime.Now.Month}"); // Ay verir

// Yıl
Console.WriteLine($"Yıl : {DateTime.Now.Year}"); // Yılı verir

// Haftanın Günü
Console.WriteLine($"Haftanın Günü : {DateTime.Now.DayOfWeek}"); // Haftanın gününü verir


// Yılın Gününü verir
Console.WriteLine($"Yılın Gününü Verir : {DateTime.Now.DayOfYear}"); // Yılın Gününü verir

// Artık Yılı Verir
Console.WriteLine($"Artık Yılmı : {DateTime.IsLeapYear(DateTime.Now.Year)}"); // Artık Yılı Verir


Console.WriteLine(DateTime.IsLeapYear(2024) ? "Şubat 29 Çeker" : "Şubat 28 Çeker");

// Tarih Oluşturma
DateTime tarih = new DateTime(1886,7,8);

DateTime tarih2 = new DateTime(2005,9,3);
Console.WriteLine($"Doğum Tarihi: {tarih2}");

DateTime tarih3 = new DateTime(1987,03,31,22,30,00); // Tarih formatında yeni bir format oluşturduk
Console.WriteLine($"Doğum Tarihi: {tarih3}");

TimeSpan zamanFarkı = tarih3 - tarih;

Console.WriteLine(zamanFarkı.TotalHours); // saat farkını verir
*/
// kullanıcının dogum tarihini alan gg aa yyyy ve bu tarihi kullanarak kaç yaşında hesaplayan programı yazınız

using System.Runtime.CompilerServices;

bool sonuc = false;
basaDon:
try
{
    Console.ResetColor();
    Console.WriteLine("Doğum Tarihi Giriniz");
    DateTime hesap = DateTime.Parse(Console.ReadLine());
    Console.WriteLine(DateTime.Now.Year - hesap.Year);
    sonuc = true;
    
    
}
catch
{

}
int kalanHak = 3;
for (int i = 0; i < kalanHak;)
{
    if (sonuc != true)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Yanlış Format");
        i++;
        goto basaDon;
        
    }
    else if(i == 3)
    {
        Console.WriteLine("Hakkın Kalmadı");
    }
    
}




/*bool sonuc;
DateTime dt;

do
{

    Console.WriteLine("Lütfen Bir Tarih Giriniz");

    sonuc = DateTime.TryParse(Console.ReadLine(),out dt);


} while (!sonuc);
Console.WriteLine($"Year : {dt.Year}\nAy");*/

;





