using MyHelperMethods;
using System;


namespace _9cu_tapsiriq
{
    class Program
    {
        //9)9 reqemli ededdin tek yerde dayananlardan bir eded duzelt: 132346389=12439
        static void Main(string[] args)
        {
            int number;
            Error1:
            number = Reader.ReadInteger("Enter nine-digit number: ");
            if (number<100000000 || number>999999999)
            {
                Console.Clear();
                Console.WriteLine("Do It Correctly!");
                goto Error1;
            }

            int digits;
            int counter = 1;
            int reversenumber = 0;

            for (int i = 0; i < 9; i++)
            {
                digits = number % 10;
                number = number / 10;
                if (counter % 2 == 1)
                {
                    reversenumber = (reversenumber * 10 + digits);

                }
                counter++;
                
            }
            
            int digits1 = reversenumber;
            reversenumber = 0;

            while (digits1 > 0)
                {
                reversenumber = reversenumber + digits1  % 10; //0+1
                digits1 = digits1 / 10;                        //9753
                reversenumber = reversenumber * 10;                       

                }
            reversenumber = reversenumber / 10;
            Console.WriteLine($"Your Result: {reversenumber}");





        }
    }
}
