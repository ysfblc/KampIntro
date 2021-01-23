using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor bloğu - Dizi newlendiğinde çalışacak 
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //newlendiğinde sıfırlanmaması için dizinin referans adresini başka bir yere tutturduk.
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//geçiçi listede tuttuklarını geri ver.
            }

            items[items.Length - 1] = item; //son eklemenin yapılışı.
        }
    }
}
