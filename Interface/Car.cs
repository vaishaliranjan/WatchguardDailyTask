namespace CsharpInter
{
    public class Car: IVehicle
    {
        private string name;

        public void getName()
        {
            Console.WriteLine(name);
        }

        public void setName(string name)
        {
            this.name = name;
        }
    }
}