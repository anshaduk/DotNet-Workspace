namespace EvenOddUsingIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is even");
            }

            else
            {
                Console.WriteLine(num + " is odd");
            }
            
        }
    }
}
