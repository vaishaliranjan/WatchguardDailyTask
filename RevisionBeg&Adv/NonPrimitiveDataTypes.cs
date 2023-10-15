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












////***************************************************  ARRAYS  **********************

//using System;
//namespace CSharpBasic
//{
//    class NonPrimitiveDataTypes
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = new int[3];
//            int[] arr1 = new int[3] { 1, 2, 3 };
//            //if values not provided they get initialized with their default values

//            //ADD
//            arr[0] = 10;
//            arr[1] = 20;
//            arr[2] = 30;

//            //MODIFY
//            arr[2] = 40;

//            //DELETE - TO DELETE AN ELEMENT FROM ARRAY WE CAN CREATE A NEW ARRAY OR SHIFT THE ELEMENTS 


//            //ARRAY LENGTH
//            Console.WriteLine(arr.Length);
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

//using System;
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
//        }
//    }
//}