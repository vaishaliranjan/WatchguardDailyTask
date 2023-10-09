using System;
using System.Collections;

namespace CSharpInter
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {

        }
    }
    public class Text: Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void Write()
        {

        }

    }
    public class Car
    {

    }
    class Oct9
    {
        static void Main(string[] args)
        {
            //-------------------UPCASTING ------------
           // Text text = new Text();
           // Shape shape = text; //Upcasting - no conversion is required - implicitly co
            //shape would be able to use its func only

            //
            //
            //
            //
            //
            //
            //nverted- both of them points to the same place in heap

            //text.FontSize = 0; //text would have all the func of parent and its own class
            ////shape.FontSize = 0; //shape would only have func of its won class

            //text.Width = 200;
            //shape.Width = 100;
            //Console.WriteLine(text.Width);



            //----------------------Realtime Applications
            // StreamReader reader = new StreamReader(new FileStream());
            //var list = new ArrayList();
            //list.Add("Hello");//no conversion is required 
            //list.Add('e');
            //Add method takes an argument of objects and object is the parent of all classes in dotnet frmaework.




            //-----------------------DOWNCASTING -------
            //This  will throw an error as we would first eed to do upcasting in order to do downcasting.

            //Shape shape = new Shape();
            //Text text = (Text)shape;

            Shape shape = new Text();
            Text text = (Text)shape;

            //this wont throw an error 
            
            //At runtime - the object will be of type shape but at runtime it will be of type text
            //shape.FontSize = 100; we wont we able to access the props of text class -> so we would need to downcast

            //Text text = (Text)shape;
            //text.FontSize = 12;

            //-------------AS and IS Keyword-----------
            //Shape s = new Shape();
            // Car car = (Car) s; - throws an error 
            //Car car = s as Car;- Not working doubtttttttt

            //if(s is Car)
            //{
            //    Car car = (Car)s;
            //}

            //---------------------------BOXING AND UNBOXING

            //Boxing
            int number = 10;
            object obj = number;
            //Unboxing 
            object obj1 = 10;
            int num = (int)obj1;


            var arrayList = new ArrayList();
            arrayList.Add(1); //arraylist.Add takes obj as parameter so if we pass a value type then boxing will happen

            arrayList.Add("Hello"); //no boxing 
            //so we should use generic type list

        }
    }
}