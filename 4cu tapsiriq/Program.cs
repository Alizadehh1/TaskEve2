using MyHelperMethods;
using System;

namespace _4cu_tapsiriq
{
    class Program
    {
        //4)Verilmish 5 reqemli ilk ve son reqemlerinin ceminin kvadrati
        static void Main(string[] args)
        {
            int number;
            Error1:
            number = Reader.ReadInteger("Enter five-digit number: ");
            if (number<10000 || number>99999)
            {
                Console.Clear();
                Console.WriteLine("Do it Correctly!");
                goto Error1;
            }
            int number1 = number % 10;
            int number2 = number / 10000;
            int number3 = (number1 + number2);
            int number4 =(int) Math.Pow(number3,2);
            Console.WriteLine($"Your Result: {number4}");

        }
    }
}
