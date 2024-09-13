#region MassHesaplama
/*string[] isimler;
double[] ücretler;
int[] saatler;

// output 
Console.WriteLine("Kaç Kişinin Maaşını Girmek İstiyorsun");
// input adet int
int adet = int.Parse(Console.ReadLine());

// Dizi uzunluklarını hesaplıyoruz
isimler = new string[adet];
ücretler = new double[adet];
saatler = new int[adet];

// Döngü ile yukarıda ki bilgileri kullanıcıdan alalım
for(int i = 0; i < adet; i++)
{
    Console.Write($"{i+1}.Kişinin Adı: ");
    string isim = Console.ReadLine();
    isimler[i] = isim;

    Console.Write($"{i+1}.Kişinin Maaşı: ");
    double ucret = Convert.ToDouble(Console.ReadLine()); // Burada yerel değişkenin adını 'ucret' yaptık
    ücretler[i] = ucret;

    Console.Write($"{i+1}.Kişinin Çalışma Saati: ");
    int saat = int.Parse(Console.ReadLine()); // Burada yerel değişkenin adını 'saat' yaptık
    saatler[i] = saat;
}

Console.WriteLine("Ekrana yazdırmak istiyor musun (Y/N)");

if(Console.ReadLine().ToLower() == "y")
{
    for(int i  = 0; i < adet; i++)
    {
        Console.WriteLine($"Personel Adı: {isimler[i]} Saati: {saatler[i]} Ücreti: {ücretler[i]} Maaşı : {ücretler[i]* saatler[i]}");
    }
}
*/
#endregion

#region NBoyutluDizi

/*int[] vizeler = {30,54,6,67,89,34,67,49};
int[] finaller = {56,75,45,87,98,31,98,12};

int[,] tumSınavlar = new int[5,2] { {30,56}, {54,75}, {6,45}, {67,87},{89,98} };
Console.WriteLine(tumSınavlar[4,1]);
*/
#endregion


#region Ornek1
// tek boyutlu integer dizisi olusturunuz Dışarıdan gelecek adete gore veri alacak
// ve sınav notları tutulacak

/*int[] sınavlar;
Console.WriteLine("Bir Sınav Adeti Giriniz");
int adet = int.Parse(Console.ReadLine());

sınavlar = new int[adet];

for (int i = 0; i < adet; i++)
{
    Console.WriteLine($"{i+1}. Sınav Notunu Giriniz");
    sınavlar[i] = int.Parse(Console.ReadLine());
}

// foreach döngüsünde farklı bir değişken adı kullanıyoruz
foreach (int sınavNotu in sınavlar)
{
    Console.WriteLine($"Girilen Sınav Notu: {sınavNotu}");
}*/

#endregion

#region 
// Bir Dizi İçersindeki tum sayıları toplıyarak ortlamasını bulun
/*int toplam = 0;

int[] sayılar = {31,65,34,57,43,353,53,53,53,53};

foreach(var de in sayılar)
{
    toplam += de;
   
}
double ortlama = sayılar.Average();
Console.Write(ortlama);
*/

// klavyeden girilen 10 adet sayıdan 100 den büyük olanları bir diziye atayan program
// yazınız

/*int[] sayılar = new int[10];
int[] buyukSayılar = new int[10];
Console.WriteLine("10 adet sayı giriniz");

for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"Sayı{i+1}");
    int sayı = int.Parse(Console.ReadLine());

 
}
int sayac = 0;
for(int i = 0; i < 10; i++)
{
    if(sayılar[i] > 100)
    {
        buyukSayılar[sayac] = sayılar[i];
        sayac++;
    }
}
Console.Write(buyukSayılar);*/

// rast gele üretilen 15 sayıyı bir dizide tutun
/*Random random = new Random();
int[] sayılar = new int[15];

for(int i = 0; i < 15; i++)
{
     sayılar[i] = random.Next(0,101);
    
}
for(int i = 0; i < sayılar.Length -1; i++)
{
    for(int j = 0; j < sayılar.Length -1; j++)
    {
        if(sayılar[j]< sayılar[j+1])
        {
            int temp = sayılar[j];
            sayılar[j] = sayılar[j + 1];
            sayılar[j+1] = temp;

        }
    }
}
foreach(int sayıl in sayılar)
{
    Console.WriteLine(sayıl);

}
*/
/*Random random = new Random();
int[] sayılar = new int[20];
 List<int> negatifler = new List<int>();
List<int> pozitifler = new List<int>();
for(int i = 0; i < 20; i++)
{
    int sayı = random.Next(-50,50);
    
    if(sayı <  0)
    {
        negatifler.Add(sayı);
    }
else if(i > 0)
    {
        pozitifler.Add(sayı);
    }
}
foreach(int negatif in negatifler)
{
    Console.Write(negatif);
}
foreach(int pozıtıf in pozitifler)
{
    Console.Write(pozıtıf);
}*/

//1 ile 49 arasındaki sayılardan rastgele 7 adet sayı üretip, bu
// sayıların hiçbirinin aynı olmamasını sağlayan Sayısal Loto 
//uygulamasını yazın

   Random random = new Random();
        HashSet<int> sayılar = new HashSet<int>(); // benzersiz sayılar ıcın

        
        while (sayılar.Count < 7)
        {
            int sayi = random.Next(1, 50); 
            sayılar.Add(sayi); 
        }

        
        Console.WriteLine("Rastgele üretilen 7  sayı:");
        foreach (int sayi in sayılar)
        {
            Console.Write(sayi + " ");
        }
    


#endregion