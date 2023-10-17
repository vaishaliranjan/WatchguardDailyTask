//namespace CSharpAdvanced
//{
//    //*****************************GENERIC LIST*******************************
//    public class GenericList<T>
//    {
//        public void Add(T value)
//        {
//            //some implementation

//        }
//        public T this[int index]
//        {
//            get
//            {
//                throw new NotImplementedException();
//            }
//        }
//    }
//    public class Book
//    {
//        private int _id;
//        private string _name;
//        public Book(int id, string name)
//        {
//            _id = id;
//            _name = name;
//        }
//    }

//    //******************************************GENERIC DICTIONARY********************
//     public class GenericDictionary<Tkey, Tvalue>
//    {
//        public void Add(Tkey key , Tvalue value)
//        {

//        }

//    }


//    //****************************************** GENERIC METHOD **************************
//    //a normal class can have generic methods 
//    //if we only require certain types to be used then we use constrains 
//    public class Utilities
//    {
//        //Normal Int Method 
//        public int Max(int a, int b)
//        {
//            return a > b ? a : b;
//        }

//        public T Max<T>(T a, T b) where T: IComparable
//        {
//            return a.CompareTo(b)>0 ? a : b;
//            //treats a as objects 
//            //return a>b ? a : b;
//        }


//    }

//    //ORRRRRRRRRRRRR
//    public class Utilities1<T> where T : IComparable
//    {
//        //Normal Int Method 
//        public int Max(int a, int b)
//        {
//            return a > b ? a : b;
//        }

//        public T Max(T a, T b) 
//        {
//            return a.CompareTo(b) > 0 ? a : b;
//            //treats a as objects 
//            //return a>b ? a : b;
//        }


//    }

//    internal class Generics
//    {
//        static void Main(string[] args)
//        {

//            //*****************************Generic List***************************
//            var numberList = new GenericList<int>();//no boxing unboxing would be performed 
//            numberList.Add(1);
//            //numberList.Add(2.5f);  //error 
//            var book = new Book(102, "Hannah");
//            var book1 = new Book(101, "Stars");
//            var bookList = new GenericList<Book>();
//            bookList.Add(book);
//            bookList.Add(book1);



//            //***************************Generic Dictionary***************************
//            var dictionary = new GenericDictionary<int, string>();
//            dictionary.Add(1, "Vaishali");
//            dictionary.Add(2, "Ranjan");
//        }
//    }
//}


//Five types of constrains 
/*
 * 1. where T : IComparable
 * 2. where T : Product  -> obj or any of its sub classes
 * 3. where T : struct -> value type
 * 4. where T : class -> refrence type
 * 5. where T : new() -> an object which has a default constructor 
 * 
 * */


//*********************************CONSTRAINT TO A CLASS ****************************

//using System;
//namespace CSharpInter
//{
//    public class Product
//    {
//        public string Title { get; set; }
//        public float Price { get; set; }
//    }
//    public class Book : Product
//    {
//        public string Isbn { get; set; }
//    }
//    public class DiscountCalculator<TProduct> where TProduct : Product
//    {
//        public float CalculateDiscount(TProduct product)
//        {
//            return product.Price;
//        }
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            var discount = new DiscountCalculator<Product>();
//            discount.CalculateDiscount(new Product());
//            discount.CalculateDiscount(new Book());
//        }
//    }
//}


//***************************************CONSTRAINT TO NEW INITIALIZE OBJECT ***************
//using System;
//namespace CSharpInter
//{

//    public class Utilities<T> where T : new()
//    {
//        public void Something(T value)
//        {
//            var obj = new T();
//        }
//    }
//    public class A
//    {
//        public void Print()
//        {
//            Console.WriteLine("Print A");
//        }
//    }
//    public class B
//    {

//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            var utility= new Utilities<A>();
//            var utility1 = new Utilities<B>();

//        }
//    }
//}



//**************************************************CONSTRAINT TO A VALUE TYPE *************
//using System;
//namespace CSharpInter
//{

    
//    public class Program
//    {
//        //value types cant be null-> using this class we can give null values to them
//        public class Nullable<T> where T : struct
//        {
//            private object _value;
//            public Nullable(T value)
//            {
//                _value= value;
//            }
//            public bool HasValue
//            {
//                get
//                {
//                    return _value != null;
//                }
//            }
//            public T GetValueOrDefault()
//            {
//                if (HasValue)
//                {
//                    return (T)_value;
//                }
//                return default(T);
//            }
//        }
        
//        static void Main(string[] args)
//        {
//            var number = new Nullable<int>(5);
//            Console.WriteLine("Has Value? "+ number.HasValue);
//            Console.WriteLine("Value: "+ number.GetValueOrDefault());
//        }
//    }
//}