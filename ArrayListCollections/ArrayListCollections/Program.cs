using System.Collections;
namespace ArrayListCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList aL = new ArrayList();
            Console.WriteLine(aL.Capacity);
            aL.Add(100);
            Console.WriteLine(aL.Capacity);
            aL.Add(200);
            aL.Add(300);
            aL.Add(400);
            aL.Add(500);
            Console.WriteLine(aL.Capacity);
            aL.Insert(3, 1000);
            aL.Remove(200);
            aL.RemoveAt(1);
            foreach (object item in aL)
            {
                Console.WriteLine(item + "  ");
            }
            
        }
    }
}
