namespace Generic1
{
    internal class Program
    {
        public bool Compare(int x, int y)
        {
            if (x==y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();//create an instance
            bool res=obj.Compare(20, 20);
            Console.WriteLine(res);
        }
    }
}
