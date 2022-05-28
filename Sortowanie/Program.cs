namespace Sortowanie
{
    internal class Program
    {
        //declaration of rng
        static Random rnd = new Random(Guid.NewGuid().GetHashCode());
        static void Main(string[] args)
        {
            int[] NumbersToSort = new int[1000];
            Generators.GenerateRandomArray(NumbersToSort, rnd);
            Algorithms.InsertionSort(NumbersToSort);
            foreach (var item in NumbersToSort)
            {
                Console.WriteLine(item);
            }
        }
    }
}