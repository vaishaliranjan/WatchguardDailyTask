//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RevisionBeg_Adv
//{
//    public sealed class Singleton
//    {
//        private static int counter = 0;
//        private static Singleton instance = null;
//        public static Singleton GetInstance
//        {
//            get
//            {
//                if (instance == null)
//                {
//                    instance = new Singleton();
//                }
//                return instance;
//            }
//        }
//        private Singleton()
//        {
//            counter++;
//            Console.WriteLine("Counter Value: "+counter);
//        }
//        public void PrintDetails(string msg)
//        {
//            Console.WriteLine(msg);
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Singleton fromEmployee = new Singleton();
//            //fromEmployee.PrintDetails("Fromemp");
//            //Singleton fromStudent = new Singleton();
//            //fromStudent.PrintDetails("From student");

//            Singleton fromEmployee = Singleton.GetInstance;
//            fromEmployee.PrintDetails("Fromemp");
//            Singleton fromStudent = Singleton.GetInstance;
//            fromStudent.PrintDetails("From student");
//        }
//    }
//}
