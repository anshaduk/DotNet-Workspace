namespace SalaryCheckUsingIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salary = 10000;
            if(salary<10000)
            {
                salary += 500;
            }
            Console.WriteLine(salary);
        }
    }
}
