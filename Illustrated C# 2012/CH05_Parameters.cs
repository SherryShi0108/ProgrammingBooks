using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllustratedCSharp2012
{
    class CH05_Parameters
    {
    }

    #region Value Parameters
    class MyClass1
    {
        public int value = 20;
    }

    class Program1
    {
        static void MyMethod(MyClass1 f1, int f2)
        {
            f1.value = f1.value + 5;
            f2 = f2 + 5;

            Console.WriteLine("{0},{1}",f1.value,f2);
        }

        static void Main1()
        {
            MyClass1 a1 = new MyClass1();
            int a2 = 10;

            MyMethod(a1, a2);
            Console.WriteLine("{0},{1}", a1.value, a2);
        }
    }

    /*
     * output:
     * 25,15
     * 25,10
     */
    #endregion

    #region Reference Parameters
    class MyClass2
    {
        public int value = 20;
    }

    class Program2
    {
        static void MyMethod(ref MyClass2 f1, ref int f2)
        {
            f1.value = f1.value + 5;
            f2 = f2 + 5;

            Console.WriteLine("{0},{1}", f1.value, f2);
        }

        static void Main2()
        {
            MyClass2 a1 = new MyClass2();
            int a2 = 10;

            MyMethod(ref a1, ref a2);
            Console.WriteLine("{0},{1}", a1.value, a2);
        }
    }

    /*
     *output:
     * 25,15
     * 25,15
     */
    #endregion

    #region Reference Types As Value and Reference Parameters
    class MyClass3
    {
        public int value = 20;
    }

    class Program3
    {
        static void MyMethod(MyClass3 f1)
        {
            f1.value = 50;

            Console.WriteLine(f1.value);

            f1 = new MyClass3();

            Console.WriteLine(f1.value);
        }

        static void Main3()
        {
            MyClass3 a1 = new MyClass3();

            Console.WriteLine(a1.value);

            MyMethod(a1);

            Console.WriteLine(a1.value);
        }
    }

    /*
     *output:
     * 20
     * 50
     * 20
     * 50
     */

    // ref
    class MyClass4
    {
        public int value = 20;
    }

    class Program4
    {
        static void MyMethod(ref MyClass4 f1)
        {
            f1.value = 50;

            Console.WriteLine(f1.value);

            f1 = new MyClass4();

            Console.WriteLine(f1.value);
        }

        static void Main4()
        {
            MyClass4 a1 = new MyClass4();

            Console.WriteLine(a1.value);

            MyMethod(ref a1);

            Console.WriteLine(a1.value);
        }
    }

    /*
     *output:
     * 20
     * 50
     * 20
     * 20
     */
    #endregion

    #region Output Parameters
    class MyClass5
    {
        public int value = 20;
    }

    class Program5
    {
        public static void MyMethod(out MyClass5 f1,out int f2)
        {
            f1 = new MyClass5();
            f1.value = 25;

            f2 = 15;
        }

       public static void Main5()
        {
            MyClass5 a1 = null;
            int a2;

            MyMethod(out a1, out a2);

            Console.WriteLine("{0},{1}", a1.value, a2);
        }
    }

    /*
     *output:
     * 25
     * 15
     */
    #endregion

    #region Parameter Arrays
    class MyClass6
    {
        public void ListInts(params int[] x)
        {
            if (x != null && x.Length != 0)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] = x[i] * 10;
                    Console.WriteLine(x[i]);
                }
            }
        }
    }

    class Program6
    {
        static void Main6()
        {
            int m = 6, n = 7, p = 8;
            MyClass6 mc = new MyClass6();

            mc.ListInts(m,n,p);

            Console.WriteLine("{0},{1},{2}", m, n, p);
        }
    }

    /* 
     * output:
     * 60 
     * 70
     * 80
     * 6,7,8
     */

    class MyClass7
    {
        public void ListInts(params int[] x)
        {
            if (x != null && x.Length != 0)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] = x[i] * 10;
                    Console.WriteLine(x[i]);
                }
            }
        }
    }

    class Program7
    {
        static void Main7()
        {
            int[] x1 = new int[] { 6, 7, 8 };
            MyClass6 mc = new MyClass6();

            mc.ListInts(x1);

            Console.WriteLine("{0},{1},{2}", x1[0], x1[1], x1[2]);
        }
    }

    /* 
     * output:
     * 60 
     * 70
     * 80
     * 60,70,80
     */
    #endregion
}
