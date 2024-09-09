// See https://aka.ms/new-console-template for more information

#region ForTanım
// Döngüler bir koşul dahilinde bir işlemi tekrarlı bir şekilde çalıştırmak amacıyla kullanılır
// For döngüsü, başlangıç ve bitisi aralaığı dahilinde tekrarlı işlemler yapar
/*
for(başlangıç değeri; koşul; değerde-değişiklik)
{
 // yapılacak işlemelr
}*/

/*for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
    
}*/
#endregion

#region Örnek1

/*for (int i = 2; i <= 1000; i = i + 2)
{
    Console.WriteLine(i);
}*/

/*or (char c = 'A'; c < 'z'; c++)
{
    Console.WriteLine($"{c}-{Convert.ToInt32(c)}"); //ascii
}

char adım = 'S'
for (char adım = 'S'; adım < length; adım++)
{

}*/
#endregion

#region Örnek2

/*int toplam = 0;
for (int i = 1; i <= 100; i++)
{
    toplam += i;
}
Console.WriteLine(toplam);*/

/*for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine(i * j+ "\t");
    }
}*/
#endregion

#region Örnek3
// 1-100 arasında ki cift sayıların toplamı ıle tek sayıların toplamı farklarının karesi kaçtır
/*int fark = 0;
int toplamTek = 0;
int toplamÇift = 0;
for (int i = 0; i <= 100; i = i + 2)
{
    toplamÇift += i;
}
for (int j = 1; j <= 100; j = j + 2)
{
    toplamTek += j;
}
fark = toplamTek - toplamÇift;
fark = fark * fark;
Console.WriteLine(fark);*/

#endregion

#region Örnek4
// 1945 gunümüze kadar ki yılları ekrana yazdırsın ama 1990 ve 1992 yılların kırmızı yazsın

/*for (int yıl = 1945; yıl <= DateTime.Now.Year; yıl++)
{
    if(yıl == 1990 || yıl == 1992)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        
    }
    else if(yıl <= 2024)
    {
        int fark = yıl - 1945;
        Console.WriteLine($"Arada ki fark:{fark}\t ");
    }
    else
    {
        Console.ResetColor();
    }
    Console.WriteLine(yıl);
}*/
#endregion

#region

// kullanıcıdan alınan 10 adet sayının toplmanı ekrana yazdıran program
/*int toplam = 0;
Console.WriteLine("10 adet sayı giriniz: ");
for (int i = 0; i < 10; i++)
{
    try
    {
        int sayı = int.Parse(Console.ReadLine());
        toplam += sayı;
    }
  catch(Exception)
    {
        i--;
    }
   
}
Console.WriteLine(toplam);*/
#endregion

#region Matris
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine(i * j + "\t");
    }
}

#endregion