using System;
using System.Text;

//BRUTE FORCE ATTACK
class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("aaa");
        int numOfAttempts = 0;
        while (true)
        {
            if (numOfAttempts > 5)
            {
                Console.WriteLine("you have reached the maximum number of login attempts");
                break;
            }
            if (sb.ToString() == "pass")
            {
                Console.WriteLine("Matched: " + sb.ToString());
                Console.WriteLine("Number of attempts: "+ numOfAttempts);
                break;
            }

            //Print the current combination
            Console.WriteLine(sb.ToString());
            numOfAttempts++;

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
