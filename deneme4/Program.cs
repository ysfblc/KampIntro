using System;

namespace deneme4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            urunler urun1 = new urunler();
            urun1.urunAdi = "superstar";
            urun1.urunBedeni = 39;
            urun1.urunFiyati = 399.99;

            urunler urun2 = new urunler();
            urun2.urunAdi = "airmax";
            urun2.urunBedeni = 45;
            urun2.urunFiyati = 429.99;

            urunler[] urunn = new urunler() {urun1, urun2 };

            foreach (var urun in urunn)
            {
                Console.WriteLine(urun.urunAdi + ":" + urun.urunBedeni);

            }

        }
    }

    class urunler
    {
        public string urunAdi { get; set; }
        public int urunBedeni { get; set; }
        public double urunFiyati { get; set; }
    }
}
