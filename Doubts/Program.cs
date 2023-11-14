//namespace Doubts
//{
//    public struct Admin
//    {
//        public int x;
//        public int y;
//        public string s;
//        public static int v;
//        public Admin(int x)
//           : this()
//        {
//            this.x = 9;

//        }
//        void Print()
//        {

//        }

//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//    {
//        Admin a = new Admin(9);
//        Console.WriteLine(a.x);
//        Console.WriteLine(a.y);
//        //Console.WriteLine(a.s));
//    }
//}
//}

using System;
namespace CSharpInter
{
    public class Classes
    {
        public int x;
        public int y;
        public static int z;
        //public Classes()
        //{
        //    Console.WriteLine("parameterless");
        //}
        public Classes(int x)
//: this()
        {
            Console.WriteLine("1st cons called");
            this.x = 10;
        }
        public Classes(int x, int y)
            : this(x)
        {
            Console.WriteLine("2nd cons called");

        }
        public static void PrintName()
        {
            Console.WriteLine("name printed");
        }
        public void Print()
        {
            Console.WriteLine("name printed");
        }
    }
    public class B : Classes
    {

        public B(int x, int y)
            : base(x, y)
        {
            Console.WriteLine("only b cons called");
            this.x = 10;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            B b = new B(10, 11);
            Console.WriteLine(b.x);

            b.Print();
        }

    }
}





namespace CSharp
//{
//    public class Calc
//    {
//        int z;
//        public int Calculator(int x, int y, out int add, out int sub, int z)
//        {
//            add = x + y;
//            sub = x - y;
//            this.z = z;
//            return add + sub;
//        }

//    }
//    public class program
//    {
//        static void Main(string[] args)
//        {
//            Calc c = new Calc();
//            int add;
//            int sub;
//            int ans= c.Calculator(10, 12,out add, out sub, 10);
//            Console.WriteLine(add);
//            Console.WriteLine(sub);
//            Console.WriteLine(ans);
//        }
//    }
//}


//using System;
//namespace CSharpInter
//{
//    public class program
//    {
//        static void Main(string[] args)
//        {
//            Func<int, int, int> func = (x, y) => x + y;
//            int results = func(1, 2);
//            Console.WriteLine(results);

//            Func<string, bool> isValid = s => s.Length > 3;

//            string[] countries = { "India", "China", "Chi" };
//            IEnumerable<string> validCountries = countries.Where(isValid);
//            foreach (string country in validCountries)
//            {
//                Console.WriteLine(country);
//            }

//            Func<int> ZeroParam = () => 0;

//            Console.WriteLine(ZeroParam());
//        }
//    }
//}