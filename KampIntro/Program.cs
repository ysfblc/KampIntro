using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //do not repeat yourself!!!
            //type safety- tip güvenliği
            //alias- takma isim, değer tutucu

            string kategori_etiketi = "Kategori";
            
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }




            Console.WriteLine(kategori_etiketi);






        }
    }
}
