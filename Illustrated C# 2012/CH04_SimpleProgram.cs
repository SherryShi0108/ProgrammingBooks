using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllustratedCSharp2012
{
    // Classes:The Basics
    class CH04_SimpleProgram
    {
    }

    #region 1
    class MyClass
    {
        //Field
        int F1 ; //字段会隐式初始化 0
        string F2; //隐式初始化为null

        int F3 = 10;
        string F4 = "String";

        int F5, F6 = 25;

        //Method
        public void PrintNumbers()
        {
            Console.WriteLine("1");
            Console.WriteLine("2");
        }
    }

    class Main1
    {
        static void main()
        {
            MyClass myClass;
            myClass = new MyClass();

            MyClass myClass2 = new MyClass();
        }
    }
    #endregion 1

    #region 2
    class Dealer
    {

    }
    class Player
    {
        string Name;
    }

    class Main2
    {
        static void main()
        {
            Dealer dealer = new Dealer();
            Player player1 = new Player();
            Player player2 = new Player();
            Player player3 = new Player();
        }
    }
    #endregion 2

    #region 3
    class DaysTemp
    {
        private int High = 75;
        private int Low = 45;

        private int GetHigh()
        {
            return High;
        }
        private int GetLow()
        {
            return Low;
        }

        public int Average()
        {
            return (GetHigh() + GetLow()) / 2;
        }
    }
    class Main3
    {
        public static void main()
        {
            DaysTemp daysTemp = new DaysTemp();

            // daysTemp.High = 10; 这是由于private限制，所以不能访问High

            int x= daysTemp.Average();
            Console.WriteLine("Average is {0}",x);
        }
    }
    #endregion 3

    #region 4
    class ExampleClass
    {
        public int High;
        public int Low;

        public int Average()
        {
            return (High + Low) / 2;
        }
    }

    class Main4
    {
        public static void main()
        {
            ExampleClass exampleClass1 = new ExampleClass();
            ExampleClass exampleClass2 = new ExampleClass();

            exampleClass1.High = 90;
            exampleClass1.Low = 10;

            exampleClass2.High = 80;
            exampleClass2.Low = 20;

            Console.WriteLine("e1:" + "High " + exampleClass1.High + " Low " + exampleClass1.Low);
            Console.WriteLine("e1:" + "High " + exampleClass2.High + " Low " + exampleClass2.Low);
        }
    }
    #endregion 4
}
