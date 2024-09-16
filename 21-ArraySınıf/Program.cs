// ArraySınıfı diziler veya collectıons içersinde kullana bileceğimiz 
// bir çok ozellık (property) ve metot(Methods) barındırır.

#region Lenght
// Bir dizinin sahip oldugu oğe sayısını soyler
/*
int[] number = {1,2,3,4,5,6,7,8,9,10 };
int elemanSayısı = number.Length;
Console.WriteLine(elemanSayısı);
*/
#endregion

#region Copy

/*int[] kaynak = {12,2,3422,3123,131,5,3,6,9 };
int[] hedef = {1,2,3,5 };
Array.Copy(kaynak,hedef,3);

foreach (int i in hedef)
{
    Console.WriteLine(i);
}
Console.WriteLine(new string('-',30));

foreach (var i in kaynak)
{
    Console.WriteLine(i);
}*/
#endregion

#region Sort
//Sıralama

/*int[] numbers = {12,1,4,234,78 };
Array.Sort(numbers);

foreach (var number in numbers)
{
    Console.WriteLine(number);
}*/
//Array.Reverse(numbers);
#endregion

#region IndexOf
/*
int[] numbers = {1,3,5,6,6,37,8,95 };
int result = Array.IndexOf(numbers, 95, 2);
Console.WriteLine(result);

int[] numbers2 = { 1, 3, 5, 6, 6, 37, 8, 95 };
int result2 = Array.IndexOf(numbers,  2);
Console.WriteLine(result2);
*/
#endregion

#region LastIndexOf
/*
int[] numbers = { 1, 3, 5, 6, 6, 37, 8, 95 };
int result = Array.LastIndexOf(numbers, 37,5);
Console.WriteLine(result);

int[] numbers2 = { 1, 3, 5, 6, 6, 37, 8, 95 };
int result2 = Array.LastIndexOf(numbers, 2);
Console.WriteLine(result2);
*/
#endregion

#region Reverse
/*
int[] numbers = { 12, 1, 4, -3, 12, 53 };
Array.Sort(numbers); // A-Z
Array.Reverse(numbers); // Z-A

//
string[] sehirler = { "Afyon","İstanbul","Ankara","Kocaeli"};
Array.Reverse(sehirler);

foreach (var item in sehirler)
{
    Console.WriteLine(item);
}*/
#endregion

#region Clear
// Dizinin içinde temizlik nasıl yapılır
/*
int[] numbers = {12,1,4,-3,12,53 };
Array.Clear(numbers,2,2);

foreach (var item in numbers)
{
    Console.WriteLine(item);
}*/

#endregion

#region Resize
// ilkel dizinin eleman sayısını arttırmak veya azaltmak ıcın kullanılır

string[] sehirler = { "İstanbul", "Afyon", "Bursa", "Ankara" };
//sehirler[3] = "Sinop";
Array.Resize(ref sehirler,sehirler.Length +1); //  referansını alır sonra değişkliği yapıp cıkar // ihtiyac oldukca arttırır
sehirler[4] = "Kocaeli";

foreach (var item in sehirler)
{
    Console.WriteLine(item);
}

#endregion