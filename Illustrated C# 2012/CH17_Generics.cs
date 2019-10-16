/*******************************************************************************************************************************
 *
 * 泛型可用在：类、结构、接口、委托、方法中，前四种是类型，最后一种是成员；约束：类名/class/struct+接口名+new()
 * 1. 泛型Demo，初步理解
 * 2. 泛型类
 * 3. 泛型方法与扩展方法：泛型方法可以在泛型/非泛型 类/接口/结构 中声明；泛型类的扩展方法：必须static且为静态类的成员
 * 4. 泛型结构
 * 5. 泛型委托：和正常委托类似
 * 6. 泛型接口：和正常接口类似
 * 7. 协变(可用于委托和接口)
 * 8. 逆变(可用于委托和接口)
 * 9. 接口逆变和协变Demo
 * 
 *******************************************************************************************************************************/

using System;
using System.Runtime.InteropServices;

namespace IllustratedCSharp2012_17
{
    #region 1. 泛型初步理解
    class MyIntStack
    {
        private int StackPointer = 0;
        private int[] StackArray;

        public void Push(int x)
        {

        }

        public int Pop()
        {
            return StackArray[0];
        }
    }

    class MyFloatStack
    {
        private int StackPointer = 0;
        private float[] StackArray;

        public void Push(float x)
        {

        }

        public float Pop()
        {
            float a = 0f;
            return a;
        }
    }

    class MyStack<T>
    {
        private int StackPointer = 0;
        private T[] StackArray;

        public void Push(T x)
        {

        }

        public T Pop()
        {
            return StackArray[0];
        }
    }
    #endregion

    #region 2. 泛型类

    class SomeClass<T1, T2>
    {
        private T1 SomeVar;
        private T2 OtherVar;
        private T2[] StackArray;

        public void Push(T1 x)
        {

        }

        public T2 Pop()
        {
            return StackArray[0];
        }
    }

    class TestProgram
    {
        static void TestMain()
        {
            SomeClass<int, string> a = new SomeClass<int, string>();
            SomeClass<short, int> b = new SomeClass<short, int>();
            a.Push(1);
            string k= a.Pop();
        }
    }

    class SomeClass2<T1, T2> where T1:struct where T2:SomeClass<int,int>,IComparable,new()
    {
        private T1 SomeVar;
        private T2 OtherVar;
        private T2[] StackArray;

        public void Push(T1 x)
        {

        }

        public T2 Pop()
        {
            return StackArray[0];
        }
    }

    #endregion

    #region 3. 泛型方法 与 扩展方法

    class MyClass1
    {
        void DoStuff<T1, T2>(T1 t1, T2 t2)
        {
            T1 someVar = t1;
            T2 otherVar = t2;
        }

        void TestMain()
        {
            DoStuff<int,string>(1,"1");
            DoStuff(1,"1");
        }
    }

    class Holder<T>
    {
        T[] vals=new T[2];

        public Holder(T t1,T t2)
        {
            vals[0] = t1;
            vals[2] = t2;
        }

        public T[] GetValue()
        {
            return vals;
        }
    }
    static class ExtendHolder
    {
        public static void Print<T>(this Holder<T> h)
        {

        }
    }

    class TestProgramClass
    {
        public static void TestMain()
        {
            Holder<int> a=new Holder<int>(1,2);
            a.Print();
        }
    }

    #endregion

    #region 4. 泛型结构

    struct MyStruct<T1,T2> 
    {
        public MyStruct(T1 value)
        {
            _data = value;
        }

        private T1 _data;

        public T1 Data
        {
            get { return _data; }
            set { _data = value; }
        }
    }

    class ProgramTestStruct
    {
        static void TestMain()
        {
            MyStruct<int,string> a=new MyStruct<int, string>(10);
            var b=new MyStruct<int,string>(20);
        }
    }


    #endregion

    #region 5. 泛型委托

    delegate R MyDelegate<T, R>(T value);

    delegate void MyDelegate_2<T>(T value);

    class SimpleDelegateClass_2
    {
        static public void Print(string s)
        {
        }

        public void Draw(string s)
        {
        }

        static void Play(int i)
        {
        }
    }

    class ProgramDelegate_2
    {
        static void TestMain()
        {
            MyDelegate_2<string> m=new MyDelegate_2<string>(SimpleDelegateClass_2.Print);

            SimpleDelegateClass_2 a =new SimpleDelegateClass_2();
            m+=new MyDelegate_2<string>(a.Draw);

            m("aaa");
        }
    }

