using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    internal class NullableTypes
    {
        static void Main(string[] args)
        {
            //DateTime date = null; -> ERROR
            //Nullable<DateTime> date = null;
            //OR
            //DateTime? date = null;
            //// properties: GetValueOrDefault, fields: HasValue, Value
            //Console.WriteLine("Get Value or Deafault: "+date.GetValueOrDefault()); //returns a default value if null
            //Console.WriteLine("Has value"+date.HasValue); //returns true/false
            //Console.WriteLine("Value"+date.Value);//exception if no value /else value








            //DateTime? date1 = new DateTime(2023, 10, 19);
            ////DateTime date2 = date1; will throw error as compiler is confused what is null is present -> assigning value to nullable 
            //DateTime date2 = date1.GetValueOrDefault();
            //DateTime? date3 = date2;//no error because a value type can easily be assign to a nullable type
            ////Console.WriteLine(date2);
            //Console.WriteLine(date3.GetValueOrDefault());








            DateTime? date = null;
            //DateTime date2;
            //if (date != null)
            //{
            //    date2 = date.GetValueOrDefault();
            //}
            //else
            //{
            //    date2 = DateTime.Today;
            //}
            //Console.WriteLine(date2);


            //much more shorter - NULL COALESCING OPERATOR
            DateTime date2 = date ?? DateTime.Today;
            Console.WriteLine(date2);
        }


    }
}
