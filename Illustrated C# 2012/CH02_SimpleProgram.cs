using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllustratedCSharp2012
{
    public class CH02_SimpleProgram
    {
        public static void Base()
        {
            Console.WriteLine("Hello World!");

            int var1 = 5;
            Console.WriteLine("The value of var1 is {0}",var1);

            Console.WriteLine("Three integers are {1},{0},{1}", 3, 6);

            //Formatting Numeric Strings
            Console.WriteLine("The value:|{0,10:C}|",500);
            Console.WriteLine("The value:|{0,-10:C}|", 500);

            /*  */
            //
           
            Console.ReadKey();
        }
    }
}
