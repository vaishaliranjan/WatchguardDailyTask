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
//using System.Diagnostics;

//namespace CSharpInter
//{
//    public class Product<TOne, TTwo, TThree>
//    {
//        public TOne id;
//        public TTwo name;
//        public TThree address;
//        public TOne[] arr;

//        public List<TTwo> list;

//        public Product(int n)
//        {
//            //this.id = 12;
//            //this.name = 45;
//            arr= new TOne[n];
//            list = new List<TTwo>();
//        }


//        public string Title { get; set; }
//        public float Price { get; set; }
//    }
//public class Book : Product
//{
//    public string Isbn { get; set; }
//}
//public class DiscountCalculator<TProduct> where TProduct : Product
//{
//    public float CalculateDiscount(TProduct product)
//    {
//        return product.Price;
//    }
//}
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            //var discount = new DiscountCalculator<Product>();
//            //discount.CalculateDiscount(new Product());
//            //discount.CalculateDiscount(new Book());
//            Product<int, string, string> p = new Product<int, string, string>(3);
//            Console.WriteLine(p.id);
//            Console.WriteLine(p.name);
//            Console.WriteLine(p.address);
//            p.arr[0] = 12;
//            p.arr[1] = 13;
//            p.arr[2] = 14;
//            p.list.Add("apple");
//            p.list.Add("mango");
//            p.list.Remove("apple");
//            p.list.RemoveAt(0);


//            Product<string, string, string> p1 = new Product<string, string, string>(4);
//            Console.WriteLine(p.id);
//            Console.WriteLine(p.name);
//            Console.WriteLine(p.address);
//            p1.arr[0] = "1";
//            p1.arr[1] = "2";
//            p1.arr[2] = "3";
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


























//**********************************************************************
//                                 GENERIC METHODS 
//**********************************************************************


//using System;
//namespace CSharpInter
//{
//    public class Example
//    {
//        //public static void PrintArr(int[] arr)
//        //{
//        //    for(int i = 0; i < arr.Length; i++)
//        //    {
//        //        Console.WriteLine(arr[i]);
//        //    }
//        //}

//        //public static void PrintArr(string[] arr)
//        //{
//        //    for (int i = 0; i < arr.Length; i++)
//        //    {
//        //        Console.WriteLine(arr[i]);
//        //    }
//        //}

//        ///MAKE IT GENERIC
//        ///
//        public static void PrintArr<T>(T[] arr)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.WriteLine(arr[i]);
//            }
//        }

//        //BOXING
//        //public static void PrintArr(Object[] arr)
//        //{
//        //    for (int i = 0; i < arr.Length; i++)
//        //    {
//        //        Console.WriteLine(arr[i]);
//        //    }
//        //}
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Example.PrintArr(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, });
//            //but this wont for strings and all we would need to over load the function
//            Example.PrintArr(new string[] { "Vaishali", "Ranjan", "Ritika", "Narang" });
//            Example.PrintArr(new char[] {'A', 'B', 'C' });
//        }
//    }
//}



//**********************************************************************
//                                 GENERIC CLASSES 
//**********************************************************************
//using System;
//namespace CSharpInter
//{
//    public class Example<T>
//    {
//        T box;
//        public Example(T b)
//        {
//            this.box = b;
//        }
//        public T getBox()
//        {
//            return this.box;
//        }
//    }
//    public class Program
//    {

//        static void Main(string[] args)
//        {
//            Example<int> e = new Example<int>(20);
//            Console.WriteLine(e.getBox());
//            Example<string> str = new Example<string>("Vaishali");
//            Console.WriteLine(str.getBox());
//        }
//    }
//}




//using System;
//using System.Text;

//namespace CSharpAdv
//{
//    public class GenericClass<T> where T: class
//    {
//        public static void Print(T obj)
//        {
//            Console.WriteLine(obj);
//        }
//    }
//    public class Genrics
//    {
//        static void Main(string[] args)
//        {
//            string str = "Vaishali";
//            GenericClass<string>.Print(str);
//            StringBuilder sb = new StringBuilder("Ranjan");
//            GenericClass<StringBuilder>.Print(sb);
//            //GenericClass<int>.Print(2);
//        }
//    }
//}


//namespace CSharp
//{
//    public class Something<T>
//    {
//        public T Function()
//        {
//            return default(T);
//        }


//    }
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Something<int> Something = new Something<int>();
//        Console.WriteLine(Something.Function());

//        Something<string> s1 = new Something<string>();
//        Console.WriteLine(s1.Function());

//        Something<char> s2 = new Something<char>();
//        Console.WriteLine(s2.Function());

//        Something<bool> s3 = new Something<bool>();
//        Console.WriteLine(s3.Function());
//    }
//}

//}


//namespace CSharp
//{
//    public class Something
//    {
//        public void Dict1<T>(T index, T value)
//        {
//            Console.WriteLine(index + ": " + value);
//            Console.WriteLine("2nd fuc");
//        }
//        public void Dict1<T>(int index, T value)
//        {
//            Console.WriteLine(index + ": " + value);
//            Console.WriteLine("first func");
//        }



//    }
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Something s1 = new Something();
//            s1.Dict1<int>(1, 10);

//            Something s2 = new Something();
//            s2.Dict1(1, "vaishali");


//        }
//    }

//}

//namespace CSharp
//{
//    public class Car
//    {
//        public Car(int i)
//        {

//        }
//    }
//    public class Bike
//    {

//    }
//    public class Something<T> where T: new()
//{

//        public Something()
//        {
//            T obj = new T();
//        }

//}
//public class Program
//{
//    public static void Main(string[] args)
//    {
//            Something<Car> car = new Car();

//            Something<Bike> bike = new Something<Bike>();


//    }
//}

//}

//namespace CSharp
//{
//    public interface IVehicle
//    {

//    }
//    public class Car: IVehicle
//    {

//    }
//    public class BailGadi
//    {

//    }
//    public class Something<T> where T : IVehicle { }

//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            Something<Car> something = new Something<Car>();
//            Something<BailGadi> something1 = new Something<BailGadi>();
//        }
//    }
//}

//namespace CSHarp
//{
//    public class SOmething<T, U> where T: class where U: struct
//    {
//        public void Func(T obj1, U obj2)
//        {
//            Console.WriteLine(obj1);
//            Console.WriteLine(obj2);
//        }

        
//    }

//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            SOmething<string, int> s= new SOmething<string, int>();
//            SOmething<int, int> s1 = new SOmething<int, int>();

//        }
//    }
//}