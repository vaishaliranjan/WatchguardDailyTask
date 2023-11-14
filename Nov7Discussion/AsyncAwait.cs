using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov7Discussion
{
    internal class AsyncAwait
    {
        static void Main(string[] args)
        {
            Function2();
            Function1();
            
            Function3();
            Console.ReadLine();
        }
         static async void Function1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Function 1 started");
                Thread.Sleep(2000);
                Console.WriteLine("Function 1 ended");
            });

            
        }
         static async void Function2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Function 2 started");
                Thread.Sleep(5000);
                Console.WriteLine("Function 2 ended");
            });
        }

        static async void Function3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Function 3 started");
                Thread.Sleep(1000);
                Console.WriteLine("Function 3 ended");
            });
            
        }
    }
}
