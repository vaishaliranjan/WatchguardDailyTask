//    namespace CSharpInt
//{
//    //Some developers have a mindset of declaring fields before and defining it in constructor - so a list can be declared before and initialize later inside a constructor
//    public class Customer
//    {
//        //Data
//        public int id;
//        public string Name;
//        //This is empty list

//        //------------------------------Read-Only------------

//        //When we need to initialize a list only once such that no one can reinitialize the list 
//        public readonly List<Order> Orders=new List<Order>();
//       // public readonly int number = 5;

        
//        //  define it in constructor= new List<Order>(); //generic parameters - in this list we can store ojects of type Order
//        //Constructor Overloading

//        //public Customer()
//        //{
//        //    Orders = new List<Order>();

//        //}
//        public Customer(int id)
//            //: this()
//        {
//            this.id = id;
//        }
//        public Customer(int id, string Name)
//            : this(id)
//        {
            
//            //this.id=id;
//            this.Name = Name;
//        }

//        public void Promote()
//        {
//            //accidently reinitialized later
//            // Orders = new List<Order>();

//        }
        

//        //Methods/Functions
//        //public void Introduce(String Name)
//        //{
//        //    Console.WriteLine("Hello {0}, I am {1}!", Name, this.Name);
//        //}
//        //this keyword is used to refer to the current instance of the class
//    }
//}
