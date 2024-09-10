// See https://aka.ms/new-console-template for more information
//While belirli bir koşul geçerli kaldıgı surece dongu talımatlar tekrar yurutulur

int a = 1;
/*while (a <= 10)
{
    Console.WriteLine(a);
}
*/

#region Örnek1

/*string durum = "yes";

while (durum != "no") // durum no ya eşit olmadıgı sürece döngüye girer
{
    Console.WriteLine("Döngü İçindesin");
    Console.WriteLine("Devam mı [no] [yes]");
    durum = Console.ReadLine();
}*/

#endregion


#region Örnek2

int i = 0, tek = 0, cift = 0;

while (i <= 100 ) 
{
    if(i % 2 == 0)
    {
        cift += i;
    }
    else
    {
        tek += i;
    }
}
Console.WriteLine($"Çift Sayıların Toplamı {cift}");
Console.WriteLine($"Tek Sayıların Toplamı {tek}");
Console.WriteLine($"Çift ve Tek Sayıların Toplamı {cift+tek}");


#endregion