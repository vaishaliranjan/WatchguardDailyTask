//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public delegate void HelloFunctionDelegate(string message);
//namespace CSharpAdvanced
//{
//    public class Something
//    {
//        internal static void Hello(string message)
//        {
//            Console.WriteLine(message);
//        }

//        internal static void HelloYaar(string message)
//        {
//            Console.WriteLine(message);
//        }
//    }
//    internal class Delegates: Something
//    {
//        static void Main(string[] args)
//        {
//            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
//            del("Hello from delegate.");
//            del = HelloYaar;
//            del("From another hellofunction");
//            //Hello("Simple Hello");
//        }

//    }
//}
///* WHY DO WE NEED DELEGATES?
// * What is the benefit of calling a method indirectly via a pointer or directly?
// * delegate is a represetive to communicate between two parties.
// * C# delegate communication between two thing 
// * For designing extensible and flexible applications(eg frameworks)
// * */

//using System;
//namespace Delegates
//{
//    //PHOTO CLASS
//    public class Photo
//    {
//        public static Photo Load(string path)
//        {
//            return new Photo();
//        }
//        public void Save()
//        {

//        }
//    }

//    //PHOTO PROCESSOR 
//    public class PhotoProcessor { 

//        //public delegate void PhotoFilterHandler(Photo photo);
//        public void Process(string path, Action<Photo> filterHandler)
//        {

//                //Func points to a method that returns value
//                //Action points to a method that returns void
//            var photo = Photo.Load(path);
//            //var filters = new PhotoFilter();
//            //filters.ApplyBrightness(photo);
//            //filters.ApplyContrast(photo);
//            //filters.Resize(photo);
//            filterHandler(photo);
//            photo.Save();


//        }
//    }
//    //Photo filter
//    public class PhotoFilter
//    {
//        public void ApplyBrightness(Photo photo)
//        {
//            Console.WriteLine("Brightness applied!");
//        }

//        public void ApplyContrast(Photo photo)
//        {
//            Console.WriteLine("Contrast applied!");
//        }
//        public void Resize(Photo photo)
//        {
//            Console.WriteLine("Resized!!");
//        }
//    }
//    public class Program
//    {
//        //delegates help us to create program extensible
//        static void Main(string[] args)
//        {
//            PhotoProcessor processor = new PhotoProcessor();
//            //processor.Process("path");
//            var filters = new PhotoFilter();
//            Action<Photo> filterHandler = filters.ApplyBrightness;
//            filterHandler = filters.ApplyContrast;
//            filterHandler = RedEyeFilter;
//            processor.Process("path", filterHandler);
//        }
//        static void RedEyeFilter(Photo photo)
//        {
//            Console.WriteLine("Red eye filter applied!!");
//        }
//    }
//}



//****************************************************************
//*                     DELEGATE BY KUDVENKAT                    *
//****************************************************************

//using System;
//namespace CSharpInter
//{
//    public delegate bool IsPromotable(Employee employee);
//    public class Employee
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }
//        public int Experience { get; set; }


//        public static void PromoteEmployee(List<Employee> employees, IsPromotable IsEligibleToPromote)
//        {
//            foreach (Employee employee in employees)
//            {
//                //if(employee.Experience > 5)
//                //{
//                //    Console.WriteLine(employee.Name + " promoted!!");
//                //}
//                if (IsEligibleToPromote(employee))
//                {
//                    Console.WriteLine(employee.Name + " promoted!!");
//                }
//            }
//        }
//    }
//    //now each and every company wants to use this class but their criteria of promoting an employee is different 
//    //i want this promote method to be flexible
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Employee> list = new List<Employee>();
//            list.Add(new Employee() { ID=101, Name="Mary", Salary=5000, Experience=5});
//            list.Add(new Employee() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 });
//            list.Add(new Employee() { ID = 103, Name = "John", Salary = 6000, Experience = 6 });
//            list.Add(new Employee() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 });
//            // Employee.PromoteEmployee(list);
//            //IsPromotable isPromotable = new IsPromotable(Promote);

//            //Employee.PromoteEmployee(list, isPromotable);

//            Employee.PromoteEmployee(list, e=> e.Experience>=5);
//        }
//        public static bool Promote(Employee emp)
//        {
//            if (emp.Experience > 5)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//    }
//}