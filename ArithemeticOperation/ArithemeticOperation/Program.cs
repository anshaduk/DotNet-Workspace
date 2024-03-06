namespace ArithemeticOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2=int.Parse(Console.ReadLine());
            int sum=num1+ num2;
            Console.WriteLine("Sum=" + sum);
            Console.WriteLine($"Substraction={num1-num2}");
            Console.WriteLine($"Division={num1 / num2}");
            Console.WriteLine($"Multiplication={num1 * num2}");
            Console.WriteLine($"Modulus={num1 % num2}");
        }
    }
}
