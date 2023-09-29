using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBeg
{
    public class StringUtility
    {
        public static string SummarizeText(string sentence, int maxLength = 20)
        {
            //const int maxLength = 20;

            if (sentence.Length < maxLength)
            {
                // Console.WriteLine(sentence);
                return sentence;
            }

            //sentence = sentence.Substring(0, maxLength);
            var words = sentence.Split(' ');
            var totalchar = 0;
            var SummaryWords = new List<string>();

            foreach (var word in words)
            {

                SummaryWords.Add(word);
                totalchar += word.Length + 1;
                if (totalchar > maxLength)
                {

                    break;
                }
            }

            //var summary = String.Join(" ", SummaryWords);
            //Console.WriteLine(summary);
            return String.Join(" ", SummaryWords);







        }
    }
}
