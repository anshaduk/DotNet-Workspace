namespace ConsoleApp1VarConstant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //const int a = 10;
            //a = 20;
            //Console.WriteLine(a);
            //Console.WriteLine(100 + 200);

            int x = 6;
            int y = 12;
            int z = 0;

            //bitwise AND
            z = x & y;
            Console.WriteLine("AND "+z);

            //bitwise OR
            z = x | y;
            Console.WriteLine("OR "+z);

            //bitwise XOR
            z = x ^ y;
            Console.WriteLine("XOR "+z);

            //Left Shift
            z = x << 1;
            Console.WriteLine("LeftShift " + z);

            //Right Shift
            z = x >> 1;
            Console.WriteLine("Right Shift " + z);

        }
    }
}
