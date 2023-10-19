//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RevisionBeg_Adv
//{


//        class Customer
//        {
//            public int Id;
//            public string Name;

//            public void Add()
//            {
//                this.Validate();
//                this.Update();
//            }
//            private bool Validate()
//            {
//                return true;
//            }
//            public bool Update()
//            {
//                return true;
//            }
//        }

//    internal class AbstractionRevision
//    {
//        static void Main(string[] args)
//        {
//            Customer c = new Customer();
//            c.Add();
//        }
//    }

//}
//using System;

//// Abstraction: Shape is an abstract class that cannot be instantiated directly
//abstract class Shape
//{
//    // Encapsulation: Private fields are encapsulated and accessed through properties
//    private string _color;

//    public string Color
//    {
//        get { return _color; }
//        set { _color = value; }
//    }

//    // Abstraction: Abstract method that must be implemented by derived classes
//    public abstract double CalculateArea();
//}

//// Inheritance and Polymorphism: Circle is a subclass of Shape and overrides CalculateArea method
//class Circle : Shape
//{
//    private double _radius;

//    public double Radius
//    {
//        get { return _radius; }
//        set { _radius = value; }
//    }

//    // Polymorphism: Overrides the abstract method in the base class
//    public override double CalculateArea()
//    {
//        return Math.PI * _radius * _radius;
//    }
//}

//// Inheritance and Polymorphism: Rectangle is a subclass of Shape and overrides CalculateArea method
//class Rectangle : Shape
//{
//    private double _width;
//    private double _height;

//    public double Width
//    {
//        get { return _width; }
//        set { _width = value; }
//    }

//    public double Height
//    {
//        get { return _height; }
//        set { _height = value; }
//    }

//    // Polymorphism: Overrides the abstract method in the base class
//    public override double CalculateArea()
//    {
//        return _width * _height;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Polymorphism: Creating objects of different subclasses using the base class type
//        Shape circle = new Circle { Radius = 5, Color = "Red" };
//        Shape rectangle = new Rectangle
//        {
//            Width = 4,
//            Height =



//using System;
//namespace GarbageCollectionDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Transaction doing SBI Bank");
//            IBank sbi = BankFactory.GetBankObject("SBI");
//            sbi.ValidateCard();
//            sbi.WithdrawMoney();
//            sbi.CheckBalanace();
//            sbi.BankTransfer();
//            sbi.MiniStatement();

//            Console.WriteLine("\nTransaction doing AXIX Bank");
//            IBank AXIX = BankFactory.GetBankObject("AXIX");
//            AXIX.ValidateCard();
//            AXIX.WithdrawMoney();
//            AXIX.CheckBalanace();
//            AXIX.BankTransfer();
//            AXIX.MiniStatement();

//            Console.Read();
//        }
//    }

//    public abstract class IBank
//    {
//        public abstract void ValidateCard();
//        public abstract void WithdrawMoney();
//        public abstract void CheckBalanace();
//        public abstract void BankTransfer();
//        public abstract void MiniStatement();
//    }

//    public class BankFactory
//    {
//        public static IBank GetBankObject(string bankType)
//        {
//            IBank BankObject = null;
//            if (bankType == "SBI")
//            {
//                BankObject = new SBI();
//            }
//            else if (bankType == "AXIX")
//            {
//                BankObject = new AXIX();
//            }
//            return BankObject;
//        }
//    }

//    public class SBI : IBank
//    {
//        public override void BankTransfer()
//        {
//            Console.WriteLine("SBI Bank Bank Transfer");
//        }

//        public override void CheckBalanace()
//        {
//            Console.WriteLine("SBI Bank Check Balanace");
//        }

//        public override void MiniStatement()
//        {
//            Console.WriteLine("SBI Bank Mini Statement");
//        }

//        public override void ValidateCard()
//        {
//            Console.WriteLine("SBI Bank Validate Card");
//        }

//        public override void WithdrawMoney()
//        {
//            Console.WriteLine("SBI Bank Withdraw Money");
//        }
//    }

//    public class AXIX : IBank
//    {
//        public override void BankTransfer()
//        {
//            Console.WriteLine("AXIX Bank Bank Transfer");
//        }

//        public override void CheckBalanace()
//        {
//            Console.WriteLine("AXIX Bank Check Balanace");
//        }

//        public override void MiniStatement()
//        {
//            Console.WriteLine("AXIX Bank Mini Statement");
//        }

//        public override void ValidateCard()
//        {
//            Console.WriteLine("AXIX Bank Validate Card");
//        }

//        public override void WithdrawMoney()
//        {
//            Console.WriteLine("AXIX Bank Withdraw Money");
//        }
//    }
//}