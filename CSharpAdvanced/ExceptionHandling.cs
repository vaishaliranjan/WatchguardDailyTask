//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpAdvanced
//{
//    public class Calculator
//    {
//        public int divide(int numerator, int denominator)
//        {
//            return numerator / denominator;
//        }
//    }
//    internal class ExceptionHandling
//    {
//        static void Main(string[] args)
//        {
//            StreamReader streamReader = null;

//            try
//            {
//                //Calculator calculator = new Calculator();
//                //calculator.divide(1, 0);
//                streamReader = new StreamReader(@"c:\file.zip");

//                var content = streamReader.ReadToEnd();
//                throw new Exception("oops");

//            }
//            //catch(DivideByZeroException ex)
//            //{
//            //    Console.WriteLine("You cant divide by 0");
//            //}
//            //catch(ArithmeticException ex)
//            //{

//            //}
//            catch(Exception ex)
//            {
//                Console.WriteLine("Sorry, an unexpected error occured!");
//            }
//            finally
//            {
//                //make sure that sream is closed
//                if (streamReader != null)
//                {
//                    streamReader.Dispose();
//                }
//            }

//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpAdvanced
//{
//    public class Calculator
//    {
//        public int divide(int numerator, int denominator)
//        {
//            return numerator / denominator;
//        }
//    }
//    internal class ExceptionHandling
//    {
//        static void Main(string[] args)
//        {


//            try
//            {
//                using (var streamReader = new StreamReader(@"c:\file.zip"))
//                {
//                    var content = streamReader.ReadToEnd();
//                }
//            }

//            catch (Exception ex)
//            {
//                Console.WriteLine("Sorry, an unexpected error occured!");
//            }

//        }
//    }
//}
//****************************MANUALLY CREATING EXCEPTION *********************
//using System;
//namespace ExceptionHandling
//{
//    public class Video { }
//    //Exception
//    public class YoutubeException: Exception
//    {
//        public YoutubeException(string message, Exception ex) 
//        :base(message, ex) { }
        
//    }
//    public class YoutubeAPI
//    {
//        public List<Video> GetVideos(string user)
//        {
//            try
//            {
//                //Access yt web series
//                //read the data 
//                //create a list of video objects
//                throw new Exception("OOps some low level youtube error!!");
//            }
//            catch(Exception ex)
//            {
//                //Log
//                throw new YoutubeException("Couldnt fetch the videos from youtube.", ex);
//            }
//            return new List<Video>();
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                YoutubeAPI api = new YoutubeAPI();
//                var videos = api.GetVideos("vaishali");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
            
//        }
//    }
//}