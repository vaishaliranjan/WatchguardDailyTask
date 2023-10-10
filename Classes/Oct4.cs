using System;

namespace CSharpInt
{

    //------------------------------------------------------Private Constructor 

    public class Animal
    {
        public static int legs;
        public static string name;
        public string breed;
        public int ears;
        private Animal()
        {
            Console.WriteLine("The constructor has been called!");
        }

        private Animal(string breed)
        {
            this.breed = breed;
            Console.WriteLine("{0} has been created", breed);
        }

        private Animal(string breed, int ears)
            : this(breed)
        {
            
            this.ears = ears;
            Console.WriteLine("I got this much of ears: "+ ears);

        }
        public static void Legs()
        {
            Animal animal = new Animal();
            Console.WriteLine("THis Leg function has been called!!!!");
        }
    }

    //---------------------------------------------STATIC CONSTRUCTOR -------------------
    public  class Vehicle
    {
        public static int tyres;
        public static string name;
       

        public Vehicle()
        {
            Console.WriteLine("COns called");
        }
        static Vehicle()
        {
            tyres = 5;
            name = "Car";
            Console.WriteLine("Static constructor is called");
        }
        public int add()
        {
           return ++tyres;
        }
    }
    class Oct4
    {
        static void Main(string[] args)
        {
            //Animal a = new Animal(); - cant be created as wehave private constructor 
            //Animal.Legs();
            //Animal a = new Animal("Labrador", 2);

            Vehicle v = new Vehicle();
            Vehicle.tyres = 6;

            v.add();
            Vehicle v1= new Vehicle();
            v1.add();
            Console.WriteLine(Vehicle.tyres);
            Console.WriteLine();
            //Console.WriteLine(Vehicle.tyres);
            //Person p1 = new Person();
            //// var p2 = new Person();
            //p1.Name = "Vaishali";
            //p1.Introduce("Ritika");

            //Default Constructor call
            // Customer customer = new Customer();
            //Initialize with default values;
            //Console.WriteLine(customer.id);
            //Console.WriteLine(customer.Name);

            // Order order = new Order(); //null object

            // customer.Orders.Add(order); // throws null exception


            // Customer c1 = new Customer(2);
            //// Console.WriteLine(c1.id);
            // c1.Orders.Add(order);

            // Customer c2 = new Customer(3,"Ritika");

            // c2.Orders.Add(order);
            //// Console.WriteLine("C2 id: "+c2.id);




            ///////////////////Object Initializers/////////////////
            ///without constrctor; - to avoid multiple calls                    
            ///
            //Customer c3 = new Customer { id = 3, Name = "Watchguard" };
            //Console.WriteLine(c3.Name);

            //Customer vaishali = new Customer(2);
            //vaishali.Orders.Add(new Order());
            //vaishali.Orders.Add(new Order());
            //vaishali.Promote();
            ////acidentlly reinitialized the field 
            //Console.WriteLine(vaishali.Orders.Count);

        }
    }
}
