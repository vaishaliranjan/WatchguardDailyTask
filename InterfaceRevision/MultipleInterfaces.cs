//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Interface
//{
//    //First Interface 

//    public interface Interface1
//    {
//        void func1();
//        void func2();
//    }

//    //Second Interface 
//    public interface Interface2
//    {
//        void function1();
//        void function2();
//    }

//    //
//    public interface Interface3 : Interface1, Interface2
//    {
//        void func3();
//    }

//    public class TripleInterface : Interface3
//    {
//        public void func1()
//        {
//            throw new NotImplementedException();
//        }

//        public void func2()
//        {
//            throw new NotImplementedException();
//        }

//        public void func3()
//        {
//            throw new NotImplementedException();
//        }

//        public void function1()
//        {
//            throw new NotImplementedException();
//        }

//        public void function2()
//        {
//            throw new NotImplementedException();
//        }
//    }

//    //Multiple Interface 

//    public class MultipleInterface : Interface1, Interface2, Interface3
//    {
//        //public void func1()
//        //{
//        //    Console.WriteLine("Interface1 function 1 called");
//        //}

//        //public void func2()
//        //{
//        //    Console.WriteLine("Interface1 function 2 called");
//        //}

//        //public void func3()
//        //{
//        //    Console.WriteLine("Interface3 function 1 called..");
//        //}

//        //public void function1()
//        //{
//        //    Console.WriteLine("Interface2 function 1 called");
//        //}

//        //public void function2()
//        //{
//        //    Console.WriteLine("Interface2 function 2 called");
//        //}

//        //---------------------------------------Explicitly-----------------------
//        //void Interface1.func1()
//        //{
//        //    Console.WriteLine("Interface1 function 1 called");
//        //}

//        //void Interface1.func2()
//        //{
//        //    Console.WriteLine("Interface1 function 2 called");
//        //}

//        //void Interface2.function1()
//        //{
//        //    Console.WriteLine("Interface2 function 1 called");
//        //}

//        //void Interface2.function2()
//        //{
//        //    Console.WriteLine("Interface2 function 2 called");
//        //}

//        //void Interface3.func3()
//        //{
//        //    Console.WriteLine("Interface3 function 1 called..");
//        //}
//        public void NoninheritedFunction()
//        {
//            Console.WriteLine("Non Inherited function");
//        }
//    }
//    internal class MultipleInterfaces
//    {
//        static void Main(string[] args)
//        {
//            //First- Basic 
//           // MultipleInterface multipleInterface = new MultipleInterface();
//            //multipleInterface.func1();
//            //multipleInterface.func2();
//            //multipleInterface.function1();
//            //multipleInterface.function2();
//            //Interface1 function 1 called
//            //Interface1 function 2 called
//            //Interface2 function 1 called
//            //Interface2 function 2 called

//            //Interface1 inter1 = new MultipleInterface(); //Upcasting
//            //inter1.func1();
//            //inter1.func2();
//            ////Interface1 function 1 called
//            ////Interface1 function 2 called
//            ////inter1.function1();//error
//            ////inter1.function2();//error 

//            //Interface2 inter2 = new MultipleInterface(); //Upcasting 
//            //                                             // inter2.func1();//error
//            //                                             //inter2.func2();//error
//            //inter2.function1();
//            //inter2.function2();
//            //Interface2 function 1 called
//            //Interface2 function 2 called


//            //------------------EXPLICITLY-------------

//            //To call func of Interface 1
//            Interface1 interface1 = new MultipleInterface();
//            interface1.func1();
//            interface1.func2();
//            //interface1.NoninheritedFunction(); -> error
//            Interface2 interface2 = new MultipleInterface();
//            interface2.function1();
//            interface2.function2();
//            //interface2.NoninheritedFunction(); -> error

//            MultipleInterface multipleInterface1 = new MultipleInterface();
//            //multipleInterface1.func1();
//            //multipleInterface1.func2();
//            //multipleInterface1.function1();
//            //multipleInterface1.function2();
//            //ERROR
//            //multipleInterface1.NoninheritedFunction();// -> NO error 

//        }
//    }
//}