using System.Collections;
namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hT=new Hashtable();
            hT.Add("Uid",001);
            hT.Add("Name","Anshad");
            hT.Add("Place","Kozhikode");
            hT.Add("Phone",9846197067);
            hT.Add("Email","anshadu@gmail.com");
            //Console.WriteLine(hT["Name"]);
            foreach (object key in hT.Keys)
            {
                Console.WriteLine(key+":"+hT[key]);   
            }

        }
    }
}
