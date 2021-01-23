using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //CRUD operasyonlarının geçekleştiği classlar

        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        public void Change(Product product)
        {
            product.ProductName = "At gözlüğü";
        }
    }
}
