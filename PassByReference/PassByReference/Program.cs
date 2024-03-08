namespace PassByReference
{
    internal class Program
    {
        static void swap(ref int a,ref int b) {
            int temp;
            temp = a;
            a = b;
            b=temp;
        }
        static void Main(string[] args)
        {
            int x=10,y=20;
            Console.WriteLine("Before swaping x={0} and y={1}",x,y);
            swap(ref x,ref y);
            Console.WriteLine("After swaping x={0} and y={1}", x, y);
        }
    }
}
