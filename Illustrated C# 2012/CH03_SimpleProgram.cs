using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllustratedCSharp2012
{
    class CH03_SimpleProgram
    {
        static void Base()
        {
            // Predefined Types
            sbyte b1 = -10;
            byte b2 = 10;

            short s1 = -10;
            ushort s2 = 10;

            int i1 = -10;
            uint i2 = 10;

            long l1 = -10;
            ulong l2 = 10;

            float f = 3.14F;
            double d = 3.14; // default
            decimal d1 = 3.14M;

            bool b = true;
            char c = 'A', c2 = '\u0000';

            object o = new object();
            string s = "String";
            /* dynamic d =; */
        }
        //User-Defined Types
        class A { }
        interface I { }
        struct B { }
        enum C { }
        delegate void D();
        Array E;



    }
}
