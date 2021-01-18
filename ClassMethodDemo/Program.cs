using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 354165318;
            customer1.AdiSoyadi = "Nuri Tavasapı";
            customer1.KrediNotu= 3.25f;

            Customer customer2 = new Customer();
            customer2.Id = 425792154;
            customer2.AdiSoyadi = "Cezmi Kalorifer";
            customer2.KrediNotu = 1.25f;

            Customer customer3 = new Customer();
            customer3.Id = 354165318;
            customer3.AdiSoyadi = "Saint Lightning";
            customer3.KrediNotu = 15.99f;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (Customer x in customers)
            {
                Console.WriteLine("Müşteri Adı-Soyadı:"+x.AdiSoyadi);
                Console.WriteLine("Müşteri Kimlik Numarası:"+x.Id);
                Console.WriteLine("Kredi Notunuz:" + x.KrediNotu);
                Console.WriteLine("--------------------");
  
            }
            Console.WriteLine("");
            Console.WriteLine("+++++Listeleme Bitti+++++");
            Console.WriteLine("");


            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            Console.WriteLine("");
            Console.WriteLine("+++++Ekleme İşlemi Bitti+++++");
            Console.WriteLine("");
            Console.WriteLine("--------------------");


            customerManager.Add2(customer1);
            customerManager.Add2(customer2);
            customerManager.Add2(customer3);

            Console.WriteLine("");
            Console.WriteLine("+++++Silme İşlemi Tamamlandı+++++");
            Console.WriteLine("");
            Console.WriteLine("--------------------");

            customerManager.Add3(customers);
            Console.WriteLine("+++++Method Yardımıyla Yeniden Listeleme İşlemi Bitti+++++");






















        }
    }
}
