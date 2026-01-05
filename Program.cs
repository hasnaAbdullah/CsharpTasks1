namespace CsharpPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count;
            float sum = 0;
            float number;
            float average = 0;
            Console.Write("Enter how many numbers: ");
            count = int.Parse(Console.ReadLine());

            if (count <= 0)
            {
                Console.WriteLine("Count must be greater than zero.");

            }

            for (int i = 1; i <= count; i++)
            {
                Console.Write("Enter number " + i + ": ");
                number = float.Parse(Console.ReadLine());
                sum += number;
                Console.WriteLine(" the sum =" + sum);
                Console.WriteLine("Average =" + average);
                number = float.Parse(Console.ReadLine());
                average += number;
                Console.WriteLine(" the average  =" + average);
            }
        }
    }








}
   
