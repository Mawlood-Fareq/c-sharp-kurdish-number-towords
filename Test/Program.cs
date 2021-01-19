using System;
using KurdishNumberToWords;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            KurdishNumber num = new KurdishNumber();
            Console.WriteLine(num.Convert(12345));
            Console.WriteLine(num.ConvertCurrency(123.45));
        }
    }
}
