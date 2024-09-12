// Math Class, bizlere hazır olarak onlarca matematiksel fonksıyonu saglayan
// temel bir sınıftır

// pi sayısını elde etme
Console.WriteLine($"Math.PI: {Math.PI}");

// Mutlak değer

int mutlakDeger = Math.Abs(-45);
Console.WriteLine($"Mutlak deger(-45): {mutlakDeger}"); // 45

// Floor => Verilen ondalıklı degeri bir alt değere tamamlar.
double floorDeger = Math.Floor(12.98);
Console.WriteLine($"Floor Değer(12.98) {floorDeger}"); // 12

//Ceiling => Verilen ondalıklı değeri, ibr üst tam değere tamamlar
double ceilingDeger = Math.Ceiling(12.98);
Console.WriteLine($"Ceiling Deger(12.98): {ceilingDeger}"); // 13

// Round => Sayının yarısından fazlasını b,r üstteki yarısından azını bir alttakı tam sayıya yuvarlar
// 0 dan 4 e kadar asagı yuvarla 5 ve 9 a kadar olanları yukarı yuvarlar
//Not: Noktadan öbceki sayı çift ise aşağı tek ise yukaru yuvarlar

Console.WriteLine(Math.Round(13.5)); // ikinci parametresi digit diyelım 2 girdim 2 den sonrasını kontrol et

// Truncete => Sayının ondalıklı kısmına bakmaz, yalnızca tam sayı kısmını size teslim eder
Console.WriteLine(Math.Truncate(12.98)); // 12

// Max Value 
Console.WriteLine(Math.Max(45, 65)); // 65

// Min Value
Console.WriteLine(Math.Min(45,65)); // 65

// Pow => Kuvvet alma
Console.WriteLine(Math.Pow(3,4)); // 81

// Sqrt => Karekök
Console.WriteLine(Math.Sqrt(16)); // 4

// Sign => Bir sayının negafit mi pozitif mi yoksa 0 mı oldugunu bilgisi doner
// negatif ise -" Sıfır ise 0 Pozitif 1

// Trigonemtektir hesaplamlar
// Math.Tan Math.Sin()