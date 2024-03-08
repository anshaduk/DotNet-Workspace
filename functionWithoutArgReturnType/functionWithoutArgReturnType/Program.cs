namespace functionWithoutArgReturnType
{
    internal class Program
    {
        
        static void sum()
        {
            Console.WriteLine("Enter 2 numbers:");
            int num1=int.Parse(Console.ReadLine());
            int num2=int.Parse(Console.ReadLine());
            int sum=num1 + num2;
            Console.WriteLine("sum of 2 numbers: "+sum);
        }
        static void Main(string[] args)
        {
            sum();
        }
    }
}
