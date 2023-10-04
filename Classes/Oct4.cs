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
            Customer customer = new Customer(1,"John");
            //Initialize with default values;
            Console.WriteLine(customer.id);
            Console.WriteLine(customer.Name);

            Order order = new Order(); //null object

            customer.Orders.Add(order); // throws null exception
        }
    }
}
