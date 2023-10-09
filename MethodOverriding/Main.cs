using System;

namespace CSharpInter
{
    partial class Oct9
    {
        static void Main(String[] args)
        {
            //Encapsulation -- divide all based on their characteristics- circle only knows about circle- now adding rectangle wont affect anyone - loosely coupling
            var shapes =new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Triangle());
            shapes.Add(new Shape());

            Canva canva = new Canva();
            canva.DrawShape(shapes);
        }
    }
}