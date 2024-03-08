namespace CallByValue
{
    internal class Program
    {
        static void swap(int a, int b)
        {
            int temp;
            temp = a;
            a= b;
            b= temp; 
        }
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            Console.WriteLine("Before swaping x={0} and y={1}",x,y);
            swap(x,y);
            Console.WriteLine("After swaping x={0} and y={1}", x, y);
        }
    }
}
