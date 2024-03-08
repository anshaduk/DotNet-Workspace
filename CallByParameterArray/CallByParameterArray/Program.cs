namespace CallByParameterArray
{
    internal class Program
    {
        static void ParArray(params int[] a)
        {

            Console.WriteLine("\nArray elements are..");
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }

        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            ParArray(a);
            ParArray();
            ParArray(10, 20);
        }
    }
}
