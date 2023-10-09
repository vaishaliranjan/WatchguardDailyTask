using System;
namespace CSharpInter
{
    public abstract class Shape
    {
        public int width { get; set; }
        public int height { get; set; }

        public abstract void Draw();
        public void Copy()
        {
            Console.WriteLine("COpied and saved into clipboard");
        }
    }
    public  class Circle: Shape
    {
        public sealed override void Draw()
        {
            Console.WriteLine("A circle has been drawen..");
        }
    }

    //public class SemiCircle: Circle
    //{ CANT BE DERIVED AS THE CIRCLE CLASS IS SEALED CLASS
    //}

    public class Semicircle: Circle
    {
        //public override void Draw()
        //{CANT BE OVERRIDE AS THE DRAW FUNCTION IS SEALED 

        //}
    }

    //WHY SEALED?  -> Sealed classes are slightly faster because of some runtime optimizations

    class Oct9
    {
        static void Main()
        {
           // Stream stream = new Stream();
            //Shape shape = new Shape(); Cant be initialized
        }
    }
}