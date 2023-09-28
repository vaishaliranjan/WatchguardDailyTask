using System;

namespace CSharpBeg
{
    class Sep28
    {
        //Procedural Programming - A paradigm based on procedure calls

        //Functions - Separate the code that works with the console from the logic code of the application


        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name? ");
            var name=Console.ReadLine();
            Console.WriteLine(ReverseName(name));
            

        }

        public static string ReverseName(string s)
        {
            if (s == null)
            {
                return null;
            }

            var arr = new char[s.Length+1];

            for(int i= s.Length - 1; i >= 0; i--)
            {
                arr[s.Length-i]= s[i];
            }

            return new string(arr);
        }

    }
}