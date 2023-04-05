namespace Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int max = int.MinValue;
            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                totalSum += num;
                
                if (num > max)
                {
                    max = num;
                }
            }
            int sumWithoutMax = totalSum - max;

            if (sumWithoutMax == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int diff = Math.Abs(max - sumWithoutMax);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}