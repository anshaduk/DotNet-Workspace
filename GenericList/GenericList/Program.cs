using System.Collections.Generic;
namespace GenericList
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(1);
            li.Add(2);
            li.Add(3);
            li.Add(4);
            li.Add(5);

            //insert an item into the middle of list
            li.Insert(1, 100);
            //remove/delete an item from the list
            li.Remove(3);
            //remove an item from the list by using index
            li.RemoveAt(1);

            foreach (var item in li)
            {
                Console.WriteLine(item);
            }

        }
    }
}
