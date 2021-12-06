using MyHelperMethods;
using System;

namespace _6ci_tapsiriq
{
    class Program
    {
        //6)Verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et 
        static void Main(string[] args)
        {
            int number;
            error1:
            number = Reader.ReadInteger("Enter eight-digit number: ");
            if (number<10000000 || number>99999999)
            {
                Console.Clear();
                Console.WriteLine("Do It Correctly!");
                goto error1;
            }

            int num1 = number / 10;
            int num2 = num1 % 1000000;
            Console.WriteLine($"Your Result: {num2}");
        }
    }
}
