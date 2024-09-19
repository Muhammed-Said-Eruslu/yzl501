// Clean Code

#region İsimLendirme
// 1- İsimlendirme
// Değişken ve metot isimleri kısa ve anlamlı olmalıdır

int a = 10; // kötü
int ogrenciSayısı = 10; // iyi
#endregion

#region MetotUzun
// 2- Metot Uzunluğu

// Metotları olabildiğince kısa tut.Birnici sorumluluk uzerine odaklanın.Bir metodun bir şeyi yapması her zaman iyi olandır

#endregion

#region Yorumlar
// 3-Yorumlar
// Kodun hedefine odaklana yorumlar yazın
#endregion

#region BoşlukKullanımı
// kötü
for(int k=0;k<10;k++)
{
    Console.WriteLine(k);
}
// iyi 
for(int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
#endregion

#region HataYönetimi
// kötü
try
{
    // istisna fırlatılacak kodlarımız
}
catch(Exception ex)
{
    // Özel bir işlem olmadan tüm istisnaları yakalamak
}

// iyi

try
{
    // sadece hata alabilme ihtimali olan kodlar
}
catch(OverflowException ex)
{
    // Belirli durumlarda hata fırlat
}
catch(DivideByZeroException ex)
{
    // Belirli durumlarda hata fırlat
}

#endregion

#region BestPracites

int sayı, sayac = 0, maksımumSayı = 0, cıftMaksımumSayı = 0;

bool sayıMı = KullanıcıdanSayıAl(out sayı);
if(sayıMı && sayı >= 0 && sayı != 1)
{
    DegerleriBul(out cıftMaksımumSayı, out maksımumSayı, sayı, out sayac);
    DegerleriEkranaYaz(maksımumSayı, cıftMaksımumSayı, sayac);
}
else if(sayıMı == false)
{
    Console.WriteLine("Girilen değer bir sayı değildir");
}
else if(sayı < 0)
{
    Console.WriteLine("Sayı negatif");
}
else if(sayı == 1)
{
    Console.WriteLine("Sayıyı 1 girdiniz");
}
/// <summary>
/// ...
/// </summary>
/// <param name="maksımumSayı">...</param>
/// <param name="ciftMaksımumSayı">...</param>
/// <param name="sayac">...</param>
void DegerleriEkranaYaz(int maksımumSayı, int cıftMaksımumSayı, int sayac)
{
    Console.WriteLine("Bu işlem sırasında ulaşılan maksimum sayı: {0}",maksımumSayı);
    Console.WriteLine("Bu işlem sırasında sürekli çift olarak 1'e ulaşılan maksimum sayı {0}",cıftMaksımumSayı);
    Console.WriteLine("Bu işlem bitene kadarki adım sayısı: {0}",sayac);
}

/// <summary>
/// Gerekli döngüyü kullanarak değerleri bulur
/// </summary>
/// <param name="ciftMaksimumSayı"> Çift maksimüm sayı değerini alır.</param>
/// <param name="maksimumSayı">Maksimum sayı değerini alır</param>
/// <param name="sayı">Sayı değerini alır</param>
/// <param name="sayac">Sayac değerini alır</param>
void DegerleriBul(out int cıftMaksımumSayı, out int maksımumSayı, int sayı, out int sayac)
{
    cıftMaksımumSayı = maksımumSayı = sayac = 0;
    while(sayı >= 2)
    {
        sayac++;
        
        if(sayac % 2 == 1)
        {
            sayı = (sayı * 3) + 1;
            sayac++;
            cıftMaksımumSayı = 0;
        }
        // Koşul doğrultusunda atama operasyonu yapacaksanız Ternary if kullanın

        cıftMaksımumSayı = cıftMaksımumSayı < sayı ? sayı : cıftMaksımumSayı;

        sayı /= 2;
    }
}

/// <summary>
/// Kullanıcıdan değer alıp, değeri int türüne dönüştürmeyi dener
/// </summary>
/// <param name="sayı">int tipinde bir tam sayı giriniz. </param>
/// </returns> Eğer değeri int tipine döüştürülebilirse true, aksi halde false döndürür </returns>

bool KullanıcıdanSayıAl(out int sayı)
{
    Console.WriteLine("Lütfen Pozitif Bir Sayı Giriniz :");
    return int.TryParse(Console.ReadLine(), out sayı);
}

#endregion