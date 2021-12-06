using System;
using MyHelperMethods;

namespace _10cu_tapsiriq
{
    class Program
    {
        // 10) 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
        // sonra cut yerde dayanlarinda bir eded duzlet,
        // sonra onlari topla

        static void Main(string[] args)
        {
            int number;
            Error1:
            number = Reader.ReadInteger("Enter nine-digit number: ");

            if (number<100000000 || number>999999999)
            {
                Console.Clear();
                Console.WriteLine("Do It Correctly Please!");
                goto Error1;
            }
            
           

            int digits=0;
            int counter = 1;
            int reversenumber=0;
            int reversenumber1 = 0;
            while (number>0)
            {
                digits = number % 10; //1
                number = number / 10; //12345678
                if (counter % 2 == 1)
                {
                    reversenumber = reversenumber * 10 + digits;
                }
                else
                {
                    reversenumber1 = reversenumber1 * 10 + digits;
                }
                counter++;
            }

            int digits1 = 0;
            while (reversenumber > 0)
            {
                digits1 = digits1 + reversenumber % 10;
                reversenumber = reversenumber / 10;
                digits1 = digits1 * 10;
            }
            digits1 = digits1 / 10;

            int digits2 = 0;
            while (reversenumber1>0)
            {
                digits2 = digits2 + reversenumber1%10;
                reversenumber1 = reversenumber1 / 10;
                digits2 = digits2 * 10;
            }
            digits2 = digits2 / 10;

            int lastnum = digits1 + digits2;
            Console.WriteLine($"Your Result: {lastnum} ");


        }
    }
}
