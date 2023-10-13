namespace CompositionWithInterfaces
{
    public interface Image
    {
        void Click()
        {
            Console.WriteLine("Interface img click");
        }
        void Video();
    }
    public class FunnyImage : Image
    {
        public void Click()
        {
            Console.WriteLine("Funny image click image");
        }

        public void Video()
        {
            Console.WriteLine("Funny image click video");
        }
    }

    public class HappyImage : Image
    {
        public void Click()
        {
            Console.WriteLine("Happy image click image");
        }

        public void Video()
        {
            Console.WriteLine("Happy image click video");
        }
    }

    public class SadImage : Image
    {
        public void Click()
        {
            Console.WriteLine("sad image click image");
        }

        public void Video()
        {
            Console.WriteLine("sad image click video");
        }
    }
    public class Something
    {
        public Something(Image img)
        {
            img.Click();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Something a = new Something(new FunnyImage());
            Something b= new Something(new HappyImage());
            Something c = new Something(new SadImage());
         //  Image img = new FunnyImage();


        }
    }
}