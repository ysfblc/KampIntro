using System;

namespace MethodsDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(20);

            int number1;
            int number2 = 120;
            var result2 = Add3(out number1, number2);


            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            //Console.WriteLine(Multiply(8,6,2));

            
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2=30)
        {
            
            var result = number1 + number2;
            return result;
        }

        static int Add3(out int number1, int number2)
        {
            number1 = 40;
            return number1 + number2;
        }

        static int Multiply(int number1,int number2, int number3)
        {
            return number1 * number2 * number3;
        }

    }
}
