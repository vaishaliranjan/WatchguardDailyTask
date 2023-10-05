namespace CSharpInter
{
    public class Calculator { 
    
        public int Sum(params int[] arr)
        {
            var sum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}