using System;

namespace deneme3
{
    class Program
    {
        static void Main(string[] args)
        {
            int gun = (int)DateTime.Now.Year;
            switch (gun)
            {
                case 2021:
                    Console.WriteLine("bit artık 2021");
                    break;
            }
        }
    }
}
