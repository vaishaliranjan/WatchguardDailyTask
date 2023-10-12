
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Interface
//{
//    public abstract class AbstractClass
//    {
//        public abstract void abstractFunction(); //abstract method cant be defined 
//        public virtual void virtualFunction()
//        {
//            Console.WriteLine("Virtual function in base class...");
//        }
//    }
//    public class DerivedClass : AbstractClass
//    {
//        public override void abstractFunction()
//        {
//            Console.WriteLine("Abstract function has been defined in derived class");
//        }
//        //public override void virtualFunction()
//        //{
//        //    Console.WriteLine("Virtual function in derived class...");
//        //}

//        //not compulsory to redifne 
//    }
//    internal class AbstractVSInterface
//    {
//        static void Main(String[] args)
//        {
//            //cant create object of abstract class
//            DerivedClass derivedClass = new DerivedClass();
//            derivedClass.abstractFunction();
//            derivedClass.virtualFunction();
//            //Abstract function has been defined in derived class
//            //Virtual function in base class...


//            AbstractClass absDer = new DerivedClass();
//            absDer.abstractFunction();
//            absDer.virtualFunction();


//        }
//    }
//}

//---------------------------------------------------------- INTERFACES ---------------------------------------------
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Interface
//{
//    public interface Interface1
//    {
//        void abstractFunction(); //by default abstract and public 

//        //C# 8.0 added support for virtual extension methods in interface with concrete implementations.

//        //***********************************************Default Interface Methods ********************

//        //Virtual interface methods are also called default interface methods that do not need to be implemented in a class or struct.
//        //Note that a class does not inherit default methods from its interfaces; so, you cannot access it using the class instance.

//        public void defaultInterfaceMethodS()
//        {
//            Console.WriteLine("Virtual function in base class...");
//        }
//    }
//    public class DerivedClass : Interface1
//    {
//        public void abstractFunction()
//        {
//            Console.WriteLine("Abstract function has been defined in derived class");
//        }
//        //doesnt inherit default interface methods 
//    }
//    internal class AbstractVSInterface
//    {
//        static void Main(String[] args)
//        {
//            //cant create objects of an interface 
//            DerivedClass derivedClass = new DerivedClass();
//            derivedClass.abstractFunction();
//            //derivedClass.defaultInterfaceMethodS(); //-> error 
//            Interface1 inter = new DerivedClass();
//            inter.abstractFunction();
//            inter.defaultInterfaceMethodS();





//        }
//    }
//}

