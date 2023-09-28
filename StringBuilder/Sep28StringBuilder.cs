using System;
using System.Text;

namespace CSharpBeg
{
    class Sep28
    {
        static void Main(string[] args)
        {
            //String Builder- System.Text defined + mutable string + fast to create and manipulate strings;
            //Cant perform string operations 
            //Append(), Insert(), Remove(), Replace(), Clear()

            StringBuilder builder = new StringBuilder();


            //Append, AppendFormat, AppendLine
            //str.Append("str"), str.Append("str", repeat), str.AppendLine()- new line in the string 
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            //Replace- str.Replace(given, to)
            builder.Replace("-", "+");

            //Remove - str.Remove(startInd, length)
            builder.Remove(0, 3);

            //Insert - str.Insert(index, string/char)
            builder.Insert(0, "+++");
            builder.Insert(0, new string('-', 3));
            Console.WriteLine(builder);

            //StringBuilder - modify alot - mem efficient - manipulating strings 
            //builder[0]
            //builder.Append('-', 10).AppendLine().Append("Header").AppendLine().Append('-', 10);
        }
    }
}