////namespace LINQ
////{
////    //Language Integrated Query
////    //Gives you capability to query objects.
////    //You can query -> objects in memory, databases, XML

////    public class Book
////    {
////        public string Title { get; set; }
////        public float Price { get; set; }
////        public Book(string title, float price)
////        {
////            Title = title;
////            Price = price;
////        }
////    }

////    public class BookRepo
////    {
////        public List<Book> GetBooks()
////        {
////            return new List<Book>{
////                    new Book("Jab we met",10.3f),
////                    new Book("Haule Haule", 5.3f),
////                    new Book("Jawan",8.3f),
////                    new Book("Bolo na", 5.4f),
////                    new Book("Haule Haule", 7.3f)

////                };
////        }
////    }
////    internal class Program
////    {


////        static void Main(string[] args)
////        {
////            var books = new BookRepo().GetBooks();

////            //All these are extension methods
////            //var cheapBooks = new List<Book>();

////            //foreach (var book in books)
////            //{
////            //    if (book.Price < 11)
////            //    {
////            //        cheapBooks.Add(book);
////            //    }
////            //}
////            //LINQ QUERY OPERATORS-> always starts with from and ends with select
////            //var cheaperBooks = from b in books
////            //                   where b.Price < 11
////            //                   orderby b.Title
////            //                   select b.Title;
////            //foreach (var book in cheaperBooks)
////            //{
////            //    //Console.WriteLine("Book Title: "+ book.Title+" Price: "+ book.Price);
////            //    Console.WriteLine(book);
////            //}

////            //Console.WriteLine();

////            ////LINQ EXTENSION METHODS 
////            //var cheapBooks = books
////            //                      .Where(b => b.Price < 11)
////            //                      .OrderBy(b => b.Title)
////            //                      .Select(b => b.Title); //book will be a string then if used select
////            ////cheapBooks.OrderBy(b => b.Title);
////            //foreach (var book in cheapBooks)
////            //{
////            //    //Console.WriteLine("Book Title: "+ book.Title+" Price: "+ book.Price);
////            //    Console.WriteLine(book);
////            //}

////            //where return a list
////            //SINGLE RETURNS A SINGLE OBJECT
////            //var book = books.Single(b => b.Title == "Haule Haule");
////            //Console.WriteLine(book.Title);

////            //var book2 = books.SingleOrDefault(b => b.Title == "Haule Haule");//if two with same name throws exception
////            //if (book2 != null)
////            //{
////            //    Console.WriteLine(book2.Title + book2.Price);
////            //}

////            //FIRST RETURNS THE FIRST MATCHED 
////            //var book = books.First(b => b.Title == "Haule Haule");
////            //Console.WriteLine(book.Title);

////            //var book2 = books.FirstOrDefault(b => b.Title == "Haule Haule");
////            //if (book2 != null)
////            //{
////            //    Console.WriteLine(book2.Title + book2.Price);
////            //}

////            //Last RETURNS THE FIRST MATCHED 
////            //var book = books.Last(b => b.Title == "Haule Haule");
////            //Console.WriteLine(book.Title);

////            //var book2 = books.LastOrDefault(b => b.Title == "Haule Haule");
////            //if (book2 != null)
////            //{
////            //    Console.WriteLine(book2.Title + book2.Price);
////            //}



////            //var pagedBook = books.Skip(1).Take(3);

////            //foreach (var book in pagedBook)
////            //{
////            //    Console.WriteLine("Book Title: "+ book.Title+" Price: "+ book.Price);

////            //}

////            //var count = books.Count();
////            //Console.WriteLine(count);

////            //var maxPrice= books.Max(b=>b.Price);
////            //Console.WriteLine(maxPrice);
////            //var minPrice = books.Min(b => b.Price);
////            //Console.WriteLine(minPrice);

////            //var sumOfPrices = books.Sum(b=>b.Price);
////            //Console.WriteLine(sumOfPrices);
////        }
////    }
////}

//namespace CSharpInter
//{
//    public class Employee
//    {
//        public string Name;
//        public int Age;
//    }

//    public class Person
//    {
//        public string PersonName;
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Employee> employees = new List<Employee>()
//            {
//                new Employee(){Name="Vaishali", Age=18},
//                new Employee(){Name="Ritika", Age=18},
//                new Employee(){Name="Shakuntala", Age=20},
//                new Employee(){Name="Rajiv", Age=18}
//            };

//            // Filtering -- WHERE
//            IEnumerable<Employee> employeeAge = employees.Where(emp => emp.Age > 18);
//            List<Employee> employeeEighteen = employees.Where(e => e.Age == 18).ToList();

//            //Sorting -- orderby, orderbydescending, thenby,thenbydescending, reverse 

//            IOrderedEnumerable<Employee> nameSorted = employees.OrderBy(emp => emp.Name);
//            IEnumerable<Employee> namesSorted = employees.OrderBy(emp => emp.Name);
//            IEnumerable<Employee> ageSorted = employees.OrderBy(emp => emp.Age).ThenBy(emp => emp.Name);
//           // var reverseOrder = employees.Reverse();


           
//            foreach (Employee emp in ageSorted)
//            {
//               // Console.WriteLine(emp.Name +" "+emp.Age);
//            }


//            //ELEMENTS

//            //First
//            //Employee employee = employees.First(e=> e.Age == 18);
//            //Console.WriteLine(employee.Name); //If not present-> invalid operation exception

//            //Employee employee1 = employees.FirstOrDefault(e => e.Age == 19);
//            //if (employee1 != null)
//            //{
//            //    Console.WriteLine(employee1.Name); //if null-> null reference exception 
//            //}

//            //Last
//            //Employee employee = employees.Last(e => e.Age == 18);
//            //Console.WriteLine(employee.Name); //If not present-> invalid operation exception

//            //Employee employee1 = employees.LastOrDefault(e => e.Age == 19);
//            //if (employee1 != null)
//            //{
//            //    Console.WriteLine(employee1.Name); //if null-> null reference exception 
//            //}

//            //Single- expect us to have only one element else -> throws invalid operation exception
//            //Employee employee = employees.Single(e => e.Age == 20);
//            //Console.WriteLine(employee.Name); //If not present-> invalid operation exception

//            //Employee employee1 = employees.SingleOrDefault(e => e.Age == 19);
//            //if (employee1 != null)
//            //{
//            //    Console.WriteLine(employee1.Name); //if null-> null reference exception 
//            //}


//            //ElementAt(int index)- if not present -out of range exception or ElementAtOrDefault()
//            //Employee empp = employees.ElementAtOrDefault(1);
//            //Console.WriteLine(empp.Name);


//            //IEnumerable<Person> PersonList = employees.Select(e => new Person() { PersonName = e.Name });
//            //foreach (Person person in PersonList)
//            //{
//            //    Console.WriteLine(person.PersonName);
//            //}


//            //int max = employees.Max(e => e.Age);
//            //int min = employees.Min(e => e.Age);
//            //double avg= employees.Average(e => e.Age);
//            //int sum = employees.Sum(e => e.Age);
//            //int count = employees.Count();


//        }
//    }
//}