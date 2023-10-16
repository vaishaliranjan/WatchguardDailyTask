////************************************* STRUCTURE ***************************************************

//namespace StructVsClass
//{
//    internal class Program
//    {
//        struct Employee
//        {
//            public int Id;
//            public string Name;

//            //public Employee()
//            //{
//            //    Id = 1;
//            //    Name = "Vaishali";
//            //}
//            public Employee(int id)
//            {
//                Id = id;
//                Name = "Name";
//            }
//            public Employee(int id, string name)
//            {
//                Id = id;
//                Name = name;
//            }
//        }

//        static void Main(string[] args)
//        {
//            Employee emp1 = new Employee();
//            Console.WriteLine("Parameterless Constructor: " + emp1.Id + " " + emp1.Name);
//            Employee emp2 = new Employee(2);
//            Console.WriteLine("Id Constructor: " + emp2.Id + " " + emp2.Name);
//            Employee emp3 = new Employee(3, "Vaishali");
//            Console.WriteLine("Id Name Constructor: " + emp3.Id + " " + emp3.Name);
//        }
//    }
//}














//************************************* Classes ***************************************************

//namespace StructVsClass
//{
//    internal class Program
//    {
//        public class Employee
//        {
//            public int Id;
//            public string Name;

//            public Employee()
//            {
//                Id = 1;
//                //Name = "Vaishali";
//            }
//            public Employee(int id)
//            {
//                Id = id;
//                //Name = "Name";
//            }
//            public Employee(int id, string name)
//                : this(id)
//            {
//                Name = name;
//            }
//        }

//        static void Main(string[] args)
//        {
//            // Employee emp1 = new Employee();
//            //Console.WriteLine("Parameterless Constructor: " + emp1.Id + " " + emp1.Name);
//            Employee emp2 = new Employee(2);
//            Console.WriteLine("Id Constructor: " + emp2.Id + " " + emp2.Name);
//            Employee emp3 = new Employee(3, "Vaishali");
//            Console.WriteLine("Id Name Constructor: " + emp3.Id + " " + emp3.Name);
//        }
//    }
//}












//***************************************************  ARRAYS  **********************

//using System;
//namespace CSharpBasic
//{
//    class NonPrimitiveDataTypes
//    {
//        static void Main(string[] args)
//        {
/*int[] arr = new int[3];
int[] arr1 = new int[3] { 1, 2, 3 };
//if values not provided they get initialized with their default values

//ADD
arr[0] = 10;
arr[1] = 20;
arr[2] = 30;

//MODIFY
arr[2] = 40;

//DELETE - TO DELETE AN ELEMENT FROM ARRAY WE CAN CREATE A NEW ARRAY OR SHIFT THE ELEMENTS 


//ARRAY LENGTH
Console.WriteLine(arr.Length);*/

//SINGLE DIMENSION ARRAY
//int[] arr = new int[2] { 1, 2 };
//int[] arr2 = { 1, 2, 3 };


//MULTI DIMENSIONAL ARRAY
//int[,] arr4 = new int[3, 3];
//int[,] arr5 = new int[3, 3] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
//int[,] arr6 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

//for (int i = 0; i < arr6.GetLength(0); i++)
//{
//    for (int j = 0; j < arr6.GetLength(1); j++)
//    {
//        Console.Write(arr6[i,j]);
//    }
//}


//JAGGED ARRAY
//int[][] arr = new int[2][];
//arr[0] = new int[4];
//arr[0][0] = 1;
//arr[0][1] = 2;
//arr[0][2] = 3;
//arr[0][3] = 4;

//arr[1] = new int[3] { 5, 6, 7 };

//for(int i = 0; i < arr.Length; i++)
//{
//    for(int j=0; j < arr[i].Length; j++)
//    {
//        Console.WriteLine(arr[i][j]);
//    }
//}
//        }
//    }
//}









