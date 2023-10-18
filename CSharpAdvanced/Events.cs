//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
///*Events- a mechanism for communication between objects 
// * used in building loosely coupled appliaction
// * helps extending applications
// * */
//namespace CSharpAdvanced
//{
//    public class Video
//    {
//        public string Title { get; set; }
//    }

//    public class VideoEncoder
//    {
//        //1. Define a delegate
//        //2. Define an event based on that delegate 
//        //3 Raise the event 

//        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

//        public event VideoEncodedEventHandler VideoEncoded;


//        public void Encode(Video video)
//        {
//            Console.WriteLine("Encoding Video....");
//            Thread.Sleep(3000);
//            OnVideoEncoded();
//        }
//        //Event publisher methods should be protected, virtual and void and start with the word On and then name of the event 
//        protected virtual void OnVideoEncoded()
//        {
//            if (VideoEncoded != null)
//                VideoEncoded(this, EventArgs.Empty);
//        }
//    }


//    internal class Events
//    {
//        static void Main(string[] args)
//        {
//            var video = new Video();
//            VideoEncoder encoder = new VideoEncoder();
//            encoder.Encode(video);

//        }
//    }

//    public class MailService
//    {

//    }
//}
