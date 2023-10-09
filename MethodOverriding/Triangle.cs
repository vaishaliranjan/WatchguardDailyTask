namespace CSharpInter
{
    public class Triangle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a trianle..");

            base.Draw(); //- by default to throw back to parent class
        }
    }
}