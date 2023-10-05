using System;
using System.Text;

//BRUTE FORCE ATTACK
class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("aaa");

        while (true)
        {
            if (sb.ToString() == "akshat")
            {
                Console.WriteLine("Matched: " + sb.ToString());
                break;
            }

            //Print the current combination
            Console.WriteLine(sb.ToString());

            //Generate the next combination
            IncrementStringBuilder(sb);
        }
    }

    static void IncrementStringBuilder(StringBuilder sb)
    {
        for (int i = sb.Length - 1; i >= 0; i--)
        {
            if (sb[i] < 'z')
            {
                sb[i]++;
                return;
            }

            //Reset the character to 'a' and carry over
            sb[i] = 'a';
        }

        //If all characters are 'z', add a new character 'a' at the end
        sb.Append('a');
    }
}
