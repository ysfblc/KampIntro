using System;

namespace ClassDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            elektronik urunler1 = new elektronik {urunAdi="ayakkabı", urunFiyati=5020, indirimOrani=15};

            elektronik[] ürünlerListesi = new elektronik[] { urunler1 };

            foreach (var urun in ürünlerListesi)
            {
                Console.WriteLine(urunler1.urunAdi+":"+urunler1.urunFiyati+"tl"+"---->"+"%"+urunler1.indirimOrani+"indirim");
            }
            while (urunler1.indirimOrani == 15)
            {
                Console.WriteLine("Ayakkkabılarda Şok İndirim");
                Console.WriteLine("KAÇIRMAYIN!!!!!!!");
                break;
             }
            if (urunler1.urunFiyati>1000)
            {
                Console.WriteLine("vay be");
            }
            


        }
        class elektronik
        {
            public string urunAdi { get; set; }
            public int urunFiyati { get; set; }

            public int indirimOrani { get; set; }

        }

    }
}
