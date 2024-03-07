namespace FunctionSample
{
    internal class Program
    {
       void MyMethod(string name="Anshad")
        {
            Console.WriteLine(name);
        }
        
        static void Main(string[] args)
        {
            //MyMethod("Ram");
            Program instance = new Program();
            instance.MyMethod();
            instance.MyMethod("Ram");

            //simple function
            //void message()
            //{
            //    Console.WriteLine("Good morning...");
            //}
            //message();
            //message();

            //function with parameters
            //void sum(int num1,int num2)
            //{
            //    int sum=num1 + num2;
            //    Console.WriteLine("sum of two numbers is "+sum);
            //}
            //sum(10, 20);
            //sum(100, 200);

            //function with return type
            //int findSquare(int x)
            //{
            //    int result = x * x;
            //    return result;
            //}
            //int output=findSquare(12);
            //Console.WriteLine(output);
        }
    }
}
