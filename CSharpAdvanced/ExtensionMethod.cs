//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpAdvanced
//{
//    public class ClassA
//    {
//        public void Func1()
//        {
//            Console.WriteLine("Function 1");
//        }
//        public void Func2() 
//        { 
//            Console.WriteLine("Function 2"); 
//        }
//    }

//    public static class ClassB
//    {
//        public static void Func3(this ClassA a)
//        {
//            Console.WriteLine("Function 3");
//        }

//        public static int CountVowels(this String str)
//        {
//            int count = 0;
//            foreach (char c in str)
//            {
//                if(c=='a' || c=='e' || c == 'i' || c == 'o' || c == 'u')
//                {
//                    count++;
//                }
//            }
//            return count;
//        }


//        public static string Shorten(this String str, int numberOfWords)
//        {
//            if (numberOfWords < 0)
//            {
//                throw new ArgumentOutOfRangeException("number of words should be greater than or equal to 0");
//            }
//            else if(numberOfWords == 0)
//            {
//                return "";
//            }
//            var words = str.Split(' ');
//            if(words.Length <= numberOfWords )
//            {
//                return str;
//            }
//            return string.Join(" ",words.Take(numberOfWords));
//        }
//    }
//    internal class ExtensionMethod
//    {
//        static void Main(string[] args)
//        {
//            ClassA a = new ClassA();
//            a.Func1();
//            a.Func2();
//            a.Func3();

//            String str = "Vaishali";
//            Console.WriteLine(str.CountVowels());

//            string str1 = "Hello my name is vaishali ranjan";
//            Console.WriteLine(str1.Shorten(3));
//        }
//    }
//}
