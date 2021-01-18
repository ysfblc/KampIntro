using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager //operasyon tutucuklar
    {
        //naming convention - doğru yazma şekilleri
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler,Sepete Eklendi!:"+urun.Adi );
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler,Sepete Eklendi!:" + urunAdi);
        }

    }
}
