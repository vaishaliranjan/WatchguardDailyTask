using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    internal class Dynamic
    {
        static void Main(string[] args)
        {
            //dynamic name = "Vaishali";
            //name = 10;

            //dynamic name = "Vaishali";
            //name++; //runtime error -> string increment cant be done

            dynamic a = 10;
            dynamic b = 20;
            var c = a + b;
            //c will also be a dynamic variable


            //Conversion - Implicit
            int x = 10;
            dynamic y = x;

            //runtime y-> int -> log implicitly 
            //no need to cast
            long l = y;
            //WHILE CONVERTING FROM DYNAMIC TO STATIC TYPES IF THE RUNTIME TYPE OF DYNAMIC OBJECT IS IMPLICITLY CONVERTIBLE TO TARGET TYPE, YOU DONT NEED TO CAST IT.
        }
    }
}
