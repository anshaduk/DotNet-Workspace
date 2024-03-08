namespace functionWithoutArgAndWithReturnValue
{
    internal class Program
    {
        static int sum()
        {
            Console.WriteLine("Enter 2 numbers:");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int res=num1 + num2;
            return res;
        }
        static void Main(string[] args)
        {
            int result=sum();
            Console.WriteLine(result);
        }
    }
}
