// Birden fazla aynı tipteki veriyi bir arttırmamıza sağlayan nesnelerdir

#region DiziTanımlama

/*string[] isimler = { "Muhammed", "Said", "Eruslu" };

string[] soyİsimler = new[] { "Eruslu","Alkan","Kalyoncu","Toplu" };

int[] yaslar = new int[4];

yaslar[0] = 23;
yaslar[1] = 19;

Console.WriteLine(yaslar[2]);*/

using System.Linq.Expressions;

/*double[] maaslar = new double[4];
maaslar[0] = 31;
maaslar[1] = 65.708;

char[] karakterler = new char [4] { 'A', 'B', 'C', 'D' };
*/
#endregion

#region DiziErişimler

/*string[] arabalar = { "Lamborgini","Bugatti","Porshe","Dodge" };

foreach (string item in arabalar)
{

	if (item == "Dodge")
	{
		Console.ForegroundColor = (item == "Dodge") ? ConsoleColor.Red :
			ConsoleColor.White;
        Console.WriteLine(item);
	}
}*/

// object dizisi tanımlayın içerisinde 6 farklı tipte deger atayın ve ekrana yazdırın

/*object[] farklı = {"Said",1,43224.423 };

foreach (var item2 in farklı)
{
    Console.WriteLine(item2);
}
*/
#endregion

#region Örnek1
// 8 tane tamsayı deger gireceğim foreach ike ekrana yazarken sadece cift olanları yazdırınint

int[] cıft = { 1, 2, 3, 4, 6, 8, 4, 2, 54, 7465, 423 };


/*foreach (var item3 in cıft)
{
	if (item3 % 2 == 0)
	{
        Console.WriteLine(item3);
	}
}*/

for (int i = 0; i < cıft.Length; i++)
{
	if (cıft[i] % 2 == 0)
	{
		Console.WriteLine(cıft[i]);
	}
}
#endregion