//***************************************************  LISTS  **********************
/*
using System;
namespace CSharpBasic
{
    class NonPrimitiveDataTypes
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>() { 1, 2 };
            //int[] arr = new int[3] { 1, 4, 5 };
            //Console.WriteLine(list.Count);
            ////Capacity
            //Console.WriteLine(list.Capacity);

            ////ADD OPERATION 
            //list.Add(3); //normal add element
            //list.AddRange(arr);//add whole array
            //list.Insert(0, 4);//add 4 at 0th index

            ////UPDATE OPERATION
            //list[3] = 8;

            ////DELETE OPERATIONS 
            //list.Remove(3); //remove the first occurence of 3
            //list.RemoveAt(0);//remove element at 0th index
            //list.Clear();//clear list

            ////SEARCHING
            //list.Contains(3); //returns true/false 
            //list.IndexOf(8); //return the index of first occurence of element 8
            //list.LastIndexOf(3);


            ////SORTING 
            //list.Sort();
            //list.Reverse();

            ////Copying to array
            //int[] arr1 = list.ToArray();



            //List<int> list = new List<int>();
            //list.Add(1);
            //list.RemoveAt(0);
            //Console.WriteLine(list[0]);
        }
    }
} */















//*************************************** ARRAYLIST ******************************
/*
using System;
using System.Collections;

namespace CSharpBasics
{
    class NonPrimitiveDataTypes
    {
        static void Main(string[] args)
        {
            Object[] obj = new object[] { 1, "Hello" };

            ArrayList list = new ArrayList();
            
            //ADD
            list.Add('a');
            list.AddRange(obj);

            //Insert
            list.Insert(0, 2);

            //Modify
            list[0] = "Vaishali";

            //Delete
            list.Remove(2);
            list.RemoveAt(0);
            list.Clear();


            //Search
            bool contains = list.Contains(3.14); // Checks if 3.14 is in the ArrayList
            int index = list.IndexOf("world"); // Gets the index of the first occurrence of "world"
            int lastIndex = list.LastIndexOf("world"); // Gets the index of the last occurrence of "world"

            //Sort
            list.Sort();

            foreach(object ob in list)
            {
                Console.WriteLine(ob);
            }

            int capacity = list.Capacity;
            int count = list.Count;

            list.TrimToSize();
        }
    }
} */











//************************************ENUM*******************


//namespace CSharpInter
//{
//    enum Color
//    {
//        pink,//0
//        blue,//1
//        green,//3
//        red//4
//    }
//    class NonPrimitiveDataTypes
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Color.red);
//            Console.WriteLine((int)Color.red);
//            Color c = (Color)2;
//            Console.WriteLine(c);
//            Color cl = (Color)4;
//            Console.WriteLine(cl);
//        }
//    }
//}

//************************************************************CONTROL FLOW ************************************

///////////////////////////////////////////////FOR/WHILE/ DO WHILE/ FOREACH /////////////////////////
///

//using System;
//namespace CSharpBasic
//{
//    class ForLoop
//    {

//        static void Main(string[] args)
//        {
//            Console.WriteLine("For Loop: ");
//            for (int i=0; i< 10; i++)
//            {
//                Console.Write(i + " ");
//            }
//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine("While Loop: ");
//            int j = 0; 
//            while (j < 10)
//            {
//                Console.Write(j + " ");
//                j++;
//            }
//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine("Do While Loop: ");
//            int k = 0;
//            do
//            {
//                Console.Write(k + " ");
//                k++;
//            } while (k < 10);
//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine("For Each Loop: ");
//            string[] arr = { "Vaishali", "Ranjan" };
//            foreach(string s in arr)
//            {
//                Console.Write(s+" ");
//            }
//            Console.WriteLine();
//        }
//    }
//}


//************************************************************* STRING AND STRINGBUILDER ********************************

