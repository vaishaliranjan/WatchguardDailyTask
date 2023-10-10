using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInter
{
    public interface Animal
    {
        void walk();
    }
    public interface Human
    {
        void run();
    }
    public class Bike
    {
        void drive()
        {
            Console.WriteLine("drive");
        }
    }
    public class Something : Bike, Human, Animal
    {
        public void run()
        {
            throw new NotImplementedException();
        }

        public void walk()
        {
            throw new NotImplementedException();
        }
    }
    
}
