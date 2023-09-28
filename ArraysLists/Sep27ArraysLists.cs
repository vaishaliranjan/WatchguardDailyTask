﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace Sep27
{
    class Program
    {

        static void ChangeArrayElements(int[] arr)
        {
            // Change the value of the first three array elements.
            arr[0] = 3;
            arr[1] = 2;
            arr[2] = 1;
        }


        static void Main(String[] args)
        {

            //----------------------------------------------------------------------------------------------------------------------------
            //-----------------------------------------------------------ARRAYS-------------------------------------------------------------
            //---------------------------------------------------------------------------------------------------------------------
            //ARRAYS- Data::Length and Methods:: Clear(), Copy(), IndexOf(), Reverse(), Sort()
            //Arrays- Ref Type
            // 1D Array and 2D Array(Rectangular vs Jagged Array- array of arrays)
            //n elements - 0 to n-1 index 

            //Initializing 1D Array
            int[] arr1 = new int[3];
            int[] arr2 = new int[3] { 1, 2, 3 };
            int[] arr3 = { 1, 2, 3 };
            //Console.WriteLine("{0}, {1}, {2}", arr1.Length, arr2.Length, arr3.Length);
            ChangeArrayElements(arr2);
            for (int i = 0; i < arr2.Length; i++)
            {
                //Console.Write(arr2[i]);
            }
            //Console.WriteLine();
            //Initializing 2D Array - for loop GetLength(0) and ',' GetLength(1)
            int[,] arr4 = new int[3, 3];
            int[,] arr5 = new int[3, 3] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
            int[,] arr6 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < arr6.GetLength(0); i++)
            {
                for (int j = 0; j < arr6.GetLength(1); j++)
                {
                    //Console.Write(arr6[i,j]);
                }
            }
            // Console.WriteLine();

            //Jagged Array - for loop Length and [i].Length [][]
            int[][] arr7 = new int[3][];
            arr7[0] = new int[3] { 1, 2, 3 };
            //or
            int[][] arr8 =
            {
                new int[3] {1,2,3},
                new int[5] {4,5,6,7,6},
                new int[3] {7,8,9}
            };
            for (int i = 0; i < arr8.Length; i++)
            {
                for (int j = 0; j < arr8[i].Length; j++)
                {
                    //Console.Write(arr8[i][j]);
                }
                //Console.WriteLine();
            }
            //Implicit Typed arrays
            var a = new int[3];
            var c = new[] { 1, 2, 3 };
            //automatically detects  and assigned the most appropriate type
            int b;
            //var c;- implicitly typesvar must be initialized




            //INDEX- Array.IndexOf(array, element)
            // Console.WriteLine(Array.IndexOf(arr8, 9));-DOUBTTTTT- Solved only single dimensional array is supported here
            //Console.WriteLine(Array.IndexOf(arr3, 3));
            // Console.WriteLine(Array.IndexOf(arr6, 3));




            //CLEAR- Array.Clear(array, startingPos, length)
            Array.Clear(arr3, 0, 2);
            for (int i = 0; i < arr3.Length; i++)
            {
                //Console.Write(arr3[i]);
            }
            //int -0 bool- false strings,obj- null

            //Console.WriteLine();

            //COPY - Array.Copy(sourceArray, DestArray, length)
            int[] arr10 = new int[3] { 12, 13, 14 };
            Array.Copy(arr10, arr1, 3);
            for (int i = 0; i < arr10.Length; i++)
            {
                //Console.WriteLine(arr10[i]);
            }


            //SORT - Array.Sort(array)
            int[] arr11 = new int[6] { 55, 11, 45, 66, 78, 88 };
            Array.Sort(arr11);
            for (int i = 0; i < arr11.Length; i++)
            {
                //Console.Write(arr11[i]+" ");
            }
            //Console.WriteLine();

            //Reverse - Array.Reverse(array)
            int[] arr12 = new int[6] { 55, 11, 45, 66, 78, 88 };
            Array.Reverse(arr12);
            for (int i = 0; i < arr12.Length; i++)
            {
                // Console.Write(arr12[i] + " ");
            }

            //Length 
            //Console.WriteLine();
            //Console.WriteLine(arr12.Length);


            //length on obj and other oprations on Array class- Class itself access method - static 


            //LISTS- when we dont know the length 
            //Methods--> Add, AddRange, Remove, RemoveAt, IndexOf, Contains, Count 
            List<int> list = new List<int>() { 1, 2, 3, 4 }; //generic type
            //var list1 = new List<int>();
            //ADD
            list.Add(5);

            //AddRange - to add another list or an array to the list
            list.AddRange(new int[] { 1, 2, 3, 5 });

            //iterate over list - forEach
            foreach (var num in list)
            {
                //Console.WriteLine(num);
            }


            //IndexOf - return index of the element

            //Console.WriteLine(list.IndexOf(2));
            //Console.WriteLine(list.IndexOf(5, 3)); //element, startPost
            //Console.WriteLine(list.LastIndexOf(2));

            //COUNT
            //Console.WriteLine(list.Count);

            //REMOVE
            list.Remove(1);
            foreach (var num in list)
            {
                //Console.Write(num);
            }
            //remove all 1
            //foreach (var num in list)
            //{
            //    if (num == 1)
            //    {
            //        list.Remove(1); // we cant mooify list inside a foreach loop
            //    }

            //}

            //Console.WriteLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 1)
                {
                    list.Remove(1); // we can mooify list inside a for loop
                }
            }
            foreach (var num in list)
            {
                //Console.Write(num);
            }
            list.Clear();


        }
    }

}




