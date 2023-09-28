// See https://aka.ms/new-console-template for more information
using System;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace CSharpBeg
{
    class Sep27
    {

        static void Main(String[] args)
        {
            //----------------------------------------------------------------------------------------------------------------------------
            //-----------------------------------------------------------STRINGS-------------------------------------------------------------
            //---------------------------------------------------------------------------------------------------------------------

            //STRINGS Initialization
            string str1 = "My nameis Vaishali Ranjan";
            string str2 = new string("Vaishali"); //using Constructor 

            //Console.WriteLine(str1);
            //Console.WriteLine(str2);

            char[] chars = { 'w', 'o', 'r', 'd' };
            // Create a string from a character array.
            //string string1 = new string(chars);
            //Console.WriteLine(string1);

            // Create a string that consists of a character repeated 20 times.
            //string string2 = new string('c', 20);
            // Console.WriteLine(string2);

            //Various Methods in Strings- 
            /* 
            1. Concatenation - + operator 
            2. Substring- str.Substring(startIndex,length)
            3. String Format
            4. Strings and indexes - str.IndexOf("find") or strIndexOf("find", startIndex)
            5. Null strings and Empty strings 
            6. String Comparison and Equality - ==, str1.Equals(str2), STATIC: obj.RefrenceEquals(str1,str2)
            7. Sort- STATIC Array.Sort(strArray)
            8. Length- str.Length
            9. Formatting
            10. Replacing str.Replace("one","another")
            11. Null checking- STATIC String.IsNullOrEmpty(str) or String.IsNullOrWhitespace(str)
            12. Splitting- str.Split("given")
            13. Converting string to numbers-   STATIC int.Parse(str) or Convert.ToInt32(str)
            14. Converting numbers to string-  i.ToString()
           


            //--------------------------------- 1. String concatenation ---------------------------------------
            //combination of String instances and string literals
            string str3 = "This is one sentence. " + "This is a second. ";
            //Console.WriteLine(str3);
            string str4= str1 + str2;
            //Console.WriteLine(str4);
            String str5 = "Watchguard";
            string str6 = str1 + str5;
            //Console.WriteLine(str6);



            //--------------------------------- 2. String Substring ---------------------------------------
            // It is used to extract Substring
            // Used as .Substring(startIndex, length)


            //string str3 = "This is one sentence. " + "This is a second. ";
            //Console.WriteLine(str3.Substring(1,28));
            //.IndexOf is used to find the specific index in which the character is present 
            //.IndexOf("char"), IndexOf("char", startIndex)- can be used to find the index of a substring or to check if a particular substring is 
            //present in the string or not
            //Console.WriteLine(str3.IndexOf(" "));
            //Console.WriteLine(str3.IndexOf("his")); // returns the first index 
            //Console.WriteLine(str3.IndexOf("Mhis")); // returns -1 as this string is not present in the string

            //extracting 2nd word of the string
            string sentence = "This sentence has five words.";
            //algorithm- find the index of the first letter of 2nd word then calculate the length of that word
            int startIndex = sentence.IndexOf(" ") + 1;
            int length = sentence.IndexOf(" ", startIndex) - startIndex;
            //Console.WriteLine(sentence.Substring(startIndex,length));


            //--------------------------------- 3. String Format ---------------------------------------
            string newStr1 = "Vaishali";
            string newStr2 = "Ranjan";
            string newStr3 = "Shantanu";

            //Console.WriteLine("My name is {0} {1} and my brother's name is {2} {1}",newStr1,newStr2,newStr3);



            //--------------------------------- 4. String Indexes ---------------------------------------
            //.IndexOf is used to find the specific index in which the character is present 
            
            //.IndexOf("char"), IndexOf("char", startIndex)- can be used to find the index of a substring or to check if a particular substring is 
            
            
            //present in the string or not
            string sentence1 = "This sentence has five words.";
            //algorithm- find the index of the first letter of 2nd word then calculate the length of that word
            int startIndex1 = sentence.IndexOf(" ");
            //Console.WriteLine(startIndex1);
            int index = sentence.IndexOf("n", startIndex1); //startIndex-> to check after that index but returns the original index 
            //Console.WriteLine(index);



            //--------------------------------- 5. Null and Empty String ---------------------------------------
            string s1 = null;
            string s2 = string.Empty;
            string s3 = "";
            //Console.WriteLine(s1 == s2); // false as null is different from String.Empty;
            //Console.WriteLine(s1 == s3);// false as null is different from ""
            //Console.WriteLine(s2 == s3);// true as "" is same as string.Empty
            //null means no value, not initialized. string.Empty means "" (a blank string) as it is stated on MSDN
            //Console.WriteLine("Checking null or empty: ");
            //Console.WriteLine(string.IsNullOrEmpty(s1));
            //Console.WriteLine(string.IsNullOrEmpty(s2));
            //Console.WriteLine(string.IsNullOrEmpty(s3));
            //Use null when you want to represent that there is no value;
            //Use String.Empty when you want to represent that there is a value, and manipulate that string but the value is a blank string.
            //Console.WriteLine(s1.Length); System.NullReferenceException: 'Object reference not set to an instance of an object.'
            //Console.WriteLine(s2.Length);
            //Console.WriteLine(s3.Length);
            //A NullReferenceException happens when you try to access a reference variable that isn’t referencing any object. If a reference variable isn’t referencing an object, then it’ll be treated as null. The run-time will tell you that you are trying to access an object, when the variable is null by issuing a NullReferenceException.


            //Example
            /* Case -1 :

            String s = null;
            here, memory is allocated only for the reference s. null is not an object. So no memory is allocared for that.

            Case -2 :

            String s = ""; // empty string 
            Here, memory is allocated to both String reference s as well as the actual String value "" (Yes, "" is different from null)*/

            //--------------------------------- 6. String Comparison and Equality ---------------------------------------
            //Comparison-lexicographical comparison
            string compA = "Apqle";
            string compB = "Apple";
            //Console.WriteLine(String.Compare(compA, compB));
            // >0 if A>B and <0 if A<B and A=B =0

            //Equals- It is used to compare the content of the two strings 
            //== is used to compare string refrence for refrence equality 
            string strA = "Hello";
            string strB = new string("Hello");

            //Console.WriteLine(strA.Equals(strB));
            //Console.WriteLine(strA==strB);

            string st1 = "Hello";
            string st2 = "Hello";
            //Console.WriteLine(st1 == st2); //true content is same 
            //Console.WriteLine(object.ReferenceEquals(st1, st2)); //true same ref

            string st3 = new string("Hello");
            //Console.WriteLine(st1 == st3); //true content is same
            //Console.WriteLine(object.ReferenceEquals(st1, st3)); //false because st3 has new keyword so new mem allocation


            string st4 = "He";
            string st5 = "llo";
            string st6 = st4 + st5; //runtime allocation- no checking
            //Console.WriteLine(st1 == st6); //true content is same 
            //Console.WriteLine(object.ReferenceEquals(st3, st6)); //false  

            string st7 = "He" + "llo"; //compile time- check if that exist in the string pool
            //Console.WriteLine(st1 == st7); //true
            //Console.WriteLine(object.ReferenceEquals(st1, st7));//true 
            ////Console.WriteLine((string.Join(st4, s 5)));

            string st8 = "Hello";
            string st9 = "He";
            string st10 = st9 + "llo";
            //Console.WriteLine(st1 == st10); //true
            //Console.WriteLine(object.ReferenceEquals(st1, st10)); //false
            //Console.WriteLine(object.ReferenceEquals(st3, st10)); //false

            string str11 = String.Intern(st9 + "llo");// checks in pool

            //Console.WriteLine(st1 == str11); //true
            //Console.WriteLine(object.ReferenceEquals(st1, str11)); //true

            //--------------------------------- 7. Sort ---------------------------------------
            string[] stringArr = new string[] { "Hello", "Apple", "Mango" };
            for (int i = 0; i < stringArr.Length; i++)
            {
                //Console.WriteLine(stringArr[i]);
            }
            //after sorting 
            Array.Sort(stringArr);
            for (int i = 0; i < stringArr.Length; i++)
            {
                //Console.WriteLine(stringArr[i]);
            }

            //--------------------------------- 8. Length ---------------------------------------
            string stra = "Vaishali";
            // Console.WriteLine(stra.Length);

            //Q. How is String different from string?
            // String stands for System.String and it is a.NET Framework type. string is an alias in the C# language for System.String. Both of them are compiled to System.String in IL (Intermediate Language), so there is no difference.
            //"String" with a capital "S" is a keyword that refers to the built-in string data type in the .NET Framework's Base Class Library. It is a reference type that represents a sequence of characters.
            ////On the other hand, "string" with a lowercase "s" is an alias for the "System.String" type, which means they are essentially the same thing.The use of "string" is just a shorthand way of referring to the "System.String" type, and it is used more commonly in C# code.

            //---------------------------------9. Formatting ---------------------
            //ToUpper(), ToLower(), Trim()-removes whitespaces from left and right of  a string 
            string string1 = "Watchguard ";
            //Console.WriteLine(string1.ToUpper());
            //Console.WriteLine(string1.ToLower());
            //Console.WriteLine(string1.Trim());


            //---------------------------------10. Replacing-------------------
            //Console.WriteLine(string1.Replace('W','w')); //immutable
            //Console.WriteLine(string1.Replace(" ","Technologies"));
            //Console.WriteLine(string1);


            //---------------------------------11. Null Checking --------------------------------
            //Static methods- String.IsNullOrEmpty() , String.IsNullOrWhiteSpace

            string string2 = null;
            //Console.WriteLine(string2);
            //Console.WriteLine(String.IsNullOrEmpty(string2));
            //Console.WriteLine(String.IsNullOrWhiteSpace(string2));

            //---------------------------------12. Splitting --------------------------------------
            string companyName = "Watchguard Technologies";
            var words = companyName.Split(" "); // split based on the specific character
            Console.WriteLine(words[0]);


            //---------------------------------13. Converting strings to numbers------------------------
            string s = "12";
            int y = int.Parse(s); //throws null exception if the string is null
            int z = Convert.ToInt32(s); //converts the value to 0 if the string is null
            Console.WriteLine("{0}, {1}", y, z);



            //---------------------------------14. Converting numbers  to strings------------------------
            int h = 12;
            string string3 = h.ToString();
            string t = h.ToString("C");
            string t1 = h.ToString("C0");
            Console.WriteLine(string3 + " " + t + " " + t1);

           

        }
    }
    
}


 

