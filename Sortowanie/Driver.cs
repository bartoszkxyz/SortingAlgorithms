namespace Sortowanie
{
    internal class Driver
    {
        //declaration of rng
        static Random rnd = new Random(Guid.NewGuid().GetHashCode());
        
        
        static void Main(string[] args)
        {
            Console.WriteLine($"Metoda \t 50k \t 60k \t 70k \t 80k \t 90k \t 100k \t 110k \t 120k \t 130k \t 140k \t 150k \t 160k \t 170k \t 180k \t 190k \t 200k");
            for (int i = 50000; i < 200000; i+=10000)
            {
                int[] NumbersToSort = new int[i];
                Generators.GenerateRandomArray(NumbersToSort, rnd);
                //start pomiaru czasu
                var watch = System.Diagnostics.Stopwatch.StartNew();
                Algorithms.InsertionSort(NumbersToSort);
                watch.Stop();
                Console.Write(watch.ElapsedMilliseconds.ToString() + " \t ");
                //stop pomiaru czasu
            }

        }
    }
}