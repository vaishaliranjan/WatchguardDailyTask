namespace AssmeblyOne
{
    public class AssemblyOneClass1
    {
        internal int Id = 101;
        //sincle id is an internal member i can access it in any class inside assembly one 
        protected internal int Id2 = 102;
        //since id2 is protected internal so it will behave as public in the same assembly but behave as protected in different assembly

        private protected int Id3 = 103;
    }
    public class AssemblyOneClass2
    {
        public void SampleMethod()
        {
            AssemblyOneClass1 a1 = new AssemblyOneClass1();
            Console.WriteLine(a1.Id);

            //accessible in same class
            Console.WriteLine(a1.Id2);

            // Console.WriteLine(a1.Id3); -> same assembly protected 
        }
    }
}
