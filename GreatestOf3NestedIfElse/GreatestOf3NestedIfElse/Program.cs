namespace GreatestOf3NestedIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 300, b = 200, c = 50;
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a + " is greatest");
                }
                else
                {
                    Console.WriteLine(c +" is greatest");
                }
            }
            else
            {
                if(b>c)
                {
                    Console.WriteLine(b + " is greatest");
                }
            }
        }
    }
}
