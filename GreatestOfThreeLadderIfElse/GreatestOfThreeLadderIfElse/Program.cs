namespace GreatestOfThreeLadderIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 150,b=100,c=20;
            if (a > b && a > c)
            {
                Console.WriteLine(a + " is greatest");
            }else if (b > a && b > c)
            {
                Console.WriteLine(b +" is greatest");
            }else
            {
                Console.WriteLine(c + " is greatest");
            }
        
        }
    }
}
