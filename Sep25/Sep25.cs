// See https://aka.ms/new-console-template for more information
using System;
namespace Sep25
{
    class Sep25
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            /*const int number=10;
             * const  float pi= 3.14f;
            Console.WriteLine(number);
            float num2 = 4.1f;
            Console.WriteLine(num2); */

            //Overflowing 
            /* byte num = 255;
            num++; //here the range exceed: 0-255 -> 255++-> 0
            Console.WriteLine(num); */


            //to stop overflow 
            /*checked
            {
                byte num = 255;
                num++;
                Console.WriteLine(num); 
            } ///here the code stops if overflow happens and
            //throws an exception */


            //Primitive data types
            /*byte num = 2;
            int number = 10;
            float pi = 3.14f;
            decimal area = 34.5m;
            char letter = 'A';
            string name = "Vaishali";
            bool isWorking = false;

            Console.WriteLine(num);
            Console.WriteLine(number);
            Console.WriteLine(pi);
            Console.WriteLine(area);
            Console.WriteLine(letter);
            Console.WriteLine(name);
            Console.WriteLine(isWorking);*/

            /* var num = 2;
             var number = 10;
             var pi = 3.14f;
             var area = 34.5m;
             var letter = 'A';
             var name = "Vaishali";
             var isWorking = false;

             Console.WriteLine(num);
             Console.WriteLine(number);
             Console.WriteLine(pi);
             Console.WriteLine(area);
             Console.WriteLine(letter);
             Console.WriteLine(name);
             Console.WriteLine(isWorking);*/

            //Format String
            /*Console.WriteLine("{0} to {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} to {1} {2} {3}", float.MinValue, float.MaxValue, 12, 24.5f); */

            //Type Conversion-implicit, explicit and conversion between non campatible types
            //implicit conversion
            /*byte num = 2;
            int i = num;
            Console.WriteLine(i);

            //explicit conversion
            int num1 = 20;
            short num2 = (short)num1;
            Console.WriteLine(num2);
            

            //non compatible type conversion 
            var str1 = "1234";
            int number = Convert.ToInt32(str1);//DOUBT
            Console.WriteLine(number);

            try
            {
                var str = "1234";
                byte n = Convert.ToByte(str);//DOUBT
                Console.WriteLine(n);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Cant be converted");
            }
            //Convert- ToInt32(), ToInt64(), ToInt16(), ToByte()*/
            //1 byte =8bits
            var a = 1;
            var b = 2;
            Console.WriteLine(a + b);
            Console.WriteLine((float)a / (float)b);
            Console.WriteLine(a == b);

        }
    }

}