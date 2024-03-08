namespace CallByOutput
{
    internal class Program
    {
        static void ariththmetic(int a,int b,out int s ,out int p)
        {
            
            s = a + b;
            p = a * b;
        }
        static void Main(string[] args)
        {
            int a=10,b=20,sum,prod;
            ariththmetic(a, b, out sum, out prod);
            Console.WriteLine("sum={0} and product={1}",sum,prod);
        }
    }
}
