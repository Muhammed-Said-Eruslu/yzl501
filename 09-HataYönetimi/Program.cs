
// See https://aka.ms/new-console-template for more information

// istisna tipleri 
// -1 Derleme zamanı (Compile Exception) genellikle sybtax kaynaklı 
// yazılımsal hatalar hatadır hata meydana geldiği zaman vs bilgi ver

// -2 Çalışma Zamanı (Runtime Exception): Coğunlukla kullanacı kaynaklı
// (verinin yanlış veya eksık girilmesi) gibi
// çözümü Try-Cache mekanızması

// -3 Mantıksal Hatalar: Yüzde yüz yazılımcı kaynaklı halardır.Uygulamanın
// algoritmasından kaynaklanır çözülmesi en zor hata tipidir 
// try
//{
// çalısmasını istediğim kodları buraya yazarım
// }
// catch{
// try içerisnde ki kodlar çalıştığında bir hata oluşursa 
// burada ki kodlar çalışır
// }

#region Örnek1

/*try
{
    Console.WriteLine("Telefon Numarası Giriniz: ");
    int telefonNo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Tebrikler Doğru Telefon Numarısı Giridiniz");
}
catch
{
    Console.WriteLine("Telefon Numarası yazmayi bile beceremedin");
}*/

#endregion

#region Örnek2

/*try
{
    Console.WriteLine("Telefon Numarası Giriniz: ");
    int telefonNo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Tebrikler Doğru Telefon Numarısı Giridiniz");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
*/
#endregion

#region Örnek3

/*string gelenDeger = null;
try
{
    Console.WriteLine("Telefon Numarası: (XXX-XXX-XX-XX)");
    gelenDeger = Console.ReadLine();
    throw new Exception(" Doğru Formatta Girmedin"); // bilinçli bir şekilde hata fırlatma
    Console.WriteLine("Tebrikler!");
}
catch (Exception hata)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Error{hata.Message}");
    Console.ForegroundColor = ConsoleColor.White;
    
}
finally // her durumda çalışır hata olsa da olmasa da çalışmasını istediğimiz kodları yazdığımız alan
{
    Console.WriteLine("Hata var mı? yok mu? beni ilgilendirmez ben işimi yaparım");
}*/
#endregion Örnek4

#region

try
{
    Console.WriteLine("Telefon Numarası : ");
    int telefonNo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Tebrikler Doğru Telefon Numarası Giridiniz. ");
}
catch (FormatException ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message); // format hata tipi string to int hatası 
    Console.ForegroundColor = ConsoleColor.White;
}
catch(OverflowException ex) // veri tipinin boyutunu aşması durumunda hata tipi
{
    Console.WriteLine($"Çok uzun sayı girdin{ex.Message}"); 
}
catch(DivideByZeroException ex) // bölme hata mesajı
{
    Console.WriteLine($"{ex.Message}"); // exceptiıon cok onemli
}
catch(Exception ex)
{
    Console.WriteLine($"{ex.Message}"); 
}

#endregion