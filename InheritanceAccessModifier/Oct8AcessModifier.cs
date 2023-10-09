
using InternalAmazon;
using System;

namespace CSharpInter
{
    class Oct8
    {
        static void Main(String[] args)
        {
            //-----------------------------------Public-------------- 
            var customer = new Customer();
            // customer.Promote();
            // Console.WriteLine(customer.CalculateRating()); - Accessible to customers

            //-----------------------------------Private-------------
            // Console.WriteLine(customer.CalculateRating()); - Not accessible to customers

            //-----------------------------------Internal------------
            // As Customer class is inside namespace InternalAmazon and we are creating its object in namespace CSharpInter-So we would need to refer to InternalAmazon

            // InternalAmazon.Customer customer2 = new InternalAmazon.Customer();  
            //InternalAmazon.RateCalculator rate= new InternalAmazon.RateCalculator();

            //now if we remove a class rateCalculator- then classes using that class obj and other places- coupling/dependencies 

            //If we make the class internal - then we can not access it from access modifier namespace 
           // InternalAmazon.RateCalculator rate = new InternalAmazon.RateCalculator(); ---ERROR
        }
    }
}