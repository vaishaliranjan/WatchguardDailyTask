namespace CSharpInter
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(true); //CalculateRating(excludeOrders: true);
            if (rating == 0)
            {
                Console.WriteLine("Promoted to level 1!");
            }
            else
            {
                Console.WriteLine("Promoted to level 2!");
            }
        }


        //we dont want customers to see how do we apply our business logic in calculating rating --Encapsulation
        //by making it private instead editing all the objects accessing this method after introducing bool - we would only need to edit it inside the class


        //-------------------------------PUBLIC-------------------------
        //public int CalculateRating(bool excludeOrders)
        //{
        //    return 0;
        //}


        //--------------------------------PRIVATE--------------------
        //private int CalculateRating(bool excludeOrders)
        //{
        //    return 0;
        //}

        //-----------------------PROTECTED----------------------------------
        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}