    delegate TR Func<T1, T2, TR>(T1 p1, T2 p2);

    class FuncDelegate
    {
        public static string Print(int x, int y)
        {
            return "aaa";
        }
    }

    class ProgramDelegateFunc
    {
        static void TestMain()
        {
            Func<int, int, string> f=new Func<int, int,string>(FuncDelegate.Print);
            f(1, 2);
        }
    }

    #endregion

    #region 6. 泛型接口

    interface IMyIfc<T>
    {
        T MethodPrint(T value);
    }

    class SimpleIfc<K> : IMyIfc<K>
    {
        public K MethodPrint(K value)
        {
            return value;
        }
    }

    class ProgramInterface
    {
        static void TestMain()
        {
            SimpleIfc<int> a=new SimpleIfc<int>();
            SimpleIfc<string> b=new SimpleIfc<string>();

            a.MethodPrint(1);
            b.MethodPrint("aa");
        }
    }

    interface IMyIfc_2<T>
    {
        T MethodPrint(T value);
    }

    class SimpleIfc_2 : IMyIfc_2<int>, IMyIfc_2<string>
    {
        public string MethodPrint(string value)
        {
            return "";
        }

        public int MethodPrint(int value)
        {
            return 1;
        }
    }

    class ProgramInterface_2
    {
        static void TestMain()
        {
            SimpleIfc_2 a = new SimpleIfc_2();
            a.MethodPrint(1);
            a.MethodPrint("aa");
        }
    }

    interface IMyIfc_3<T>
    {
        
    }

    interface IMyIfc_3
    {
        
    }

    class SimpleIfc_3:IMyIfc_3,IMyIfc_3<int>
    {
        
    }
    #endregion

    #region 7. 协变

    class Animal
    {
        public int NumberOfLeg = 4;
    }

    class Dog:Animal
    {
        
    }

    class ProgramCon_1
    {
        static void TestMain()
        {
            Animal a=new Animal();
            Animal b=new Dog();
            int x = b.NumberOfLeg;
        }
    }

    class Animal_2
    {
        public int NumberOfLeg = 4;
    }

    class Dog_2 : Animal_2
    {

    }

    delegate T Factory<T>();

    class ProgramCon_2
    {
        static Dog_2 MakeDog()
        {
            return new Dog_2();
        }

        static Animal_2 MakeAnimal()
        {
            return new Animal_2();
        }

        static void TestMain()
        {
            Factory<Dog_2> a = new Factory<Dog_2>(ProgramCon_2.MakeDog);

            Factory<Animal_2> b=new Factory<Animal_2>(ProgramCon_2.MakeAnimal);

            //Factory<Animal_2> c = a; //false,想要可以这样赋值啥的，需要在委托T前面加 out “delegate T Factory<out T>();”

        }
    }

    delegate T Factory1<out T>();
    public class ProgramCon_3
    {
        static Dog_2 MakeDog()
        {
            return new Dog_2();
        }

        static void TestMain()
        {
            Factory1<Dog_2> a = MakeDog;
            Factory1<Animal_2> b = MakeDog;

            Factory1<Animal_2> c = a; //正常而言是不可以的，但是使用了out就可以了
        }
    }


    #endregion

    #region 8. 逆变

    class Animals
    {
        public int NumberOfLeg = 4;
    }

    class Dogs : Animals
    {

    }

    delegate void Action1<in T>(T a);
    class ProgramConTest
    {
        static void ActOnAnimal(Animals a)
        {
        }

        static void TestMain()
        {
            Action1<Animals> act1 = new Action1<Animals>(ProgramConTest.ActOnAnimal);
            Action1<Dogs> dog1 = act1;
            dog1(new Dogs());
        }
    }

    #endregion

    #region 9. 接口的逆变和协变

    class Animal2
    {
        public string Name;
    }

    class Dog2:Animal2
    {
        
    }

    interface IMyItf<out T>
    {
        T GetValue();
    }

    class SimpleReturn<T> : IMyItf<T>
    {
        public T[] items=new T[2];
        public T GetValue()
        {
            return items[0];
        }
    }

    class ProgramCon4
    {
        static void DoSth(IMyItf<Animal2> x)
        {

        }

        static void MainTest()
        {
            SimpleReturn<Dog2> d=new SimpleReturn<Dog2>();
            d.items[0] = new Dog2() { Name = "Kitty" };

            IMyItf<Animal2> a = d;
            DoSth(d);
        }
    }

    #endregion
}
