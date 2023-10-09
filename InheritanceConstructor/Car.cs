namespace CSharpInter
{
    public class Car: Vehicle
    {
        //public Car()
        //{
        //    Console.WriteLine("Car is being initialized...");
        //}
        public Car(string registrationNum)
            : base(registrationNum)
        {
            Console.WriteLine("Car is being initialized..");
            Console.WriteLine("with registration number {0}",registrationNum);
        }
    }
}