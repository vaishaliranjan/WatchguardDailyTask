using System;

namespace CSharpInt
{


    class Oct4
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person();
            //// var p2 = new Person();
            //p1.Name = "Vaishali";
            //p1.Introduce("Ritika");

            //Default Constructor call
           // Customer customer = new Customer();
            //Initialize with default values;
            //Console.WriteLine(customer.id);
            //Console.WriteLine(customer.Name);

            Order order = new Order(); //null object

           // customer.Orders.Add(order); // throws null exception


            Customer c1 = new Customer(2);
           // Console.WriteLine(c1.id);
            c1.Orders.Add(order);

            Customer c2 = new Customer(3,"Ritika");

            c2.Orders.Add(order);
           // Console.WriteLine("C2 id: "+c2.id);




            ///////////////////Object Initializers/////////////////
            ///without constrctor; - to avoid multiple calls 
            ///
           // Customer c3 = new Customer { id = 3, Name = "Watchguard" };
            //Console.WriteLine(c3.Name);

            Customer vaishali = new Customer(2);
            vaishali.Orders.Add(new Order());
            vaishali.Orders.Add(new Order());
            vaishali.Promote();
            //acidentlly reinitialized the field 
            Console.WriteLine(vaishali.Orders.Count);

        }
    }
}
