namespace CSharpInter
{
    public class Canva
    {
        public void DrawShape(List<Shape> shapes)
        {
            foreach(Shape shape in shapes)
            {
                shape.Draw();
            }       
        }
    }
}