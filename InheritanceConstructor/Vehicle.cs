namespace CSharpInter
{
    public class Vehicle
    {
        private readonly string _registrationNum;
        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized..");
        //}
        //Commenting out the base class parameterless constructor will throw error in derived class parameterless constructor- so we would need the derived class to refer at any base class constructor


        //Now creating a parameter constructor 
        public Vehicle(string registrationNum)
        {
            _registrationNum = registrationNum;
            Console.WriteLine("Vehicle is being initialized..");
            Console.WriteLine("with registration number {0}", registrationNum);
        }
    }
}