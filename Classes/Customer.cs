    namespace CSharpInt
{
    public class Customer
    {
        //Data
        public int id;
        public string Name;
        public List<Order> Orders=new List<Order>();// not like this - instead define it in constructor= new List<Order>(); //generic parameters - in this list we can store ojects of type Order
        //Constructor Overloading

        public Customer()
        {

        }
        public Customer(int id)
        {
            this.id = id;
        }
        public Customer(int id, string Name)
        {
            this.id=id;
            this.Name = Name;
        }
        

        //Methods/Functions
        //public void Introduce(String Name)
        //{
        //    Console.WriteLine("Hello {0}, I am {1}!", Name, this.Name);
        //}
        //this keyword is used to refer to the current instance of the class
    }
}
