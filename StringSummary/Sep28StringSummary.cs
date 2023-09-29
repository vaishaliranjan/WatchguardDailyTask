using System;
using System.ComponentModel;
using System.Text;

namespace CSharpBeg
{
    class Sep28
    {
        public static void checkConsecutive(int[] arr)
        {
            if (arr[0] < arr[1])
            {
                for (int i = 1; i < arr.Length-1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Console.WriteLine("Not Consecutive");
                        return;
                    }

                }
            }
            else
            {
                for (int i = 1; i < arr.Length-1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        Console.WriteLine("Not Consecutive");
                        return;
                    }

                }
            }
            Console.WriteLine("Consecutive");
            return;
        }

        public static void checkDuplicate(int[] arr)
        {
            var result = arr.GroupBy(x => x);

            foreach(var item in result)
            {
                if (item.Count() > 1)
                {
                    Console.WriteLine("Duplicate");
                    return;
                }
            }
        }
        static void Main(string[] args)
        {
            //var sentence = "This is going to be a really really really really long text";
            //var summary= StringUtility.SummarizeText(sentence);
            //Console.WriteLine(summary);

            //1 - Write a program and ask the user to enter a few numbers separated by a hyphen.Work out if the numbers are consecutive.For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
            //Console.WriteLine("Enter numbers separated by hyphen: ");
            //string numbers =Console.ReadLine();
            //var arr = numbers.Split("-");

            //int[] arrNum= new int[arr.Length];

            //for(int i=0; i< arrNum.Length; i++)
            //{
            //    arrNum[i] = Convert.ToInt32(arr[i]);

            //}

            //checkConsecutive(arrNum);



            //2- Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
            //Console.WriteLine("Enter numbers separated by hyphen: ");
            //string numbers = Console.ReadLine();
            //if(!String.IsNullOrEmpty (numbers))
            //{
            //    var arr = numbers.Split("-");

            //    int[] arrNum = new int[arr.Length];

            //    for (int i = 0; i < arrNum.Length; i++)
            //    {
            //        arrNum[i] = Convert.ToInt32(arr[i]);

            //    }
            //   // checkDuplicate(arrNum);
            //}

            //3. Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

            //Console.WriteLine("Enter time in (hour:min) 24Hrs: ");
            //string numbers = Console.ReadLine();
            //var arr = numbers.Split(":");

            //int[] arrNum = new int[2];

            //for (int i = 0; i < 2; i++)
            //{
            //    arrNum[i] = Convert.ToInt32(arr[i]);


            //}
            //if (arrNum[0]>= 0 && arrNum[0] <= 23)
            //{
            //    if (arrNum[1]<=59 && arrNum[1] >= 0)
            //    {
            //        Console.WriteLine("Ok");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Time");
            //}


            // 4- Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
            //Console.WriteLine("Enter words: ");
            //string str = Console.ReadLine();
            //var arr = str.Split(" ");
            //for(int i=0; i<arr.Length; i++)
            //{
            //    string str1 = arr[i].Substring(0, 1).ToUpper();
            //    string str2= arr[i].Substring(1, arr[i].Length - 1).ToLower(); 
            //    arr[i]= str1  + str2 ;

            //}
            //string newStr = String.Join("", arr);
            //Console.WriteLine(newStr);


            //5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.
            Console.WriteLine("Enter a word: ");
            string input = Console.ReadLine();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int count = 0;


            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    count++;

                }
            }
            Console.WriteLine("Number of vowels: " + count);

        }


    }
}
