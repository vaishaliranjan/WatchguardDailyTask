//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Classes
//{
//    public class Employee
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Gender { get; set; }
//    }
//    public class Company
//    {
//        private List<Employee> listEmployees;
//        public Company()
//        {
//            listEmployees = new List<Employee>();
//            listEmployees.Add(new Employee() { Id=1, Name="Vaishali", Gender="Female"});
//            listEmployees.Add(new Employee() { Id = 2, Name = "Ritika", Gender = "Female" });
//            listEmployees.Add(new Employee() { Id = 3, Name = "Muskan", Gender = "Female" });
//            listEmployees.Add(new Employee() { Id = 4, Name = "Rits", Gender = "Female" });
           
//        }

//        //accessModifier return type this[indexers]{}
//        public string this[int employeeId]
//        {
//            get
//            {
//                return listEmployees.FirstOrDefault(emp => emp.Id == employeeId).Name;
//            }
//            set
//            {
//                listEmployees.FirstOrDefault(emp => emp.Id == employeeId).Name = value;
//            }
//        }
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Company company = new Company();
//            Console.WriteLine("Employee with id 1"+ company[1]);
//            company[2] = "RITIKA";
//            Console.WriteLine("Employee with id 2" + company[2]);
//        }
//    }
//}
