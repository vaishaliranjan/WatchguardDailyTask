
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Interface
//{
//    public interface Interface1
//    {
//        //cant declare fields 
//        //but we can create propertes in interface and we must implement those properties in derived class
//        int data { get; set; } //this is not auto implemented (self managed) properties in interfaces - only declaration
//        private void Name()
//        {
//            Console.WriteLine("Inside private func");
//        }
//        public void Something()
//        {
//            Name();
//        }
//    }
//    public class Abc : Interface1
//    {
//        public int d;
//        public int data
//        {
//            get
//            {
//                return d;
//            }
//            set
//            {
//                d = value;
//            }
//        }
//        //public int data { get; set; }
//    }
//    internal class Properties
//    {
//        static void Main(string[] args)
//        {
//            Abc abc = new Abc();
//            abc.data = 10;
//            Console.WriteLine(abc.data);
//            Interface1 inter = new Abc();
//            inter.Something();
//        }
//    }
//}
