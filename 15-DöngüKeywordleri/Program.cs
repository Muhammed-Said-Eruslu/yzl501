// Contiune, Break ve Return

#region Contiune
/*Console.WriteLine("Sayı Giriniz: ");
int gırılensayı = Convert.ToInt32(Console.ReadLine());
int toplam = 0;

for (int i = 0; i < gırılensayı; i++)
{
	if (i % 2 == 0)
	{
		continue; // 13 den sonrası yok contiune bu anlama gelir
	}
	toplam += i;
    Console.WriteLine(i);
}*/

#endregion

#region BreakveReturn

int sayı = 0;
if (sayı < 100)
{
	for (sayı = 24; sayı < 50; sayı++)
	{
		if (sayı > 25)
		{
			break;
		}
	
	}
	for (sayı = 49; sayı < 100; sayı++)
	{
		if (sayı > 50)
		{
			return; // metodu bitirir. Min metodu voıd tipte geri donus beklediğinden return; ile metodu sonlandırır
		}
	}
}
sayı = sayı + 5;
Console.WriteLine(sayı);

#endregion
