using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Company
    {
        // public string Name { get; set; }
        public string name;
        public int age;
        public virtual void PrintMessage()
        {
            Console.WriteLine("Printed something");
        }
        //public Company()
        //{

        //    Console.WriteLine("COnstructor called");
        //}
        public Company()
        {
            this.name = name;
            Console.WriteLine("constructor called");
        }
        //public Company(string name )
        //{
        //    this.name = name;
        //    Console.WriteLine("COnstructor called");
        //}
    }
    public class Company2 : Company
    {
        public  override void PrintMessage()
        {
            Console.WriteLine("Printed in 1st derived class");
        }

        //public Company2()
        //{
        //    Console.WriteLine("Second constructor called ");
        //}
        public Company2(string name)
      
        {
            Console.WriteLine("Second constructor called ");
        }
    }
    public class Company3 : Company2
    {
        public override void PrintMessage()
        {

        }
    }
    internal class Constructor
    {
        static void Main(string[] args)
        {
            Company2 c1 = new Company2();

            
            

        }
    }
}

//using System;
//namespace CSharpInter
//{
//    public  class Vehicle
//    {
//        //public  void Run()
//        //{
//        //    Console.WriteLine("Running Vehicle");
//        //} 
//        public static int votes;
//         static Vehicle()
//        {
//            votes = 10;
//        }

//        public virtual void Run()
//        {
//            Console.WriteLine("Running Vehicle");
//        }

//        public static void EatFood()
//        {
//            Console.WriteLine("can eat food in a vehicle");
//        }
//    }
//    public class Car: Vehicle
//    {
//        //public  void Run()
//        //{
//        //    Console.WriteLine("Car running");
//        //}

//        //public new void Run()
//        //{
//        //    Console.WriteLine("Car running");
//        //}
//        //public static override void EatFood()
//        //{

//        //}
//        static Car()
//        {
//            votes = 11;
//        }
//        public sealed override void Run()
//        {
//            Console.WriteLine("Car running");
//            //Vehicle.EatFood();
//        }
//        private void Horn()
//        {
//            Console.WriteLine("Horn");
//        }
//    }

//    public class Kia : Car
//    {
//        public void CallRun()
//        {
//            Run();
//            //Horn();
//        }

//    }

//    public class KiaSeltos: Kia
//    {

//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //how can i call the run method of vehicle class with an object of derived class?
//            //same name functions
//            //Car car = new Car();
//            //((Vehicle)car).Run(); //explicitly casting would be required
//            //Vehicle vehicle = new Vehicle();
//            //vehicle.Run();
//            //Car car = new Car();
//            //car.Run();

//            Kia kia = new Kia();
//            kia.Run();
//            kia.CallRun();
//            //kia.Horn();
//            KiaSeltos kiaSeltos = new KiaSeltos();
//            kiaSeltos.Run();

//            //Static methods are by default sealed. So it cant be override but it will be inherited by derived class.
//            Kia.EatFood();
//            Car.EatFood();
//            KiaSeltos.EatFood();
//        }
//    }
//}