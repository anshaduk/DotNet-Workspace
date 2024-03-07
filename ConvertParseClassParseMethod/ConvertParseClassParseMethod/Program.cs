namespace ConvertParseClassParseMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using Conver class
            //var num1 = Convert.ToInt32(Console.ReadLine());
            //var num2 =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num1+num2);

            //using Parse method
            //var a=int.Parse(Console.ReadLine());
            //var b=int.Parse(Console.ReadLine()); 
            //Console.WriteLine(a+b);

            var x=Convert.ToInt32(null);
            Console.WriteLine(x);

            var y = int.Parse(null);
            Console.WriteLine(y);
        }
    }
}
