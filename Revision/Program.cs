using System;
using System.Collections;
using System.Text;
using System.Text.Json.Serialization;

namespace CSharpBeg
{

    public class Person
    {
        public int id;
        public string name;
        public int age;
        public Mood mood;
        public enum Mood
        {
            happy,
            sad
        }
        public Person(Mood mood)
        {
            this.id = 2;
            this.name = "Random";
            this.age = 30;
            this.mood = mood;

        }
        public Person(int id, string name, int age, Mood mood)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            Console.WriteLine(mood);
        }
    }
    class Oct3
    {
        enum Status
        {
            online, 
            offline
        }


        public struct Student
        {
            public int id;
            private string name;
            private int age;

            //default constructor 
            public Student(int id, string name, int age)
            {
                this.id = id;
                this.name = name;   
                this.age = age;
            }

        }


        public struct checkDefault
        {
            public int number;
            public float dec;
            public char ch;
            public string str;
        }




        static void Main(string[] args)
        {
            checkDefault c= new checkDefault();
            //Console.WriteLine(c.number);
            //Console.WriteLine(c.dec);
            //Console.WriteLine(c.str);
            //Console.WriteLine(c.ch);
            //Console.WriteLine("Default value of char: null - ascii value 0:    "+ (int)c.ch);
            //Console.WriteLine("Default value of char: null - ascii value 0:    " + Int32.Parse(c.str)); access to null object - throws a null exception
            //default char null- value 0;


            //Primitive data types 
            int a = 12;
            float b = 12.9e3f;
            decimal f = 12.4e-2m;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            byte d = 255;
            //d = d + 1; doesnt work because + operator first convert others into int and then storing it into a byte //will say no 
            //implicit conversion where as ++ is a uranary operator so doesnt require type conversion 
            Student s1 = new Student();
            //Console.WriteLine(s1.id);

            Student s2 = new Student(2, "Vaishali", 23);
            //Console.WriteLine(s2.id);

            //Person p1 = new Person(); - doesnt work
            //Person p2 = new Person(12, "Vaish", 23, Person.Mood.happy);
            Person p1 = new Person(Person.Mood.happy);
            Person p2 = new Person(Person.Mood.happy);
            Person p3 = new Person(Person.Mood.sad);
            Person p4 = new Person(Person.Mood.sad);
            Person p5 = new Person(Person.Mood.happy);

            //Arrays 
            var arr1 = new[] { p1, p2, p3 };
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine(arr1[i].age + "    Mood: "+ arr1[i].mood);
            //}

            List<Person> list = new List<Person>(); 
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);
            //Console.WriteLine("Count: "+ list.Count);
            //Console.WriteLine("Capacity: "+ list.Capacity);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine("Age: "+ list[i].age + "    Mood: " + list[i].mood);
            //}
            
            //List memory allocation
            List<int> numbers= new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            unsafe
            {
                fixed (int* numArray = numbers.ToArray())
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                       // Console.WriteLine($"Element {i}: Value = {numbers[i]}, Address = {(int)(numArray + i)}");
                    }
                }

            }

            Console.WriteLine();
            numbers.Add(5);
            unsafe
            {
                fixed (int* numArray = numbers.ToArray())
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                      //  Console.WriteLine($"Element {i}: Value = {numbers[i]}, Address = {(int)(numArray + i)}");
                    }
                }

            }
            Console.WriteLine();

            //String builder 

            StringBuilder sb = new StringBuilder("abc");



            unsafe
            {
                StringBuilder* stringBuilder = &sb;
                //Console.WriteLine((int)stringBuilder);
                //Console.WriteLine("Capacity: " + sb.Capacity);
                //Console.WriteLine("Length: " + sb.Length); Console.WriteLine();
                //sb.Append("defqwertyuixcvbndfgh");
                ////sb.AppendLine("12345678910111213141516171819");
                //stringBuilder = &sb;
                
                //Console.WriteLine((int)stringBuilder);
                //Console.WriteLine("Capacity: "+sb.Capacity);
                //Console.WriteLine("Length: "+ sb.Length);

                ////abc defqwertyuixc  + vbndfgh
                //Console.WriteLine();
                //sb.Append("defqwertyuixcvbndfgh");
                //stringBuilder = &sb;
                //Console.WriteLine((int)stringBuilder);
                //Console.WriteLine("Capacity: " + sb.Capacity);
                //Console.WriteLine("Length: " + sb.Length);


            }

            //Pass by reference
            //Console.WriteLine("Pass by reference");
            //int x = 5;
            //Console.WriteLine(x);
            //changeNum(ref x);
            //void changeNum(ref int num)
            //{
            //    num = num + 5;

            //}
            //Console.WriteLine(x);

            ////pass by value 
            //Console.WriteLine("Pass  by value: ");
            //int y = 5;
            //Console.WriteLine(y);
            //changeNum1( y);
            //void changeNum1( int num)
            //{
            //    num = num + 5;

            //}
            //Console.WriteLine(y);


            StringBuilder str = new StringBuilder("Hello");
            str.AppendLine();
            str.Append("Im Fine");
            //Console.WriteLine(str);

            //string as it is copy 
            string str1 = str.ToString();
            //2 space for append line
            //Console.WriteLine(str1);
            //Console.WriteLine(str1.Length);


            //ArrrayList

            ArrayList arrayList = new ArrayList();  
            arrayList.Add('A');
            arrayList.Add(2);
            Console.WriteLine(arrayList.Count);
            Console.WriteLine(arrayList.Capacity);

            unsafe
            {
                fixed (object* numArray = arrayList.ToArray())
                {
                    for (int i = 0; i < arrayList.Count; i++)
                    {
                        Console.WriteLine($"Element {i}: Value = {arrayList[i]}, Address = {(long)(numArray + i)}");
                    }
                }

            }

            //Boxing and Unboxing

            int num1 = 10;  // Value Type
            Object obj1 = num1; // Implicit conversion of value type to object type.



            Console.WriteLine(obj1);



            int num2 = (int)obj1; // Expplicit conversion of reference type to value type.
        }
    }

}
