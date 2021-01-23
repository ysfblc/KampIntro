using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryTest
{
    class MyDictionary<T>
    {
        T[] translates;
        
        public MyDictionary()
        {
            translates = new T[0];
            
        }
        public void Add(T translate)
        {
            T[] tempTranslate = translates;
            

            translates = new T[translates.Length + 1];
            

            for (int i = 0; i < tempTranslate.Length; i++)
            {
                translates[i] = tempTranslate[i];
                

            }
            translates[translates.Length - 1]= translate;
            


            Console.WriteLine(translate);

        }
    }
}
