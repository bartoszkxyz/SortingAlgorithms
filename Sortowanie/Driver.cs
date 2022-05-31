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
                Console.WriteLine("---- Choose Sorting Method ----");
                Console.WriteLine("1. Insertion Sort.");
                Console.WriteLine("2. Selection Sort.");
                Console.WriteLine("3. Cocktail Sort.");
                Console.WriteLine("4. Heap Sort.");
                Console.WriteLine("5. Quick Sort Rec.");
                Console.WriteLine("6. Quick Sort Iter.");
                Console.WriteLine("7. Exit.");
                option= int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1: Console.Clear(); Options.InsertionOption(); break;
                    case 2: Console.Clear(); Options.SelectionOption(); break;
                    case 3: Console.Clear(); Options.CocktailOption(); break;
                    case 4: Console.Clear(); Options.HeapOption(); break;
                    case 5: Console.Clear(); Options.QuickSortRecOption(); break;
                    case 6: Console.Clear(); Options.QuickSortIterOption(); break;
                    case 7: Console.Clear(); return;
                }
            } while (option != 7);
        }
    }
}