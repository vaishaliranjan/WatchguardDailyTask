using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    internal class Asynchronous
    {
        public static Task FirstFunc()
        {
            for (int i = 0;i < 10; i++)
            {
                Console.WriteLine("First  :   "+ i);
                Thread.Sleep(500);
            }
            return Task.CompletedTask;
        }

        public static Task SecondFunc()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Second  :  "+ i);
                Thread.Sleep(200);
            }
            return Task.CompletedTask;
        }
        public async static Task AsyncMethod()
        {
            await FirstFunc();

            await SecondFunc();
        }

        public static void Main(string[] args)
        {
            AsyncMethod();
        }
    }
}
