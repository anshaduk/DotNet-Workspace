namespace GreatestAmong4Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1000, b = 3000, c = 5000, d = 100;
            if (a > b && a > c && a > d)
            {
                Console.WriteLine(a + " is greatest");
            }else if (b > c && b > d)
            {
                Console.WriteLine(b +" is greatest");
            }else if(c>d)
            {
                Console.WriteLine(c +" is greatest");
            }
            else
            {
                Console.WriteLine(d + " is greatest");
            }
            {
                
            }
        }
    }
}
