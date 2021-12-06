using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHelperMethods
{
   public class Calculator
    {
        public static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                number = number / 10;
                sum += digit;

            }
            return sum;
        }

        public static int MultiplyOfDigits(int number)
        {
            int multiply = 1;
            while (number>0)
            {
                int digit = number % 10;
                number = number / 10;
                multiply = multiply * digit;
            }
            return multiply;
        }
    }
}
