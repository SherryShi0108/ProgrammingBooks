using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllustratedCSharp2012
{
    //Method
    class CH05_SimpleProgram
    {
        #region simple method
        void MyMethod()
        {
            Console.WriteLine("First");
            Console.WriteLine("Last");

            int myInt = 15;
            // SomeClass sc = new SomeClass(); 也是本地变量，引用类型的本地变量

            var xx = 10; //自动类型推断var只能用于本地变量            
        }

        void DisplayRadius()
        {
            const double PI = 3.1416;
            for (int i = 0; i < 6; i++)
            {
                double area = i * i * PI;
                Console.WriteLine("Radius:{0},Area:{1}", i, area);
            }
        }
        #endregion simple method


        #region return method
        int GetHour()
        {
            DateTime dateTime = new DateTime();
            int x = dateTime.Hour;
            return x;
        }

        MyClass GetMyClass()
        {
            MyClass my = new MyClass();
            my.PrintNumbers(); //实例名.方法名

            return my;
        }

        void TestReturn()
        {
            int x = 100;
            if (x > 50)
            {
                return;
            }
            else
            {
                Console.WriteLine(x);
            }
        }
        #endregion 2     
    }

    #region Parameters
    class MyClassTestParameters
    {
        public int PrintSum(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        public float Avg(float x, float y)
        {
            float avg = x + y / 2.0F;
            return avg;
        }
    }

    class Main
    {
        static void main()
        {
            MyClassTestParameters mc = new MyClassTestParameters();
            int someInt = 6;

            mc.PrintSum(8, someInt);
            mc.Avg(8, someInt);
        }
    }
    #endregion Parameters

    #region Method Overloading
    class A
    {
        long AddValues(int a, int b) { return a + b; }
        long AddValues(int a, int b, int c) { return a + b + c; }
        long AddValues(float a, float b) { return (long)(a + b); }
        long AddValues(long a, long b) { return a + b; }
    }
    #endregion

    #region Named Parameters
    class MyClassEx1
    {
        public int Calc(int a, int b, int c)
        {
            return (a + b) * c;
        }

        static void main()
        {
            MyClassEx1 mc = new MyClassEx1();
            int x = mc.Calc(c: 10, b: 1, a: 3);
            Console.WriteLine(x);

            int x1 = mc.Calc(3, 1, 10);
            int x2 = mc.Calc(3, c: 10, b: 1);
            int x3 = mc.Calc(3, b: 1, c: 10);
            int x4 = mc.Calc(c: 10, b: 1, a: 3);
        }
    }

    /*
     * output:
     * 40
     */
    #endregion

    #region Optional Parameters
    class MyClassEx2
    {
        public int Calc(int a = 3, int b = 1, int c = 10)
        {
            return (a + b) * c;
        }

        static void main()
        {
            MyClassEx2 mc = new MyClassEx2();

            int x1 = mc.Calc(4, 2, 11);
            int x2 = mc.Calc(4, 2);
            int x3 = mc.Calc(4);
            int x4 = mc.Calc();

            int x5 = mc.Calc(b: 2);
            int x6 = mc.Calc(b: 2, c: 11);
        }
    }

    /*
     * x1:66
     * x2:60
     * x3:50
     * x4:40
     * 
     * x5:50
     * x6:55
     */
    #endregion

    #region  Recursion
    class MyClassEx3
    {
        int Factorial(int invalue)
        {
            if (invalue <= 1)
            {
                return invalue;
            }
            else
            {
                return invalue * Factorial(invalue - 1);
            }
        }
    }

    class MyClassEx4
    {
        void Count(int invalue)
        {
            if (invalue == 1)
            {
                return;
            }
            else
            {
                Count(invalue - 1);
            }
            Console.WriteLine(invalue);
        }

        public static void main()
        {
            MyClassEx4 mc = new MyClassEx4();
            mc.Count(3);
        }
    }

    /*
     * output:
     * 2
     * 3
     */
    #endregion
}
