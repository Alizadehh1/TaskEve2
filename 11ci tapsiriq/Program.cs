using System;
using MyHelperMethods;

namespace _11ci_tapsiriq
{
    class Program
    {
       // 11) 8 reqemli ededin reqemlerini iki -iki qruplashdir. 
       // Qruplarin cemini tap.Alinan cavabin axirina 99 artir.
       // Sonra cavabin ozunden onun 18% ni cix;
        static void Main(string[] args)
        {
            int number;
        Error1:
            number = Reader.ReadInteger("Enter eight-digit number: ");
            if (number<10000000 || number>99999999)
            {
                Console.Clear();
                Console.WriteLine("Do It Correctly Please!");
                goto Error1;
            }

            int num4 = number % 100;
            number = number / 100;

            int num3 = number % 100;
            number = number / 100;

            int num2 = number % 100;
            number = number / 100;

            int num1 = number % 100;

            double sumofnums = (num1 + num2 + num3 + num4) * 100 + 99;
            double lastnum = sumofnums - sumofnums * 0.18;

            Console.WriteLine($"You Result: {lastnum}");




        }
    }
}
