////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace CSharpAdvanced
////{
////    internal class LambdaExpressions
////    {
////        static void Main(string[] args)
////        {
////            //Lambda Expression
////            // args => expressions
////            //Func<int,int> square=number => number*number;

////            //Console.WriteLine(square(5));
////            //Console.WriteLine(Square(5));

////            const int factor = 5;
////            Func<int, int> multiplier = n => n * factor;
////            Console.WriteLine(multiplier(10));
////        }
////        public static int Square(int number)
////        {
////            return number * number;
////        }
////    }
////}

//using System;
//namespace CSharpInter
//{
//    public class Book
//    {
//        public string Title;
//        public int Price;
//    }
//    public class BookList
//    {
//        public List<Book> GetBooks()
//        {
//            return new List<Book>()
//            {
//                new Book(){Title="Book1", Price=5},
//                new Book(){Title="Book2", Price=10}
//            };
//        }
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> list = new List<int>(){ 1,2};
//            Book book = new Book() { Title="Bas", Price = 5};
//            List<Book> listBook = new List<Book>();
//            listBook.Add(book);
//            //Normal way
//            var books = new BookList().GetBooks();
//            //var cheapBooks = books.FindAll(IsCheaperThan10dollars);
//            //so we would need to create a function to check some condition 

//            //=> lambda operator -> book goes to book.Price <10
//            //USING LAMBDA EXPRESSION
//            var cheapBooks = books.FindAll(b => b.Price < 10);
//            foreach (var book in cheapBooks)
//            {
//                Console.WriteLine(book.Title);
//            }
//        }
//        //this is a predicate 
//        static bool IsCheaperThan10dollars(Book book)
//        {
//            return book.Price < 10;
//        }
//    }
//}


