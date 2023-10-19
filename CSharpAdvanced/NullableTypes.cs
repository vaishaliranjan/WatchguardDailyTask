////**************************************************************************************************************
////                                              NULLABLE VALUE TYPES
////**************************************************************************************************************

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpAdvanced
//{
//    internal class NullableTypes
//    {
//        static void Main(string[] args)
//        {
//            //DateTime date = null; -> ERROR
//            //Nullable<DateTime> date = null;
//            //OR
//            //DateTime? date = null;
//            //// properties: GetValueOrDefault, fields: HasValue, Value
//            //Console.WriteLine("Get Value or Deafault: "+date.GetValueOrDefault()); //returns a default value if null
//            //Console.WriteLine("Has value"+date.HasValue); //returns true/false
//            //Console.WriteLine("Value"+date.Value);//exception if no value /else value








//            //DateTime? date1 = new DateTime(2023, 10, 19);
//            ////DateTime date2 = date1; will throw error as compiler is confused what is null is present -> assigning value to nullable 
//            //DateTime date2 = date1.GetValueOrDefault();
//            //DateTime? date3 = date2;//no error because a value type can easily be assign to a nullable type
//            ////Console.WriteLine(date2);
//            //Console.WriteLine(date3.GetValueOrDefault());








//            DateTime? date = null;
//            //DateTime date2;
//            //if (date != null)
//            //{
//            //    date2 = date.GetValueOrDefault();
//            //}
//            //else
//            //{
//            //    date2 = DateTime.Today;
//            //}
//            //Console.WriteLine(date2);


//            //much more shorter - NULL COALESCING OPERATOR
//            DateTime date2 = date ?? DateTime.Today;
//            //Console.WriteLine(date2);












//            //Console.WriteLine("nullable types");
//            ////int? a = null;
//            //int? a = 24;
//            //if(a is int value)
//            //{
//            //    Console.WriteLine("a: "+value);
//            //}
//            //else
//            //{
//            //    Console.WriteLine("a is null");
//            //}
//            ////or
//            //if (a.HasValue)
//            //{
//            //    Console.WriteLine("a: "+a.Value);
//            //}
//            //else
//            //{
//            //    Console.WriteLine("a is null");
//            //}


//            //if (a != null)
//            //{
//            //    Console.WriteLine("a: "+ a.Value);
//            //}
//            //else
//            //{
//            //    Console.WriteLine("a is null");
//            //}

//            //Conversion from a non nullable to nullable 
//            //int? a = null;
//            //int b = a ?? 0;
//            //Console.WriteLine(b);


//            //int? a = null;
//            //int b = (int)a;//runtime-> if null throws exception

//            //WITH OPERATORS IF ANY ONE OR BOTH ARE NULL -> RESULT NULL
//            //int? a = 10;
//            //int? b = null;
//            //int? c = 10;

//            //a++;//a is 11
//            //a = a * c; //11*10=110
//            //a = a + b;// a is null
//            //Console.WriteLine(a.HasValue);
//            //not true in booleanlogical operator & |

//            //Comparison operator - one or both null-> false otherwise comparison
//            int? a = 10;
//            Console.WriteLine($"{a} >= null is {a >= null}");
//            Console.WriteLine($"{a} < null is {a < null}");
//            Console.WriteLine($"{a} == null is {a == null}");
//            // Output:
//            // 10 >= null is False
//            // 10 < null is False
//            // 10 == null is False

//            int? b = null;
//            int? c = null;
//            Console.WriteLine($"null >= null is {b >= c}");
//            Console.WriteLine($"null == null is {b == c}");
//            // Output:
//            // null >= null is False
//            // null == null is True
//            //== if both null true , only one -> false
//            //!= if both null false, only one -> true


//            //Get to know the types
//            Type typeA = a.GetType();
//            Console.WriteLine(typeA);

//            //Boxing
//            int? x = null;
//            Object obj = x; //boxing
//            int? y =(int?) obj; //Unboxing


//        }


//    }
//}


//**************************************************************************************************************
//                                              NULLABLE REFERENCE TYPES
//**************************************************************************************************************

//using System;
//namespace Nullable
//{
//    public class Hello
//    {
//        //public string? Hi { get; set; }
//        //public string? Hi { get; set; } = null;
//        public  string? Hi { get; set; }
//    }

//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Hello? hello = null;
//            //int? number = null;
//            //Nullable<int> count = null; Nullable value types


//            if (hello != null)
//            {
//                Console.WriteLine(hello.Hi);//null exception
//            }

//        }
//    }
//}