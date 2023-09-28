﻿using System;

namespace CSharpBeg
{
    class Sep28
    {
        static void Main(string[] args)
        {
            //System.IO- Namespace - classes - File, Directory, Path, FileInfo, DirectoryInfo

            //------------------------------File & FileInfo---------------
            //File
            //var path = "c:\\somefile.jpg";
            //File.Copy("c:\\temp\\myfile.jpg","d:\\temp\\myfile.jpg", true); //true- if file exist - overwrite
            //File.Delete(path);

            //if(File.Exists(path) )
            //{
            //    //
            //}

            //var content= File.ReadAllText(path);


            //FileInfo
            //var fileInfo = new FileInfo(path);
            //fileInfo.CopyTo("....");
            //fileInfo.Delete();

            //if (fileInfo.Exists)
            //{
            //    //
            //}
            //it doesnt have  read method
            //small num of operations- file 
            //large num of operations - fieinfo- obj






            //------------------------ Directory & DirectoryInfo --------------------

            //Directory
           // Directory.CreateDirectory(path);

            //var files=Directory.GetFiles(path, ".sln",SearchOption.AllDirectories);
            //foreach (var file in files) 
            //{
            //    Console.WriteLine(file);
            //}
            //var directories = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories); //*.*- all
            //foreach(var directory in directories)
            //{
            //    Console.WriteLine(directory);
            //}

            //Directory.Exists(path);

            //DirectoryInfo

            //var directoryInfo= new DirectoryInfo(path);
            //directoryInfo.GetFiles();
            //directoryInfo.GetDirectories();
            //directoryInfo.Delete();

            //------------------------------------Path--------------------
            var path = "c:\\somefile.jpg";

            //using string- get extension we would need iindexOf here

            Console.WriteLine("Extension: "+ Path.GetExtension(path));
            Console.WriteLine("File Name: "+ Path.GetFileName(path));
            Console.WriteLine("File name witout extension: "+ Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: "+ Path.GetDirectoryName(path));
        }
    }
}