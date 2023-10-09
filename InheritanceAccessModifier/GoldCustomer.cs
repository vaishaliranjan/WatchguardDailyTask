namespace CSharpInter
{
    public class GoldCustomer: Customer
    {


        //---------------------------------------PROTECTED---------------------
        public void OfferVoucher()
        {
            //As the calculateRating method is private in customer class- it is not accessible to its derived class as well
            var rating = this.CalculateRating(excludeOrders: true);
            
            //this is now accessible and also it increases dependency- if we change the name of method in base class we would need to check it in derived class as well;

            //if we delete calculateRating func from base class- then our derived class would throw some errors - Broken Encapsulation
        }
    }
}