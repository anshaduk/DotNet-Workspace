namespace functionWithArgAndWithoutReturn
{
    internal class Program
    {
        static void sum(int a, int b)
        {
            Console.WriteLine($"Sum of 2 numbers is { a + b}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers :");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            sum(num1, num2);

        }
    }
}
