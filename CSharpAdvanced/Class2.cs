//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Channels;
//using System.Threading.Tasks;
//namespace CSharpAdvanced
//{
    

//    internal class Program
//    {
//        public delegate int Add(int x, int y);
//        public delegate void Del1();
//        static void Main(string[] args)
//        {


//            //Add del = new Add(Add1);



//            //Anonymous method
//            //Add del = new Add(delegate (int x, int y)
//            //{
//            //    Console.WriteLine("Anonymous func is called!!");
//            //    Console.WriteLine("Calculating addition");
//            //    return x + y;
//            //});




//            ////Lambda expressions
//            //Add del =( x,y) =>
//            //{
//            //    Console.WriteLine("Inside delegate");
//            //    return x + y;
//            //};
//            //int result = del.Invoke(3, 4);
//            //Console.WriteLine(result);

//            //Del1 delegatee =() => Console.WriteLine("Hello");
//            //delegatee.Invoke();



//            //-----------------Func
//            //Func with normal function
//            Func<int, int, int> Func1 = Add1;
//            //Console.WriteLine(Func1(2, 3));

//            Func<string> Func2 = new Func<string>(Print);
//           // Console.WriteLine(Func2.Invoke());


//            //Func with anonymous
//            Func<int, int> Func3 = new Func<int, int>(delegate (int x)
//            {
//                return x + 1;
//            });
//            //Console.WriteLine(Func3(9));

//            //Func with lambda expression
//            Func<int,int, int> Func4 = (x, y) =>  x + y;
//            //Console.WriteLine(Func4(3,5));




//            //------------------------ACTION

//            //Action<> action1 = new Action<>(OnlyForAction); //doesnt work with function which has zero num of parameters 
//            Action<string> action1 = OnlyForAction;
//            //action1.Invoke("Hello computer ji");

//            //with anonymous
//            Action<string> action2 = new Action<string>(delegate (string message)
//            {
//                Console.WriteLine(message);
//            });
//            //action2.Invoke("nhi ji");

//            //with lambda 
//            Action<string> action3 = x => Console.WriteLine(x);
//            //action3.Invoke("Aur bhai");

//            Action<int, int> action4 = TwoParams;
//            action4.Invoke(4,5);




//            //----------------------------PREDICATE

//            Predicate<string> checkLength = CheckLength;
//            Console.WriteLine(checkLength("My name is Vaishali"));


//            Predicate<string> checkLength1 =x=> x.Length>5 ;
//            Console.WriteLine(checkLength1("Aurbhai"));

//            Predicate<int> checkNum = new Predicate<int>(delegate(int num)
//            {
//                return num == 10;
//            });
//            Console.WriteLine(checkNum);

//        }

//        public static bool CheckLength(string message)
//        {
//            return message.Length > 5;
//        } 




//        public static void TwoParams(int x, int y)
//        {
//            Console.WriteLine(x+y);
//        }
//        public static string Print()
//        {
//            return "Print fuction";
//        }
//        public static int Add1(int a, int b)
//        {
//            return a + b;
//        }

//        public static void OnlyForAction(string input)
//        {
//            Console.WriteLine(input);
//        }
//    }
//}