//using System;
//namespace CSharpBasics
//{
//    class Program
//    {
//        //Various Methods in Strings- 
//            /* 
//            1. Concatenation - + operator 
//            2. Substring- str.Substring(startIndex,length)
//            3. String Format
//            4. Strings and indexes - str.IndexOf("find") or strIndexOf("find", startIndex)
//            5. Null strings and Empty strings 
//            6. String Comparison and Equality - ==, str1.Equals(str2), STATIC: obj.RefrenceEquals(str1,str2)
//            7. Sort- STATIC Array.Sort(strArray)
//            8. Length- str.Length
//            9. Formatting
//            10. Replacing str.Replace("one","another")
//            11. Null checking- STATIC String.IsNullOrEmpty(str) or String.IsNullOrWhitespace(str)
//            12. Splitting- str.Split("given")
//            13. Converting string to numbers-   STATIC int.Parse(str) or Convert.ToInt32(str)
//            14. Converting numbers to string-  i.ToString()
//           */
//        static void Main(string[] args)
//        {
//            string str;
//            //Console.WriteLine(str); -> error use of uninitialized value
//            string str1 = null;
//            //Console.WriteLine(str1);

//            string str2= String.Empty;
//            //Console.WriteLine(str2);

//            string s1 = "Vaishali";
//            string s2 = new string(s1);
//            //Console.WriteLine(Object.ReferenceEquals(s1,s2)); - False 
//            //Console.WriteLine(s1==s2); - True 
//            //Console.WriteLine(s1.Equals(s2)); True 

//            string s3 = s1;
//            //Console.WriteLine(Object.ReferenceEquals(s1, s3)); -True
//            //Console.WriteLine(s1 == s3); -True
//            //Console.WriteLine(s1.Equals(s3)); -True
//            //Console.WriteLine(Object.ReferenceEquals(s2, s3)); //false
//            //Console.WriteLine(s2 == s3); //false
//            //Console.WriteLine(s2.Equals(s3)); //false

//            string s4 = "Vais" + "hali";
//            //Console.WriteLine(Object.ReferenceEquals(s1, s4)); //true 
//            //Console.WriteLine(s1 == s4);//true
//            //Console.WriteLine(s1.Equals(s4));//true

//            //Console.WriteLine(Object.ReferenceEquals(s2, s4)); //false  WHYYYYY????????????
//            //Console.WriteLine(s2 == s4); //true
//            //Console.WriteLine(s2.Equals(s4)); //true

//            string s5 = "Vais";
//            string s6 = "hali";
//            string s7 =String.Intern (s5 + s6);
//            //Console.WriteLine(Object.ReferenceEquals(s1, s7)); //false -> runtime create new string INTERN checks in pool-> true
//            //Console.WriteLine(s1 == s7); //true
//            //Console.WriteLine(s1.Equals(s7)); //true


//            //SUBSTRING 
//            string stri = "Vaishali Ranjan";
//            Console.WriteLine(stri.Substring(3,4)); //start index and length ->object function

//            //IndexOF
//            Console.WriteLine(stri.IndexOf("Va"));
//            Console.WriteLine(stri.IndexOf("ai",3));
//            Console.WriteLine();

//            //Length
//            Console.WriteLine(stri.Length); 

//            //Replace 
//            Console.WriteLine(stri.Replace("V", "R"));

//            var arr = stri.Split(" ");
//            foreach (string s in arr) Console.WriteLine(s);


//            Console.WriteLine(String.IsNullOrEmpty(stri));
//            Console.WriteLine(String.IsNullOrWhiteSpace(stri));

//            //string to int 
//            string ss = "10";
//            int i= Int32.Parse(ss);
//            int j = Convert.ToInt32(i);

//            //int to string 
//            int k = 10;
//            string sss= k.ToString();
//        }
//    }
//}




//STRINGBUILDER
//using System;
//using System.Text;

//namespace CSharpBasic
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            StringBuilder sb = new StringBuilder("Vaishali");
//            Console.WriteLine(sb[2]);
//            sb.Append(" ");
//            sb.AppendLine();
//            var length =sb.Length;
//            var capacity = sb.Capacity;
//            sb.Clear();
//            Console.WriteLine(sb);
//        }
//    }
//}