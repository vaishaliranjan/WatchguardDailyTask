using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Indexers
    {
        public int Id;
        public string Name;
        public string this[int i]
        {
            get
            {
                return this.Name;
            }
            set
            {
                 this.Name = value;
            }
        }

        public int this[string i]
        {
            get
            {
                return this.Id;
            }
            set
            {
                this.Id = value;
            }
        }
    }
    internal class IndexersSimple
    {
        static void Main(string[] args)
        {
            Indexers simple = new Indexers() { Id=2, Name="Vaishali"};
            Console.WriteLine(simple[2]);
            Console.WriteLine(simple["Vaishali"]);
        }
    }
}
