using System;
using MyHelperMethods;

namespace _5ci_tapsiriq
{
    class Program
    {
        //5)Verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.
        static void Main(string[] args)
        {
            int number;
            error1:
            number = Reader.ReadInteger("Enter six-digit number: ");
            if (number<100000 || number>999999 )
            {
                Console.Clear();
                Console.WriteLine("Do It Correctly!");
                goto error1;
            }

            int num1 = number / 100000;
            int lastnum = ((number % 100000) * 10) + num1;
            Console.WriteLine($"Your Result: {lastnum}");
            
            


        }
    }
}
