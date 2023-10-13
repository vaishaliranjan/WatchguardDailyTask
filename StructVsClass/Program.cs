////************************************* STRUCTURE ***************************************************

//namespace StructVsClass
//{
//    internal class Program
//    {
//        struct Employee
//        {
//            public int Id;
//            public string Name;

//            //public Employee()
//            //{
//            //    Id = 1;
//            //    Name = "Vaishali";
//            //}
//            public Employee(int id)
//            {
//                Id = id;
//                Name = "Name";
//            }
//            public Employee(int id, string name)
//            {
//                Id = id;
//                Name = name;
//            }
//        }

//        static void Main(string[] args)
//        {
//            Employee emp1 = new Employee();
//            Console.WriteLine("Parameterless Constructor: " + emp1.Id + " " + emp1.Name);
//            Employee emp2 = new Employee(2);
//            Console.WriteLine("Id Constructor: " + emp2.Id + " " + emp2.Name);
//            Employee emp3 = new Employee(3, "Vaishali");
//            Console.WriteLine("Id Name Constructor: " + emp3.Id + " " + emp3.Name);
//        }
//    }
//}


//************************************* Classes ***************************************************

namespace StructVsClass
{
    internal class Program
    {
        public class Employee
        {
            public int Id;
            public string Name;

            public Employee()
            {
                Id = 1;
                //Name = "Vaishali";
            }
            public Employee(int id)
            {
                Id = id;
                //Name = "Name";
            }
            public Employee(int id, string name)
                :this(id)
            {
                Name = name;
            }
        }

        static void Main(string[] args)
        {
           // Employee emp1 = new Employee();
            //Console.WriteLine("Parameterless Constructor: " + emp1.Id + " " + emp1.Name);
            Employee emp2 = new Employee(2);
            Console.WriteLine("Id Constructor: " + emp2.Id + " " + emp2.Name);
            Employee emp3 = new Employee(3, "Vaishali");
            Console.WriteLine("Id Name Constructor: " + emp3.Id + " " + emp3.Name);
        }
    }
}
