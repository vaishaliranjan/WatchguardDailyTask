
using AssmeblyOne;
namespace AssemblyyTwo
{
    public class AssemblyTwoClass1
    {
        public void SampleMethod()
        {
            AssemblyOneClass1 a1 = new AssemblyOneClass1();
            // Console.WriteLine(a1.Id);-> error because Id is internal so we cant access it in different assembly
        }
    }
    public class AssemblyTwoClass2 : AssemblyOneClass1
    {
        public void SampleMethod()
        {
            AssemblyTwoClass2 a2 = new AssemblyTwoClass2();
            Console.WriteLine(a2.Id2);//but cant use it as 
            AssemblyOneClass1 a3 = new AssemblyOneClass1();
            //Console.WriteLine(a3.Id2);-> error 
        }
    }
}