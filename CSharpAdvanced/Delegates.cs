using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void HelloFunctionDelegate(string message);
namespace CSharpAdvanced
{
    public class Something
    {
        internal static void Hello(string message)
        {
            Console.WriteLine(message);
        }

        internal static void HelloYaar(string message)
        {
            Console.WriteLine(message);
        }
    }
    internal class Delegates: Something
    {
        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from delegate.");
            del = HelloYaar;
            del("From another hellofunction");
            //Hello("Simple Hello");
        }
        
    }
}
/* WHY DO WE NEED DELEGATES?
 * What is the benefit of calling a method indirectly via a pointer or directly?
 * delegate is a represetive to communicate between two parties.
 * C# delegate communication between two thing 
 * For designing extensible and flexible applications(eg frameworks)
 * */
