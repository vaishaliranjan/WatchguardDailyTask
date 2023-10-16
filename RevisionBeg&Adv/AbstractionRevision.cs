//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RevisionBeg_Adv
//{


//        class Customer
//        {
//            public int Id;
//            public string Name;

//            public void Add()
//            {
//                this.Validate();
//                this.Update();
//            }
//            private bool Validate()
//            {
//                return true;
//            }
//            public bool Update()
//            {
//                return true;
//            }
//        }

//    internal class AbstractionRevision
//    {
//        static void Main(string[] args)
//        {
//            Customer c = new Customer();
//            c.Add();
//        }
//    }

//}
using System;
namespace CSharpInter
{

    // Abstract class
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method
        }
    }
}