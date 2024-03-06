namespace MiddleAgeThreeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int person1 = 95, person2 = 50, person3 = 80;
            if (person1 > person2 && person1 < person3)
            {
                Console.WriteLine(person1 + " is middle age");
            }else if (person2 > person1 && person2 < person3)
            {
                Console.WriteLine(person2 + " is middle age");
            }else
            {
                Console.WriteLine(person3 + " is middle age");
            }
        }
    }
}
