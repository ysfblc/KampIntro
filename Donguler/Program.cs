using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array-dizi

            string[] kurslar = new string[] {"yazılım kursu",
                "programlamaya başlangıç",
                "java kursu","python kursu","bilmemne kursu" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("SAYFA SONU");
        }
    }
}
