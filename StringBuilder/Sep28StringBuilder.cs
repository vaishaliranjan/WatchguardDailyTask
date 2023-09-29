using System;
using System.Text;
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
//Console.WriteLine(builder);

//StringBuilder - modify alot - mem efficient - manipulating strings 
//builder[0]
//builder.Append('-', 10).AppendLine().Append("Header").AppendLine().Append('-', 10);

StringBuilder str1 = new StringBuilder("abc");
StringBuilder str2 = str1.Append("gggggggggggggggggggggggggggggggggggggggggggggg");
//Console.WriteLine(object.ReferenceEquals(str1,str2));

Console.WriteLine(Convert.ToInt32(''));





StringBuilder sb = new StringBuilder("abc");



unsafe
{
    StringBuilder* stringBuilder = &sb;
    Console.WriteLine((int)stringBuilder);
    sb.Append("defqwertyuixcvbndfghgggggggggg");
    stringBuilder = &sb;
    Console.WriteLine((int)stringBuilder);



}
