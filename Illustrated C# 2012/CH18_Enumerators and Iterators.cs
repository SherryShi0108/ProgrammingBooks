/*******************************************************************************************************************************
 *
 * 枚举器：
 * 1. 枚举基本使用理解
 * 2. 使用IEnumerable和IEnumerator完整示例
 * 3. 迭代器理解
 * 4. 使用迭代器来创建枚举器 / 使用迭代器来创建可枚举类型
 * 5. 看几个例子理解
 * 
 *******************************************************************************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;

namespace IllustratedCSharp2012_18
{
    #region 1. 枚举基本使用理解

    public class Class1
    {
        public void Method()
        {
            int[] arr = new[] {10, 11, 12, 13};
            foreach (int item in arr)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    //模仿实现枚举器Demo，和foreach实现一样
    public class Class2
    {
        public void Imitate()
        {
            int[] arr = new[] { 10, 11, 12, 13 };

            IEnumerator ie = arr.GetEnumerator();
            while (ie.MoveNext())
            {
                int i = (int)ie.Current;
                Console.WriteLine(i);
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }

    #endregion

    #region 2. 使用IEnumerable和IEnumerator完整示例

    class Class3 : IEnumerator
    {
        private string[] Colors;
        private int postion = -1;
        public Class3(string[] input)
        {
            Colors = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                Colors[i] = input[i];
            }
        }

        public bool MoveNext()
        {
            if (postion < Colors.Length-1)
            {
                postion++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            postion = -1;
        }

        public object Current
        {
            get
            {
                if (postion > -1 && postion < Colors.Length)
                {
                    return Colors[postion];
                }

                return null;
            }
        }
    }

    class Class4:IEnumerable
    {
        private string[] CurrentColors = {"Red", "Yellow", "Green", "Blue", "Pink", "Purple"};
        public IEnumerator GetEnumerator()
        {
            return new Class3(CurrentColors);
        }
    }

    class ProgramTest
    {
        static void MainTest()
        {
            Class4 a=new Class4();
            foreach (string s in a)
            {
                Console.WriteLine(s);
            }
        }
    }

    #endregion

    #region 3. 迭代器理解

    class Class5
    {
        //迭代器可以用作返回枚举器
        public IEnumerator<string> Method()
        {
            yield return "Black";
            yield return "Red";
            yield return "Gray";
        }

        public IEnumerator<string> Method2()
        {
            string[] a = new[] {"Black", "Red", "Gray"};
            for (int i = 0; i < a.Length; i++)
            {
                yield return a[i];
            }
        }
    }

    #endregion

    #region 4. 使用迭代器来创建枚举器 / 使用迭代器来创建可枚举类型
    public class ProgramTest2
    {
        static void MainTest()
        {
            Class6 a = new Class6();
            foreach (string s in a)
            {
                Console.WriteLine(s);
            }
        }
    }
    public class Class6
    {
        public IEnumerator<string> GetEnumerator()
        {
            return BlackAndWhite();
        }

        public IEnumerator<string> BlackAndWhite()
        {
            yield return "Black";
            yield return "Gray";
            yield return "White";
        }
    }

    class ProgramTest3
    {
        static void mainTest()
        {
            Class7 a = new Class7();
            foreach (string s in a)
            {

            }

            foreach (string s in a.BlackAndWhite())
            {

            }
        }
    }

    class Class7
    {
        public IEnumerator<string> GetEnumerator()
        {
            IEnumerable<string> a = BlackAndWhite();
            return a.GetEnumerator();
        }

        public IEnumerable<string> BlackAndWhite()
        {
            yield return "Black";
            yield return "Gray";
            yield return "White";
        }
    }


    #endregion

    #region 5. 看几个例子理解

    class ProgramTest4
    {
        static void MainTest()
        {
            Spec s=new Spec();
            foreach (string s1 in s.Method1())
            {
                // red black pink
            }

            foreach (string s2 in s.Method2())
            {
                // pink black red
            }
        }
    }
    class Spec
    {
        private string[] colors = new[] {"red", "black", "pink"};

        public IEnumerable<string> Method1()
        {
            for (int i = 0; i < colors.Length; i++)
            {
                yield return colors[i];
            }
        }

        public IEnumerable<string> Method2()
        {
            for (int i = colors.Length-1; i >=0; i--)
            {
                yield return colors[i];
            }
        }
    }


    class ProgramTest5
    {
        static void MainTest()
        {

        }
    }

    class Spectrum
    {
        private bool _isAtB;
        private string[] color = new[] {"red", "black", "pink"};
        public Spectrum(bool isAtB)
        {
            _isAtB = isAtB;
        }

        public IEnumerator<string> GeEnumerator()
        {

        }

        public IEnumerator<string> Test1
        {
            get
            {
                for (int i = 0; i < color.Length; i++)
                {
                    yield return color[i];
                }
            }
        }

        public IEnumerator<string> Test2 {
            get
            {
                for (int i = color.Length-1; i >=0; i--)
                {
                    yield return color[i];
                }
            }
        }
    }

    #endregion
}