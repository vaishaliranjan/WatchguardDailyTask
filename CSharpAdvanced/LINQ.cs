//namespace LINQ
//{
//    //Language Integrated Query
//    //Gives you capability to query objects.
//    //You can query -> objects in memory, databases, XML

//    public class Book
//    {
//        public string Title { get; set; }
//        public float Price { get; set; }
//        public Book(string title, float price)
//        {
//            Title = title;
//            Price = price;
//        }
//    }

//    public class BookRepo
//    {
//        public List<Book> GetBooks()
//        {
//            return new List<Book>{
//                    new Book("Jab we met",10.3f),
//                    new Book("Haule Haule", 5.3f),
//                    new Book("Jawan",8.3f),
//                    new Book("Bolo na", 5.4f),
//                    new Book("Haule Haule", 7.3f)

//                };
//        }
//    }
//    internal class Program
//    {


//        static void Main(string[] args)
//        {
//            var books = new BookRepo().GetBooks();
//            //All these are extension methods
//            //var cheapBooks = new List<Book>();

//            //foreach (var book in books)
//            //{
//            //    if (book.Price < 11)
//            //    {
//            //        cheapBooks.Add(book);
//            //    }
//            //}
//            //LINQ QUERY OPERATORS-> always starts with from and ends with select
//            //var cheaperBooks = from b in books
//            //                   where b.Price < 11
//            //                   orderby b.Title
//            //                   select b.Title;
//            //foreach (var book in cheaperBooks)
//            //{
//            //    //Console.WriteLine("Book Title: "+ book.Title+" Price: "+ book.Price);
//            //    Console.WriteLine(book);
//            //}

//            //Console.WriteLine();

//            ////LINQ EXTENSION METHODS 
//            //var cheapBooks = books
//            //                      .Where(b => b.Price < 11)
//            //                      .OrderBy(b => b.Title)
//            //                      .Select(b => b.Title); //book will be a string then if used select
//            ////cheapBooks.OrderBy(b => b.Title);
//            //foreach (var book in cheapBooks)
//            //{
//            //    //Console.WriteLine("Book Title: "+ book.Title+" Price: "+ book.Price);
//            //    Console.WriteLine(book);
//            //}

//            //where return a list
//            //SINGLE RETURNS A SINGLE OBJECT
//            //var book = books.Single(b => b.Title == "Haule Haule");
//            //Console.WriteLine(book.Title);

//            //var book2 = books.SingleOrDefault(b => b.Title == "Haule Haule");//if two with same name throws exception
//            //if (book2 != null)
//            //{
//            //    Console.WriteLine(book2.Title + book2.Price);
//            //}

//            //FIRST RETURNS THE FIRST MATCHED 
//            //var book = books.First(b => b.Title == "Haule Haule");
//            //Console.WriteLine(book.Title);

//            //var book2 = books.FirstOrDefault(b => b.Title == "Haule Haule");
//            //if (book2 != null)
//            //{
//            //    Console.WriteLine(book2.Title + book2.Price);
//            //}

//            //Last RETURNS THE FIRST MATCHED 
//            //var book = books.Last(b => b.Title == "Haule Haule");
//            //Console.WriteLine(book.Title);

//            //var book2 = books.LastOrDefault(b => b.Title == "Haule Haule");
//            //if (book2 != null)
//            //{
//            //    Console.WriteLine(book2.Title + book2.Price);
//            //}



//            //var pagedBook = books.Skip(1).Take(3);

//            //foreach (var book in pagedBook)
//            //{
//            //    Console.WriteLine("Book Title: "+ book.Title+" Price: "+ book.Price);

//            //}

//            //var count = books.Count();
//            //Console.WriteLine(count);

//            //var maxPrice= books.Max(b=>b.Price);
//            //Console.WriteLine(maxPrice);
//            //var minPrice = books.Min(b => b.Price);
//            //Console.WriteLine(minPrice);

//            //var sumOfPrices = books.Sum(b=>b.Price);
//            //Console.WriteLine(sumOfPrices);
//        }
//    }
//}