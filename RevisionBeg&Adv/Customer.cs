//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RevisionBeg_Adv
//{
//    class Person
//    {
//        private int _id;
//        private string _name;

//        public Person(int id, string name)
//        {
//            _id = id;
//            _name = name;
//        }
//        private int CalculateSalary()
//        {
//            int method = 10;
//            method = 10 * 100873 + 556;
//            return method;
//        }

//        public void GetSalary()
//        {
//            int salary= CalculateSalary();
//            Console.WriteLine(salary);
//        }
//    }
//    internal class Abstraction
//    {
//        static void Main(string[] args)
//        {
//            //  Person p = new Person(2,"Vaishali");
//            //p.GetSalary();

//            Console.WriteLine("Hello");

//            Console.ReadLine();

//        }
//    }
//}


//using System;
//namespace CSharpInter
//{
//    class Customer
//    {
//        public int Id;
//        public string Name;

//        public void Add()
//        {
//            this.Validate();
//            this.Update();
//        }
//        private bool Validate()
//        {
//            return true;
//        }
//        public void Update()
//        {
//            return true;
//        }
//    }
//}