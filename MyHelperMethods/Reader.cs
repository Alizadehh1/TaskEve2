using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHelperMethods
{
    public class Reader
    {
        
        public static int ReadInteger(string caption)
        {
            int a;
            Console.Write(caption);
            a = Convert.ToInt32(Console.ReadLine());
            return a;

        }
    }
}
