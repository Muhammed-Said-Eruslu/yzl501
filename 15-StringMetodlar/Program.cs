using System.Reflection;

Console.WriteLine("Bir Metin Giriniz");
string metın = Console.ReadLine();

#region Contains
metın = "Muhammed Said Eruslu";


/*string[] kelimeler = metın.Split(' ');

foreach (string degısken in kelimeler) // nasından sonuna atlamadan kullancaksan bu daha mantıklı
{
    Console.WriteLine(degısken);
}

for (int i = 0; i < kelimeler.Length; i++) // foreach yerine de kullanıla bilir
{
    Console.WriteLine(kelimeler[i]);
}*/

char[] karakterler = metın.ToCharArray();

foreach (char c in metın)
{
    Console.WriteLine(c);
}
#endregion