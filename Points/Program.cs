using System;

namespace CSharpInter
{

    public class Oct5
    {
        static void Main(String[] args)
        {
            

        }
        static void Tryparse()
        {
            //int number = int.Parse("abc"); // throws an exception 
            int number1;
            var done = int.TryParse("abc", out number1); //it return tru if successfull elce false 
            Console.WriteLine(done);

        }
        static void useCalculator()
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.Sum(1, 2, 3, 45, 5));
            Console.WriteLine(c.Sum(new int[] { 1, 2, 3, 4 }));
        }
        static void usePoint()
        {
            try
            {
                Point p = new Point(10, 10);
                Console.WriteLine("The points are {0},{1} ", p.x, p.y);
                p.Move(20, 30);
                Console.WriteLine("The points are {0},{1} ", p.x, p.y);
                p.Move(new Point(50, 35));
                Console.WriteLine("The points are {0},{1} ", p.x, p.y);

                p.Move(null);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured!");
            }
        }
    }
}