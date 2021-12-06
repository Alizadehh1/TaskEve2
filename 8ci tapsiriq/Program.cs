using System;
using MyHelperMethods;

namespace _8ci_tapsiriq
{
    class Program
    {
        //8)Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap 
        static void Main(string[] args) //123456 456
        {
            int number;

            number = Reader.ReadInteger("Enter number: ");

            int num1 = (number % 1000) / 100;
            int num2 = number % 10;
            int result = num1 + num2;
            Console.WriteLine($"Your Result: {result}");

            
        }
    }
}
