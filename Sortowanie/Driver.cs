namespace Sortowanie
{
    internal class Driver
    {
        //declaration of rng
        static public Random rnd = new Random(Guid.NewGuid().GetHashCode());

        static void Main(string[] args)
        {
            var option = 0;
            do
            {
                Console.WriteLine("1. Insertion Sort.");
                Console.WriteLine("2. Selection Sort.");
                Console.WriteLine("3. Cocktail Sort.");
                Console.WriteLine("4. Heap Sort.");
                Console.WriteLine("5. Exit.");
                option = int.Parse(Console.ReadLine());
                
                switch (option)
                {
                    default: Console.Clear(); Options.Option(option); break;
                    case 5: Console.Clear(); return;
                }
            } while (option != 5);
        }
    }
}