namespace UserLoginCheckIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String username = "xyz";
            String pwd = "123456";
            if(username.Equals("xyz")&&pwd.Equals("12345")) {
                Console.WriteLine("Login Success");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }
        }
    }
}
