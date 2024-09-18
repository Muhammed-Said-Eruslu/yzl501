namespace _26_LocalFunction
{
    internal class Program
    {
        // Local Methods (Function) Metot içinde oluşturulan metotlardor

        static void Main(string[] args)
        {
            int[] sayılar1 = { 12, 23, 434 };
            Console.WriteLine(KarakökHesapla(sayılar1));
            int[] sayılar2 = { 12, 23, 4, 52, 46, 224, 5, 634 };
            Console.WriteLine(KarakökHesapla(sayılar2));
            Console.WriteLine($"İsim : "+ EkranaYaz("Said"));
            int ToplamaYap(int s1, int s2)
            {
                return s1 + s2;
            }
            Console.WriteLine(ToplamaYap(4,3));

            string EkranaYaz(string deger)
            {
                return deger;
            }


            double KarakökHesapla(int[] diziler)
            {
                // dizi içindeki sayıları topla karakökünü al ve dön
                int topla = 0;
                for (int i = 0; i < diziler.Length; i++)
                {
                    topla += diziler[i];
                }
                return Math.Sqrt(topla);
            }

        }
    }
}
