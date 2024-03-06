namespace ForeachExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3 };
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            String name = "Amna Anshad";
            name.GetEnumerator();
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        

        }
    }
}
