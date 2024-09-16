// List<T> içerinde (0) verilen tipe o tipte bir koleykısyon olusturmamıza olanak sağlayan dizi çeşidirir.Daha oncekı ilkel diziler gibi ekleme sınırı olmadan eleman ekleye bildiğimiz yapıya sahiptir
// kaç tane koyarsan o kadar alır

List<string> liste = new List<string>() { "A","B","C"};  // referans tıplerın baslangıc degeri null
liste.Add("D"); // sonrdan ekleme yapmak için

List<int> sayılar = new List<int> { 1, 2, 3, 4, 5 };
sayılar.Add(6);
sayılar.Add(7);

Console.WriteLine(sayılar); // boyle dersen verileri yazmaz verileri cağırmak lazım
Console.WriteLine(sayılar[4]);
Console.WriteLine(liste[3]);

List<string> sehirler = new List<string>()  { "Afyon","İstanbul","Bursa","Kocaeli" };
// () bunu başlangıçta atama yapcaksak kullanmaya gerek yok ama atama olmıcaksa kullanılması lazım
sehirler.Add("Konya");
sehirler.Add("Ankara");
sehirler.Add("Gümüşhane");
//sehirler.AddRange(sehirler);
Console.WriteLine(sehirler[0]);
Console.WriteLine(sehirler.Contains("Ankara")); // Ankara varsa true
Console.WriteLine(sehirler.Contains("Eskişehir") ? "Var": "Yok");
Console.WriteLine(sehirler.Contains("Afyon") ? "Var" : "Yok");
foreach (string sehir in sehirler)
{
    Console.WriteLine(sehir);
}
// LIFO,FIFO

for (int i = 0; i < sehirler.Count; i++)
{
    Console.WriteLine(sehirler[i]);
}
