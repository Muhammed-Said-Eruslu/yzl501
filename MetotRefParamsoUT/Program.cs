#region RefKullanımı
// Ref,Out,Params

// Ref,metotlara veya metotlardan değer tiplerin referanslarını iletmke veya döndürmek için kullanır

// Diğer bir değişle referans yoluyla iletilen bir değerde yapılan herhangi bir değişikliğin yanlızca taşıdığı değeri değil adresteki (referans) değerini de değiştirdiğiniz için bu değişikliği yansıtacağı anlamına gelir

// Örnek uygulama 
#endregion

#region Kodlar
/*
int a = 10, b = 12;
Console.WriteLine($"İşlem öncei a değişkeni: {a}");
Console.WriteLine($"İşlem öncei b değişkeni: {b}");
// yeni değer olusturdu değer tipli
Toplam(a);
// Ref parametreli metot
FarkDeger(ref b);
Console.WriteLine($"İşlem sonrası b değişkeni {b}");
Console.WriteLine($"İşlem sonrası a değişkeni {a}");

int[] sayılar = new int[2];
Array.Resize(ref sayılar, 3);
// değer tipli
int Toplam(int a)
{
    return a += 10;
}
// ref tipli farkı ref yeni oluşturma yapmaz mevcut olan b değerini alır onun üstünden atama yapar
void FarkDeger(ref int b )
{
    b -= 5;
}
 
 */
#endregion

#region OutKullanımı
// out bir kullanıcı metotdan birden fazla değer döndürebilir
// fark ismindde bir metot olusturun metot iki tane değer göndersin metottan ilk parametre 60
// ikinci parametre 90 geri dönüş değeri 30

// Bolum isminde metot yazın iki sayı alsın bolumu double olarak parameter olarak ile döndürsün
// kalan varsa onu da return etsin
using System.Runtime;
/*
int i, j;

//Toplam(out i, out j);
//Console.WriteLine("Toplam Değer i:"+ i);
//Console.WriteLine("Toplam Değer j:"+j);

int a, b;
a = 60;
b = 90;
int c = Fark(out a, out b);
Console.WriteLine(c);

int d = Bolum(30, 40, out double kalab);
Console.WriteLine(kalab);

void Toplam(out int p, out int q)
{
    p = 30;
    q = 40;
    p += p;
    q += q;
}

int Fark(out int p, out int q)
{
    int fark = 0;
    p = 60;
    q = 90;
    p = q;
    q = 60;
    fark = p - q;

    return fark;

}

int Bolum(int a, int b, out double bolum)
{
    bolum = (double)a / b;

    return a % b;
}
*/

#endregion

#region Params
/*
int sayılarınToplamı = Toplam(" ", 3, 4, 5, 6, 7, 8, 9, 0, 10);
Console.WriteLine(sayılarınToplamı);
int Toplam(string ad, params int[] sayılar) // aynı tipteyse ve boyutunu bılmıyorsam params kullanırım // paramsı metodun sonunda kullanırız
{
    int toplam = 0;
    for (int i = 0; i < sayılar.Length; i++)
    {
        toplam += sayılar[i];
    }
    return toplam;
}*/
#endregion

#region Recursive
//Kendini çağıran metot

Faktoriyel(3);
int Faktoriyel(int n)
{
    if (n == 0) return (1);

    else
    {
        return n * Faktoriyel(n - 1); // özyinelemeli 
    }
}

#endregion

