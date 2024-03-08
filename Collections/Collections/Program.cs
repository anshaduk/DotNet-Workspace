namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr=new int[10];
            //Array.Resize(ref arr, 15);

            int[] oldArray=new int[5] { 1, 2, 3, 4, 5 };

            //to create newArray and copy the elements

            //int[] newArray=new int[7];
            //Array.Copy(oldArray,newArray, oldArray.Length);
            //foreach (var item in newArray)
            //{
            //    Console.Write(item + " ");
            //}

            Array.Resize(ref oldArray, 7);
            foreach (var item in oldArray)
            {
                Console.WriteLine(item + " ");
            }

        }
    }
}
