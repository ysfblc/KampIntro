﻿using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması ";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati+"tl");
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(".............");
            }

            Console.WriteLine("------Metodlar------");


            //instance - class örneği olusturma
            //encapsulation - işleyen düzen kapsülüne yeni veriyi sokma

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut","yeşil armut",10, 2);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 80, 3);
            sepetManager.Ekle2("elma", "yeşil elma", 5, 10);









        }
    }
}

// !!Dont repeat yourself!!-DRY- Clean Code - Best Practice
