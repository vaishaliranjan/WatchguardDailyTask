//******************* SINGLE THREADED PROGRAMMING
//using System.Threading;
//namespace Nov7Discussion
//{
//    internal class Multithreading
//    {
//        static void Main(string[] args)
//        {
//            //View the current thread
//            Thread mainThread = Thread.CurrentThread;
//            mainThread.Name = "Main Thread";
//            Console.WriteLine(mainThread.Name);

//            //Single threaded application
//            Timer1();
//            Timer2();
//            Console.WriteLine("Main thread completed");
//        }

//        public static void Timer1()
//        {
//            for(int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Timer 1: "+ i);
//                Thread.Sleep(500);
//            }
//        }
//        public static void Timer2()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Timer 2: " + i);
//                Thread.Sleep(500);
//            }
//        }
//    }
//}

//namespace Nov7Discussion
//{
//    internal class Multithreading
//    {
//        static void Main(string[] args)
//        {
//            //Thread thread1 = new Thread(Timer1);
//            //Thread thread2 = new Thread(Timer2);

//            //If we would have parameters in that function then we would have to use lambda expressions
//            Thread thread1 = new Thread(()=> Timer1("Timer 1"));
//            Thread thread2 = new Thread(()=> Timer2("Timer 2"));
//            thread1.Name = "Thread 1";
//            thread2.Name = "Thread 2";

//            thread1.Start();

//            // thread2.Start();
//            //thread1.Join();
//            //thread2.Join();
//            //Task.WaitAll();
//       //     thread1.Abort();
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Main: " + i);
//               // Thread.Sleep(500);
//            }
//            Console.WriteLine("Main thread completed");

//        }
//        //private static readonly Object lockObj = new Object();
//        //static void Critical()
//        //{
//        //    lock (lockObj)
//        //    {
//        //        // Console.WriteLine(thread.Name);
//        //        for (int i = 0; i < 3; i++)
//        //        {
//        //            Console.WriteLine("CS: " + i);
//        //            Thread.Sleep(200);
//        //        }
//        //    }
//        //}
//        public static void Timer1(string name)
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                //if (i == 5)
//                //{
                    
//                //   // Critical();
//                //}
//                Console.WriteLine("Timer 1: " + i);
//                //Thread.Sleep(500);
//            }
//        }
//        public static void Timer2(string name)
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                //if (i == 5)
//                //{
//                //    Critical();
//                //}
//                Console.WriteLine("Timer 2: " + i);
//                //Thread.Sleep(500);
//            }
//        }
//    }
//}