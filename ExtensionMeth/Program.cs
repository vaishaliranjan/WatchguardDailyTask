namespace ExtensionMeth
{
    public class Person
    {
        public void PrintName()
        {
            Console.WriteLine("The name of person is Vaishali");
        }
    }

    public static class ExtensionMethod
    {
        public static void PrintAge(this Person person)
        {
            Console.WriteLine("The age of person is 20 yrs");
        } 
        public static int GetWordCount(this String s)
        {
            
            return 1;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
           Person person = new Person();
            person.PrintName();
            person.PrintAge();
            string s = "My name is Vasihali";
            s.GetWordCount();
        }
    }
}