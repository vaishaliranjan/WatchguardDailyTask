//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpAdvanced
//{
//    internal class Multithreading
//    {
//        public static void func1()
//        {
//            for (int i = 1; i <= 50; i++)
//            {
//                if (i == 11)
//                {
//                    //Thread.Sleep(5000);
//                    Console.WriteLine("func1 calling critical sec");
//                    CriticalSection();
//                }
//                Console.WriteLine("Func1= " + i);
//            }
//        }

//        public static void func2()
//        {
//            for (int i = 1; i <= 50; i++)
//            {
//                Console.WriteLine("Func2= " + i);
//                if (i == 11)
//                {
//                    //Console.WriteLine("Thread is going to sleep for 8 seconds.");
//                    //Thread.Sleep(8000);
//                    Console.WriteLine("func2 calling critical sec");
//                    CriticalSection();

//                    //func3 will wait for func2 to complete
//                }
//            }
//        }
//        public readonly static Object lockObj= new object();
//        public static void CriticalSection()
//        {
//            lock (lockObj)
//            {
//                Thread.Sleep(10000);
//            }
//        }
//        public static void func3()
//        {
//            for (int i = 1; i <= 50; i++)
//            {
//                Console.WriteLine("Func3= " + i);
//            }
//        }
//        static void Main(string[] args)
//        {
//            //Only one thread -> runs sequentially
//            //func1();
//            //func2();
//            //func3();
//            //three threads for each function- so they will run simultaneously-> executed by the operating system using time sharing.-> each thread equally priority
//            Thread t1 = new Thread(func1);
//            Thread t2 = new Thread(func2);
//            //Thread t3 = new Thread(func3);
//            t1.Start();
//            Console.WriteLine(t1.ThreadState);
//            t2.Start();
            
//            Console.WriteLine("main thread executing");

//            //bool res= t1.Join(new TimeSpan(0,0,2));
//            //Console.WriteLine(res);
//            //Console.WriteLine("after sometime");




//            //t2.Start();
//            //t3.Start();
//            //Thread t = Thread.CurrentThread;
//            //t.Name = "Main thread";
//            //Console.WriteLine("Current executing thread is: "+ Thread.CurrentThread.Name);
//        }
//    }
//}
