using System;

namespace CSharpInt { 

    class Oct5
    {
        //Methods/ Functions - shows behaviour of an object

        //Method Signature: Name, return type and parameters
        public void printHello()
        {
            Console.WriteLine("Hello WOrld");
        }

        //-----------------------------------------Method Overloading-----------------------
        //Method Overloading - methods with same name but different signature
        //but for addition if we have 10 numbers to ass then should we make 10 overloaded function -NOOOOO!!!!!!!!!!!!!!!!

        //use ARRAY 
        public int Add(int[] arr)
        {
            int sum = 0;
            for(int i=0; i< arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        //but for this function we would need to initialize an array- We can avoid it using params

        //-------------------------------------------Params Modifier----------------------
        public int AddNums(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        
        public int Add(int A, int b)
        {
            return A + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public float Add(float a, float b)
        {
            return a + b;
        }




        //-------------------------------Ref Modifier--------------------------------
        //used to pass by referece to value types variable
        public void Change(ref int a)
        {
            a += 5;
        }

        //------------------------------ Out Modifier-------------------------------

        public void OutMethod(out int a, out int b)
        {
            a = 6;
            b = 5;
        }
        static void Main(string[] args)
        {
            Oct5 o= new Oct5();

            //method overloading 
            Console.WriteLine("Sum: "+o.Add(1, 2));
            Console.WriteLine("Sum: "+o.Add(1.1f, 23.3f));


            //params
            Console.WriteLine("Sum: "+o.Add(new int[] {1,2,3,4,5}));
            Console.WriteLine("Sum: "+o.AddNums(1,2,3,4,5));

            S
            //ref 
            int x = 10;
            Console.WriteLine("Before x: "+ x);
            o.Change(ref x);
            Console.WriteLine("After x: "+ x);


            //out
            Console.WriteLine(o.OutMethod(out int a, out int b));
        }
    }
}