// See https://aka.ms/new-console-template for more information
// Dışarıdan ürün adı girilecek bize hangi bölümde oldugunu soyliyecek
// Domates,Biber,Patlıcan, meyve ve sebze bolumune bak
// diş macunu , parfüm ,sabun kozmetık bolumune bak
// cep telefonu, tv , bilgisayar teknoloji bolumune bak
// bunların dısında bir ürün bu ürün bizde yok
#region ÜrünOrnek
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
#endregion

#region Lab-2
//Dışarıdan sıparış alınacak olan kitap mıktarı girilsin sıparıs sayısı 20 den az ise %5 20-50 arasında ise %10 50-100 aralıgında ise %15 100 den fazla ise %25 indirim yapılsın
// kitabın birim fiyatı 50TL
// toplam siparıs mıktarı
// indirim miktarı
// odenecek tutar

/*int kitapFiyati = 50; 
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
*/
#endregion

#region KareÖrnek
// kullanıcının girdiği iki sayının karelerının toplamını goruntuluyen programın  
// iki sayının karesını almak ıcın once Console.WriteLine diyip kullanıcıdan ıkı sayı gırmesini isteriz
// sonra input olarak girilen sayı string veri tipinde oldugu ucun onu ınt.parse metodu ıle ceviririz
// kullanıcı ıkı sayı girdikten sonra birincisayı* birincisayı
// ikincısayı*ıkıncısayı
// ama kare1 olarak double veri tipinde açariz ve işlemeleri orda yaparız
// aynı sekılde kare2
// sonra
/*Console.WriteLine("İki sayı giriniz");
int sayKare1 = int.Parse(Console.ReadLine());
int sayKare2 = int.Parse(Console.ReadLine());


double kare1 = sayKare1 * sayKare1;


double kare2 = sayKare2 * sayKare2;

// Console.WriteLine("Birinci sayının karesi: {0}", kare1);
 //Console.WriteLine("İkinci sayının karesi: {0}", kare2);

Console.WriteLine($"{sayKare1} ile {sayKare2} ' nin karesi {sayKare1 * sayKare1 + sayKare2 * sayKare2}")

Console.WriteLine("İki sayı giriniz");
int sayıka = int.Parse(Console.ReadLine());
*/
#endregion

#region DogumTarihi
// Dogum Tarihi Giren Kişinin Yaşını Hesaplayan Program

/*Console.WriteLine("Dogum tarihiniz giriniz");
int dogumYılı = int.Parse(Console.ReadLine());

int mevcutYıl = DateTime.Now.Year;

int yas = mevcutYıl - dogumYılı;
Console.WriteLine($"Yaşınız: {yas}");

#endregion

#region ModÖrnek
// Girilen sayının istenilen sayıya gore mod işlemini yaptıran programın algorıtma ve akıs dıyagramını cızınız

Console.WriteLine("1. Sayıyı Giriniz: ");
int modsayı = int.Parse(Console.ReadLine());

Console.WriteLine("2. Sayıyı Giriniz: ");
int modsay2 = int.Parse(Console.ReadLine());

int istenilen1 = int.Parse(Console.ReadLine());
int istenilen2 = int.Parse(Console.ReadLine());

Console.WriteLine($"1. Sayının {istenilen1} sayısına göre modu: {modsayı % istenilen1}");
Console.WriteLine($"2. Sayının {istenilen2} sayısına göre modu: {modsay2 % istenilen2}"); 
*/
#endregion

#region TekMıCıftMı
// klavyeden girilen sayı tek mı cıft mı

Console.WriteLine("Bir sayı giriniz: ");
int kontrolSayı = int.Parse(Console.ReadLine());

if (kontrolSayı % 2 == 0)
{
    Console.WriteLine("Girilen sayı çifttir: {0}", kontrolSayı);
}
else
{
    Console.WriteLine("Girilen sayı tektir: {0}", kontrolSayı);
}
#endregion

#region ÇıftTekOranı
// Klavyeden girilen 5 adet cift sayının toplamının tek sayılara toplamına oranın bulun
Console.WriteLine("1. Sayıyı Giriniz: ");
        int girilen1 = int.Parse(Console.ReadLine());

        Console.WriteLine("2. Sayıyı Giriniz: ");
        int girilen2 = int.Parse(Console.ReadLine());

        Console.WriteLine("3. Sayıyı Giriniz: ");
        int girilen3 = int.Parse(Console.ReadLine());

        Console.WriteLine("4. Sayıyı Giriniz: ");
        int girilen4 = int.Parse(Console.ReadLine());

        Console.WriteLine("5. Sayıyı Giriniz: ");
        int girilen5 = int.Parse(Console.ReadLine());

        
        int oranCift = girilen1 + girilen3 + girilen5;
        int oranTek = girilen2 + girilen4;

        if(oranTek != 0)
        {
            double maınOran = (double) oranCift / oranTek;
            Console.WriteLine($"Çift Sayıların Toplamı {oranCift}");
            Console.WriteLine($"Tek Sayıların Toplamı {oranTek}");
            Console.WriteLine($"Çift Sayıların toplamının oranı tek sayılara toplamının oranı {maınOran}");
        }
        else{
              Console.WriteLine("Tek sayıların toplamı 0, oran hesaplanamaz.");
        }

        /*Console.WriteLine("1.Sayıyı Giriniz: ");
        int girilen1 = int.Parse(Console.ReadLine());
        Console.WriteLine("2. Sayıyı Giriniz: ");
        int girilen2 = int.Parse(Console.ReadLine());
        Console.WriteLine("3. Sayıyı Giriniz: ");
        int girilen3 = int.Parse(Console.ReadLine());
        Console.WriteLine("4. Sayıyı Giriniz: ");
        int girilen4 = int.Parse(Console.ReadLine());
        Console.WriteLine("5. Sayıyı Giriniz: ");
        int girilen5 = int.Parse(Console.ReadLine());

        int oranCıft = girilen1+girilen3+girilen5;
        int oranTek = girilen2+girilen4;
        if(oranTek != 0)
        {
            double maınOran = (double) oranCıft / oranTek;
            Console.WriteLine($"Girilen Sayı Çifttir: {oranCıft}");
            Console.WriteLine($"Girilen Sayı Tektır: {oranTek}");
            Console.WriteLine($"Girilen Sayının Çıft sayıların tek sayılara toplama oranı {maınOran}");
        }
        else
        {
            Console.WriteLine("Tek Sayıların Toplamı 0 , oran hesaplanamaz");
        }*/
#endregion