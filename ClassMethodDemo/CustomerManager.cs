using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Başarıyla Listeye Eklendi!"+"----->"+customer.AdiSoyadi+","+"T.C:"+customer.Id);
        }
        
        public void Add2(Customer customer)
        {
            Console.WriteLine("Müşteri Listeden Kaldırıldı!"+customer.AdiSoyadi);
        }

        public void Add3(Customer[] customers)
        {
            foreach (var x in customers)
            {
                Console.WriteLine("Müşteri Adı-Soyadı:" + x.AdiSoyadi);
                Console.WriteLine("Müşteri Kimlik Numarası:" + x.Id);
                Console.WriteLine("Kredi Notunuz:" + x.KrediNotu);
                Console.WriteLine("--------------------");
            }
        }

    }
}
