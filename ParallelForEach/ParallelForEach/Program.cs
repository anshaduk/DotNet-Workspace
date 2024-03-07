using System.Threading.Tasks;
namespace ParallelForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            Parallel.ForEach(numbers, number =>
            {
                Console.WriteLine($"Number:{number},Thread:{Task.CurrentId}");
            });
        }
    }
}
