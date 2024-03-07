namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var a=Console.ReadLine();
            //var b=Console.ReadLine();
            //Console.WriteLine($"Sum of 2 numbers ={a+b}");

            //Implicit conversion
            //int age = 10;
            //long myAge= age;
            //Console.WriteLine(myAge);

            //char a = 'b';
            //int c = 10;
            //Console.WriteLine(c+a);

            //Explicit type conversion
            int a;
            float b = 10.5F;
            a =(int) b;
            Console.WriteLine(a);

            long first=long.MaxValue;
            int second=(int)first;//Type Cast
            Console.WriteLine(first);
            Console.WriteLine(second);

            double third=35.45;
            second=(int)third;
            Console.WriteLine(second);

            //String str = "10";
            //int newStr = int.Parse(str);
            //Console.WriteLine(newStr);

        }
    }
}
