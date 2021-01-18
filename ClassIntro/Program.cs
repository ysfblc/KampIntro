using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.kursAdi = "C#";
            kurs1.kursEgitmeni = "Engin Demiroğ";
            kurs1.ızlenmeOrani = 6312;


            kurs kurs2 = new kurs();
            kurs2.kursAdi = "Python";
            kurs2.kursEgitmeni = "Engin Demiroğ";
            kurs2.ızlenmeOrani = 6322;


            kurs kurs3 = new kurs();
            kurs3.kursAdi = "Java";
            kurs3.kursEgitmeni = "Kerem Varış";
            kurs3.ızlenmeOrani = 6882;


            //Console.WriteLine(kurs1.kursAdi + ":" + kurs1.kursEgitmeni);

            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3,};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi+":"+kurs.kursEgitmeni+"-"+kurs.ızlenmeOrani+"izlenme");
            }


            //Console.WriteLine("Hello World!");
        }


        class kurs
        {
            public string kursAdi { get; set; }
            public string kursEgitmeni { get; set; }
            public int ızlenmeOrani { get; set; }
        }
    }
}
