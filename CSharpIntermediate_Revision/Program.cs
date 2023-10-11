
//****************************************** METHODS **************
//A method is a code block that contains a series of statements. A program causes the statements to be executed by calling the method and specifying any required method arguments

//Method Signature- accessModifier - default private, optional modifiers- abstract- only declaration, virtual- derived class override  & sealed- return type, method name, method parameters separated by commas.

//Method- instance or static - instance->static method call- compile time error
/*
using System;
using System.Xml.Linq;

namespace CSharpRevision
{

    //--------------------Inherited and overridden methods--------

    abstract class Person
    {
        public virtual void Walk()
        {
            Console.WriteLine("I can walk");
        }
        public abstract void Run();

        //NEW -DATA HIDING DOUBT - if both have same func and we have made an object of derived class then how can we call the func of base class?  


        //public void Eat()
        //{
        //    Console.WriteLine("I can eat");
        //}
    }

    class Vaishali: Person
    {
        public override void Walk()
        {
            //base.Walk();
            Console.WriteLine("Vaishali can walk");
        }
        public override void Run()
        {
            Console.WriteLine("Vaishali can run!!");
        }

        //public void Eat()
        //{
        //    Console.WriteLine("Vaishali can eat..");
        //}
    }
    class Program
    {
        public static int Multiply(int i, int j)//-----------PARAMETERS
        {
            // Store input argument in a local variable.

            return i * j;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(2, 3));//----------- ARGUMENTS
            //When using named arguments, you specify the parameter name followed by a colon (":") and the argument.
            Console.WriteLine(Multiply(i: 3, j:3));
            //You can invoke a method using both positional arguments and named arguments.
            Console.WriteLine(Multiply(3, j:5));


            //-----Inherited and overridden methods--
            Vaishali v= new Vaishali();
            v.Walk();
            v.Run();
            //v.Eat();



            //--------------------PASS BY VALUE------

            int i = 10;
            Console.WriteLine("i before: "+ i);
            Change(i);
            void Change(int i)
            {
                i = i + 1;
            }
            Console.WriteLine("i after: " + i);

            //--------------------PASS BY REF------

            int j = 10;
            Console.WriteLine("j before: " + j);
            Change1(ref j);
            void Change1(ref int j)
            {
                j = j + 1;
            }
            Console.WriteLine("j after: " + j);



            //---------------------PARAMS ---------
            //parameter arrays- the requirement that you specify the exact number of arguments to your method is restrictive. By using the params keyword to indicate that a parameter is a parameter array, you allow your method to be called with a variable number of arguments.

            Add(new int[] { 1, 2, 3, 4, 5 });
            Add(1, 2, 3, 4, 5, 6);
            int Add(params int[] arr)
            {
                int sum = 0;
                for(int i=0;i<arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }



            //--------------------------RETURN TYPE 
            Console.WriteLine(AddTwoNumbers(4,5));
            int AddTwoNumbers(int number1, int number2)
            {
                return number1 + number2;
            }

            //More than one return values: ----OUT------
            int remainder;
            int product;
            Multiplication(4, 3, out remainder, out product);
            void Multiplication(int x, int y, out int remainder, out int product)
            {
                remainder = x % y;
                product = x * y;
            }

            //--------------------- IN--------------
            //The in keyword causes arguments to be passed by reference but ensures the argument is not modified

            int readOnlyData = 10;
            ReadDatabyRef(readOnlyData);
            void ReadDatabyRef(in int i)
            {
                Console.WriteLine(i);
                //i++;-- ERROR
            }

            //---------------- DEFAULT-----------
            int z = 10; int y = 9;
            Console.WriteLine(Subtract(z));
            int Subtract(int x,int  y=0)
            {
                return x - y;
            }


            //-------------STATIC METHODS ---------
            //The static keyword is used to create a static method.The static method is the method that can be called without creating an object of the class.
        }






        
    }
}


*/
//*********************************************FIELDS****************************************************
//A field is a variable of any type that is declared directly in a class or struct. Fields are members of their containing type.

//A class or struct may have instance fields, static fields, or both. Instance fields are specific to an instance of a type. By contrast, a static field belongs to the type itself, and is shared among all instances of that type. 


/*
using System;
namespace CSharpRevision
{
    public class Person
    {
        //Fields - Value types- default value -> ref type-> null
        //Instance Fields 
        public int Id;
        public string Name;
        //Static field
        public static int votes;

        //A field can be given an initial value by using the assignment operator when the field is declared.
        public string Day = "Monday";

        //Fields are initialized immediately before the constructor for the object instance is called. If the constructor assigns the value of a field, it overwrites any value given during field declaration.

        //Fields can be marked as public, private, protected, internal, protected internal, or private protected.

        public readonly int Age;
        public static readonly int likes; //-> can only be initialized in constructor

        //A static readonly field is similar to a constant, except that the C# compiler doesn't have access to the value of a static read-only field at compile time, only at run time.
       

        //-------------DOUBT
        
        const int gender = 10;

        
        //public required string FirstName { get; init; }
        //public required string LastName { get; init; }
        public Person()
        {
            Age = 20;
            //A field can be declared readonly. A read-only field can only be assigned a value during initialization or in a constructor
            
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ACCESS INSTANCE FIELD
            Person person = new Person();
            person.Name = "Test";
            //ACCESS STATIC FIELD
            Person.votes = 10;
            //Person.likes = 40;
           

        }

    }


}
*/

// ------------------- METHOD HIDING AND METHOD OVERRIDING ----------------------

/*
public class BaseClass
{
   public void WriteNum()
   {
       Console.WriteLine(12);
   }
   public virtual void WriteStr()
   {
       Console.WriteLine("abc");
   }
}

public class DerivedClass : BaseClass
{
   public new void WriteNum()
   {
       Console.WriteLine(42);
   }
   public override void WriteStr()
   {
       Console.WriteLine("xyz");
   }
}

public class Program
{
   public static void Main()
   {
       BaseClass isReallyBase = new BaseClass();
       BaseClass isReallyDerived = new DerivedClass();
       DerivedClass isClearlyDerived = new DerivedClass();

       isReallyBase.WriteNum(); // 12
       isReallyBase.WriteStr(); // writes
       isReallyDerived.WriteNum(); // writes 12
       isReallyDerived.WriteStr(); // writes xyz
       isClearlyDerived.WriteNum(); // writes 
       isClearlyDerived.WriteStr(); // writes 
   }
}
*/


using System;

namespace Inheritance
{
    public class Person
    {
        protected int Id;

        public void func()
        {
            Person p= new Person();
            Console.WriteLine(p.Id);
        }
    }
    public class Vaishali: Person
    {
        public void CC()
        {
            Vaishali v= new Vaishali();
            Console.WriteLine(v.Id);

            //throws error
            //Person person= new Person();
            //Console.WriteLine(person.Id);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
}