//namespace Interface
//{
//    public interface IPerson
//    {
//        //static fields
//        public static int votes;
//        private static int votes_count;

//        //constant fields
//        public const int likes = 0;

//        //abstract methods
//        void PrintName();
//        void PrintVotes();
//        //implemented methods
//        void Name()
//        {
//            Console.WriteLine("Implemented function in interface is called");
//        }
//        static void StaticMethod()
//        {
//            Console.WriteLine("Static method in interface is called");
//        }
//    }


//    public class Vaishali : IPerson
//    {
//        //ExplicitImplementation -> do not use public modifier with explicit implementation
//         void IPerson.PrintName()
//        {
//            Console.WriteLine("Derived fun -> implemented");

//        }
//        public void PrintVotes()
//        {
//            Console.WriteLine("Defined method in derived class");
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //static fields 
//            IPerson.votes = 12;
//            //IPerson.votes_count = 10; -> private

//            //constant fields 
//            //IPerson.likes = 45; -> constant
//            Console.WriteLine(IPerson.likes);

//            //static methods
//            IPerson.StaticMethod();

//            //Calling implemented function in interface through derived class Object
//            Vaishali vaishali = new Vaishali();
//           // vaishali.PrintName();
//            //vaishali.Name(); -> error as a defined method -> it means that implemented func of interfaces arent inherited
//            IPerson iperson = new Vaishali(); //this is possible
//            iperson.Name();


//            //static methods, static members, const fields arent inherited  
//            //iperson.likes = 10;
//            //iperson.votes = 30;

//            //As we have explicitly implemented PrintName func -> so we can access using instance of interface types only.

//            IPerson p = new Vaishali();
//            p.PrintName();
//            //vaishali.PrintName()://error


//        }
//    }
//}