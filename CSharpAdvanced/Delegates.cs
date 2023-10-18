//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public delegate void HelloFunctionDelegate(string message);
//namespace CSharpAdvanced
//{
//    public class Something
//    {
//        internal static void Hello(string message)
//        {
//            Console.WriteLine(message);
//        }

//        internal static void HelloYaar(string message)
//        {
//            Console.WriteLine(message);
//        }
//    }
//    internal class Delegates: Something
//    {
//        static void Main(string[] args)
//        {
//            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
//            del("Hello from delegate.");
//            del = HelloYaar;
//            del("From another hellofunction");
//            //Hello("Simple Hello");
//        }

//    }
//}
///* WHY DO WE NEED DELEGATES?
// * What is the benefit of calling a method indirectly via a pointer or directly?
// * delegate is a represetive to communicate between two parties.
// * C# delegate communication between two thing 
// * For designing extensible and flexible applications(eg frameworks)
// * */

//using System;
//namespace Delegates
//{
//    //PHOTO CLASS
//    public class Photo
//    {
//        public static Photo Load(string path)
//        {
//            return new Photo();
//        }
//        public void Save()
//        {

//        }
//    }

//    //PHOTO PROCESSOR 
//    public class PhotoProcessor { 
    
//        //public delegate void PhotoFilterHandler(Photo photo);
//        public void Process(string path, Action<Photo> filterHandler)
//        {
            
//                //Func points to a method that returns value
//                //Action points to a method that returns void
//            var photo = Photo.Load(path);
//            //var filters = new PhotoFilter();
//            //filters.ApplyBrightness(photo);
//            //filters.ApplyContrast(photo);
//            //filters.Resize(photo);
//            filterHandler(photo);
//            photo.Save();

            
//        }
//    }
//    //Photo filter
//    public class PhotoFilter
//    {
//        public void ApplyBrightness(Photo photo)
//        {
//            Console.WriteLine("Brightness applied!");
//        }

//        public void ApplyContrast(Photo photo)
//        {
//            Console.WriteLine("Contrast applied!");
//        }
//        public void Resize(Photo photo)
//        {
//            Console.WriteLine("Resized!!");
//        }
//    }
//    public class Program
//    {
//        //delegates help us to create program extensible
//        static void Main(string[] args)
//        {
//            PhotoProcessor processor = new PhotoProcessor();
//            //processor.Process("path");
//            var filters = new PhotoFilter();
//            Action<Photo> filterHandler = filters.ApplyBrightness;
//            filterHandler = filters.ApplyContrast;
//            filterHandler = RedEyeFilter;
//            processor.Process("path", filterHandler);
//        }
//        static void RedEyeFilter(Photo photo)
//        {
//            Console.WriteLine("Red eye filter applied!!");
//        }
//    }
//}