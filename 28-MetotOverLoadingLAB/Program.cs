
namespace MetotOverLoadingLAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] calısanlar = new string[4] {"Said","Muhammed","Ege","Berkay" };
            double[] maaslar = new double[4];
            bool devamMı = true;

            while(devamMı)
            {
                for(int i = 0; i< calısanlar.Length; i++)
                {
                    Console.WriteLine($"{i} - {calısanlar[i]}");
                }
                Console.WriteLine("Maaş Hesaplanacak Çalışanın Numarasını Giriniz");
                int index = int.Parse(Console.ReadLine());

                Console.WriteLine("Maaş -" + calısanlar[index]+ " :");

                Console.WriteLine("Çalışma Saatini Giriniz");
                int calısmaSaati = int.Parse(Console.ReadLine());

                Console.WriteLine("Saatlik Ücret:");
                int saatlıkUcret = int.Parse(Console.ReadLine());

                if(calısmaSaati <= 270)
                {
                    maaslar[index] = MaasHesapla(calısmaSaati, saatlıkUcret);
                }
                else
                {
                    double mesai = MesaiHesapla(calısmaSaati);
                    maaslar[index] = MaasHesapla(calısmaSaati, saatlıkUcret,mesai);
                }
                Console.WriteLine("Yeni Maaş Hesabı Yapcak Mısın (E/H)");
                devamMı = (Console.ReadLine().ToLower() == "e");

              
            }
            Console.WriteLine("\n*********************************\n");

            for (int i = 0; i < calısanlar.Length; i++)
            {
                Console.WriteLine($"Personal Adı : {calısanlar[i]} Maaş {maaslar[i]}");
            }
        }

        private static double MaasHesapla(int calısmaSaati, int saatlıkUcret, double mesai)
        {
            // değer döndürüyorsa bi şekilde retunr yada hata vermesi lazım
            if(calısmaSaati > 0)
            {
                return (calısmaSaati * saatlıkUcret) + mesai;
            }
            else
            {
                throw new Exception("Maaş 0 dan küçük olamaz");
            }
        }

        private static double MesaiHesapla(int calısmaSaati, double mesaiÜcreti = 550)
        {
          double saat =  calısmaSaati - 270;
            return saat * mesaiÜcreti;
        }

        private static double MaasHesapla(int calısmaSaati,int saatlıkUcret)
        {
            if (calısmaSaati > 0)
            {
                return (calısmaSaati * saatlıkUcret);
            }
            else
            {
                throw new Exception("Maaş 0 dan küçük olamaz");
            }
        }
        


    }
}