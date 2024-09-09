// See https://aka.ms/new-console-template for more information
// Dışarıdan ürün adı girilecek bize hangi bölümde oldugunu soyliyecek
// Domates,Biber,Patlıcan, meyve ve sebze bolumune bak
// diş macunu , parfüm ,sabun kozmetık bolumune bak
// cep telefonu, tv , bilgisayar teknoloji bolumune bak
// bunların dısında bir ürün bu ürün bizde yok

/*Console.WriteLine("Ürün Adları Domates,Biber,Patlıcan  diş macunu , parfüm ,sabun cep telefonu, tv , bilgisayar ");
string urun = Console.ReadLine();
if(urun == "Domates" || urun == "Biber" || urun == "Patlıcan")
{
    Console.WriteLine("Bu ürün meyve ve sebze bölümünde");
}
else if(urun == "Diş Macunu" || urun == "Parfüm" || urun == "Sabun")
{
    Console.WriteLine("Bu ürün kozmetik bölümünde");
}
else if(urun == "Cep Telefonu" || urun =="TV" || urun =="Bilgisayar")
{
    Console.WriteLine("Bu ürün teknoloji bölümünde");
}
else
{
    Console.WriteLine("Bu ürün bizde yok");
}
Console.WriteLine("Yeni Ürün Eklemek İster misin (E/H)");
string cevap = Console.ReadLine();
if(cevap == "E")
{
    Console.WriteLine("Lütfen eklemek istediğiniz ürünü ve Hangi reyonda olacagını giriniz");
    string yenıUrun = Console.ReadLine();
    Console.WriteLine($"Yeni ürün eklendi {yenıUrun}");
    string yenıReyon = Console.ReadLine();
    Console.WriteLine($"Yeni reyon eklendi {yenıReyon}");
    

}
else if(cevap == "H")
{
    Console.WriteLine("Okey");
}
*/

#region Lab-2
//Dışarıdan sıparış alınacak olan kitap mıktarı girilsin sıparıs sayısı 20 den az ise %5 20-50 arasında ise %10 50-100 aralıgında ise %15 100 den fazla ise %25 indirim yapılsın
// kitabın birim fiyatı 50TL
// toplam siparıs mıktarı
// indirim miktarı
// odenecek tutar

int kitapFiyati = 50; 
double toplamTutar;
double odenecekTutar;
double indirimOrani = 0.0;
double indirimMiktari;

Console.WriteLine("Kaç kitap sipariş etmek istersiniz?");
int siparisSayisi = int.Parse(Console.ReadLine());


if (siparisSayisi < 20)
{
    indirimOrani = 0.05;
}
else if (siparisSayisi >= 20 && siparisSayisi <= 50)
{
    indirimOrani = 0.10;
}
else if (siparisSayisi > 50 && siparisSayisi <= 100)
{
    indirimOrani = 0.15;
}
else
{
    indirimOrani = 0.25;
}


toplamTutar = siparisSayisi * kitapFiyati;

indirimMiktari = toplamTutar * indirimOrani;

odenecekTutar = toplamTutar - indirimMiktari;

Console.WriteLine($"Toplam sipariş miktarı: {siparisSayisi}");
Console.WriteLine($"İndirim oranı: {indirimOrani * 100}%");
Console.WriteLine($"İndirim miktarı: {indirimMiktari:C}");
Console.WriteLine($"Ödenecek tutar: {odenecekTutar:C}");


/*int kitapFiyati = 50;
double toplamTutar;
double odenecekTutar;
double indirimOrani = 0.0;
double indirimMiktari;

Console.WriteLine("Kaç kitap sipariş etmek istersin");
int siparisMiktari = int.Parse(Console.ReadLine());

if(siparisMiktari < 20)
{
    indirimOrani = 0.5;
}
else if(siparisMiktari >= 20 && siparisMiktari<= 50)
{
    indirimOrani = 0.10;
}
else if(siparisMiktari >50 && siparisMiktari <= 100)
{
    indirimOrani = 0.15;
}
else
{
    indirimOrani = 0.25;
}
*/
#endregion