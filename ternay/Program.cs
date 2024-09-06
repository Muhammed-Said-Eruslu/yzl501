// sozdizimi  kosul true false

/*int sayı1;

if(3> 2)
{
    sayı1 = 10;
}
else
{
    sayı1 = 5;
}
*/

//int sayı = (3 < 2) ?  10 : 5;

// Eğer kullanıcı değer girdiyse consolda göster gırmediyse default yaz

//Console.WriteLine("Kullanıcı Adı: ");
//string userName = Console.ReadLine();

//string result = userName.Length >  0 ? userName:"default";
//Console.WriteLine(result);
 
 // dışarıdan bır sayı alınca tekse tek cıftse cıft yazsın

/*Console.WriteLine("Bir sayı giriniz: ")

int girilenSayı = int.Parse(Consele.ReadLine);

string sonuc = (girilenSayı % 2 == 0 ) ? "Çift" : "Tek";
Console.WriteLine($"Girilen sayı sonuc {sonuc} ' dur");
*/
// Kullanıcıdan ıkı sayı alınız hangı sayı buyukse ekrana onu yazdırınız

 //Console.WriteLine("Birinci Sayıyı Giriniz:");
/*        int girilenSayı = int.Parse(Console.ReadLine());

        Console.WriteLine("İkinci Sayıyı Giriniz:");
        int girilenSayı2 = int.Parse(Console.ReadLine());

       
        int buyukSayi = (girilenSayı > girilenSayı2) ? girilenSayı : girilenSayı2;

        Console.WriteLine($"Girilen sayıların en büyüğü: {buyukSayi}");

        // Kullanıcıdan Not ortalaması değeri al. Girilen değer 90 dan büyükse 
        //"AA", 80 den büyükse "BB", 70 den büyükse "CC" geri kalan sonuçlarda "Kaldınız" yazsın*/

                   Console.WriteLine("Not Ortalamasını Yazınız: ");
        int notOrtalaması = int.Parse(Console.ReadLine());

        // Ternary operatörlerini doğru kullanarak not ortalamasına göre sonucu belirleyin
        string ortalama = (notOrtalaması >= 90) ? "AA" :
                          (notOrtalaması >= 80) ? "BB" :
                          (notOrtalaması >= 70) ? "CC" :
                          "Kaldınız";

        Console.WriteLine($"Sonuç: {ortalama}");
