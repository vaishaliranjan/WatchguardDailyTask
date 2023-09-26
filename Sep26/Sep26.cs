// See https://aka.ms/new-console-template for more information
using Sep26.Math;
using System;

namespace Sep26
{
    
    //public enum ShippingMethods
    //{
    //    Regular=1,  //or value assign
    //    Registered=2,
    //    Express=3
    //}


    //public class Student
    //{
    //    public string name;
    //    public int age;
    //}

    //struct Point
    //{
    //    public int x;
    //    public int y;

    //    public void Define()
    //    {
    //        //Console.WriteLine(x+","+y);
    //    }
    //}

    class Sep26
    {
        //REF TYPE VS VALUE TYPE
        //static void RefType(Student student)
        //{
        //    student.age += 10;
        //}
        //static void ValueType(int number)
        //{
        //    number += 10;
        //}
        static void Main(string[] args)
        {
            //  Student student = new Student() {name="Vaishali", age=30 };
            //  RefType(student);
            //  //Console.WriteLine(student.age);

            //  int numb = 10;
            //  ValueType(numb);
            //  //Console.WriteLine(numb);



            //  //CLASSES
            //  Person person = new Person();
            //  person.firstName = "Vaishali";
            //  person.lastName = "Ranjan";
            //  //
            //  //person.Introduce();
            //  Calculator calculator = new Calculator();
            //  int sum=calculator.Add(2, 3);
            //  //Console.WriteLine(sum);
            //  //Person person2;
            //  //person2.lastName = "ritika"; //error- use of unassigned local variable

            //  //console is a class-> writeline is a static method
            //  //original variables are sent 
            //  ModifyClass(person);
            //  void ModifyClass(Person p)
            //  {
            //      p.firstName = "Shakuntala";
            //  }
            //  //Console.WriteLine(person.firstName+person.lastName);


            //  //STRUCTURE
            //  Point p;
            //  p.x = 1;
            //  p.y = 2;
            //  p.Define();
            //  ModifyPoint(p);
            //  //passed that struct to a function- but a copy of that struct is sent instead of original variable
            //  void ModifyPoint(Point p)
            //  {
            //      p.x = 12;
            //  }
            //  //Console.WriteLine(p.x);
            //  //Console.WriteLine(p.y);

            //  //ARRAYS
            //  int[] arr = new int[3];
            //  arr[0] = 1;
            //  arr[1] = 2;
            //  arr[2] = 3;

            //  int[] arr1 = new int[3] {1,2,3};
            //  int[] arr2 = {1,2,3};
            // // Console.WriteLine(arr2[2]);

            //  var flags = new bool[3];
            //  flags[0] = true;
            //  /*Console.WriteLine(flags[0]);
            //  Console.WriteLine(flags[1]);
            //  Console.WriteLine(flags[2]); */
            //  //bool- false, int-0 by default, float-0, char-empty characters, string- empty strings
            //  var dec = new float[3];
            //  dec[0] = 3.2f;
            // /* Console.WriteLine(dec[0]);
            //  Console.WriteLine(dec[1]);
            //  Console.WriteLine(dec[2]);*/

            //  var characters = new string[3];
            //  characters[0] = "Hello";
            //  /*Console.WriteLine(characters[0]);
            //  Console.WriteLine(characters[1]);
            //  Console.WriteLine(characters[2]); */

            //  //STRINGS

            //  var collegeName = "JIIT"; //string- class int-struct
            //  //String scienceName="Krishna";

            //var fName = "Vaishali";
            //var lName = "Ranjan";
            //var fullName = fName + " " + lName;
            //var myFullName = string.Format("{0} and {1}", fName, lName);
            ////Console.WriteLine(myFullName);
            //var names = new string[3] { "Apple", "Mango", "Grapes" };
            //var formattedString = string.Join(", ", names);
            //// Console.WriteLine(formattedString);

            //var text = "Hi John \n Look into the following pattern \n c:\\folder1\\folder2";
            ////  Console.WriteLine(text);
            ////verbatim string
            //var text1 = @"Hi John Look into the following pattern c:\folder1\folder2";
            ////Console.WriteLine(text1);

            //var method = ShippingMethods.Express;
            //// Console.WriteLine((int)method);
            //  //Console.WriteLine(method);

            //  var methodId = 2;
            //  //Console.WriteLine((ShippingMethods)methodId);

            // // Console.WriteLine(method.ToString());//console.writeline- always use toString

            //  var methodName = "Express";
            //  //parsing string to different type
            //  //string to enum
            //  var shippingMethods=(ShippingMethods)Enum.Parse(typeof(ShippingMethods), methodName);

            //  //Reference Type and Value Type
            //  var a = 10;
            //  var b = a;
            //  b++;
            //  //Console.WriteLine(string.Format("{0} and {1}", a, b));

            //  var array1 = new int[3] { 1, 2, 3 };
            //  var array2 = array1;
            //  array2[0] = 0;
            //  //Console.WriteLine(array1[0]);






            //CONTROL FLOW 
            //CONDITIONAL
            //int hour = 10;
            //if (hour > 0 && hour < 12)
            //{
            //    console.writeline("morning");
            //}
            //else if (hour >= 12 && hour < 18)
            //{
            //    console.writeline("its afternoon");
            //}
            //else
            //{
            //    console.writeline("its evening");
            //}
            // bool isAdult = true;
            //int age;
            //if(isAdult)
            //{
            //    age = 18;

            //}
            //else
            //{
            //    age = 11;
            //}

            // int age1 = (isAdult) ? 18 : 11;
            //Console.WriteLine(age1);

            //var shipping = ShippingMethods.Registered;

            //switch(shipping) {

            //    case ShippingMethods.Regular:
            //        Console.WriteLine("Regular");
            //        break;

            //    case ShippingMethods.Registered:
            //        Console.WriteLine("Registered");
            //        break;

            //    default:
            //        Console.WriteLine("Other");
            //        break;
            //}


            //var marks = 10;
            //switch(marks)
            //{
            //    case 10:
            //        Console.WriteLine("Very low score");
            //        break;

            //    case 50:
            //        Console.WriteLine("Very good");
            //        break;

            //    default:
            //        Console.WriteLine("Fail");
            //        break;
            //}


            // Condiitonal Exercise
            //1- Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)



            int number = 11;
            if(number >=1  && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            //2- Write a program which takes two numbers from the console and displays the maximum of the two.
            int a = 10, b = 12;
            if(a>b)
            {
                Console.WriteLine("a is greater than b");

            }
            else
            {
                Console.WriteLine("b is greater than a");
            }

            //3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
            int width = 21;
            int height = 50;

            if(width > height)
            {
                Console.WriteLine("Portrait");
            }
            else
            {
                Console.WriteLine("Landscape");
            }

            //4- Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.
            int speedLimit = 80;
            int userSpeed = 150;

            if(userSpeed<speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                int temp = userSpeed - speedLimit;
                temp /= 5;
                if (temp > 12)
                {
                    Console.WriteLine("License Suspended");
                    
                }
                else
                {
                    Console.WriteLine("Demerit points: " + temp);
                }
                
                
            }

            //Demo for  loops
            //for(int i = 1; i <= 10; i++)
            //{
            //    if(i%2==0)
            //    {
            //        Console.WriteLine("Even: "+i);
            //    }
            //}
            //for (int i = 10; i >=1; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("Even: " + i);
            //    }
            //}

            ////ForEach loop
            //string name = "John Smith";
            //for(int i=0; i< name.Length;i++)
            //{
            //    Console.WriteLine(name[i]);
            //}
            //foreach(var tempp in name)
            //{
            //    Console.WriteLine(tempp);
            //}
            //int count = 0;
            //while (count <= 10)
            //{
            //    if(count%2==0) {
            //        Console.WriteLine(count); 
            //    }
            //}
            //while(true)
            //{
            //    Console.WriteLine("Whats your name: ");
            //    var input=Console.ReadLine();

            //    //if (String.IsNullOrWhiteSpace(input))
            //    //{
            //    //    break;
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("Name: "+ input);
            //    //}
            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("Name: "+ input);
            //        continue;
            //    }
            //    break;




            //}

            //RANDOM
            //var random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write((char)random.Next('A','Z'));
            //}

            //var random =new Random();
            //int passLength = 10;
            //char[] buffer = new char[passLength];

            //for(int i=0;i<passLength; i++)
            //{
            //    buffer[i] = (char)('a' + random.Next(0, 26)); //a=97 and z=122

            //}
            //var password=new string(buffer);
            //Console.WriteLine(password);

            //EXERCISE
            //1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
            int count = 0;
            for(int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            //
        }
    }
    
    
    
}
