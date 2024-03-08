namespace functionWithArgAndWithReturnvalue
{
    internal class Program
    {
        static int sum(int a,int b)
        {
            int res = a + b;
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers:");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());
            int result=sum(num1,num2);
            Console.WriteLine("Sum of 2 numbers= " + result);
        }
    }
}
