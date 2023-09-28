using System;

namespace CSharpBeg
{
    class Sep28
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really long text";
            var summary= StringUtility.SummarizeText(sentence);
            Console.WriteLine(summary);
        }

       
    }
}
