namespace CSharpInter
{
    public class Shape
    {
        public int width { get; set; }
        public int height { get; set; }
        public virtual void Draw()
        {
            Console.WriteLine("Draw a shape..");
        }

    }
}