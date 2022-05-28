using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    class Options
    {
        static public void InsertionOption()
        {
            Console.WriteLine("---- Insertion Sort ---- \nSize \t Time(ms)");
            for (int j = 0; j < 5; j++)
            {
                switch (j)
                {
                    case 0: Console.WriteLine("-- Random Array --"); break;
                    case 1: Console.WriteLine("-- Constant Array --"); break;
                    case 2: Console.WriteLine("-- Ascending Array --"); break;
                    case 3: Console.WriteLine("-- Descending Array --"); break;
                    case 4: Console.WriteLine("-- V-Shape Array --"); break;
                }
                for (int i = 50000; i <= 200000; i += 10000)
                {
                    int[] NumbersToSort = new int[i];
                    switch (j)
                    {
                        case 0: Generators.GenerateRandom(NumbersToSort, Driver.rnd); break;
                        case 1: Generators.GenerateConstans(NumbersToSort); break;
                        case 2: Generators.GenerateAscending(NumbersToSort); break;
                        case 3: Generators.GenerateDescending(NumbersToSort); break;
                        case 4: Generators.GenerateVShape(NumbersToSort); break;
                    }
                    //start pomiaru czasu
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    Algorithms.InsertionSort(NumbersToSort);
                    watch.Stop();
                    //stop pomiaru czasu
                    Console.WriteLine($"{i} \t {watch.ElapsedMilliseconds}");
                }
            }
        }        
        static public void SelectionOption()
        {
            Console.WriteLine("---- Selection Sort ---- \nSize \t Time(ms)");
            for (int j = 0; j < 5; j++)
            {
                switch (j)
                {
                    case 0: Console.WriteLine("-- Random Array --"); break;
                    case 1: Console.WriteLine("-- Constant Array --"); break;
                    case 2: Console.WriteLine("-- Ascending Array --"); break;
                    case 3: Console.WriteLine("-- Descending Array --"); break;
                    case 4: Console.WriteLine("-- V-Shape Array --"); break;
                }
                for (int i = 50000; i <= 200000; i += 10000)
                {
                    int[] NumbersToSort = new int[i];
                    switch (j)
                    {
                        case 0: Generators.GenerateRandom(NumbersToSort, Driver.rnd); break;
                        case 1: Generators.GenerateConstans(NumbersToSort); break;
                        case 2: Generators.GenerateAscending(NumbersToSort); break;
                        case 3: Generators.GenerateDescending(NumbersToSort); break;
                        case 4: Generators.GenerateVShape(NumbersToSort); break;
                    }
                    //start pomiaru czasu
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    Algorithms.SelectionSort(NumbersToSort);
                    watch.Stop();
                    //stop pomiaru czasu
                    Console.WriteLine($"{i} \t {watch.ElapsedMilliseconds}");
                }
            }
        }        
        static public void CocktailOption()
        {
            Console.WriteLine("---- Cocktail Sort ---- \nSize \t Time(ms)");
            for (int j = 0; j < 5; j++)
            {
                switch (j)
                {
                    case 0: Console.WriteLine("-- Random Array --"); break;
                    case 1: Console.WriteLine("-- Constant Array --"); break;
                    case 2: Console.WriteLine("-- Ascending Array --"); break;
                    case 3: Console.WriteLine("-- Descending Array --"); break;
                    case 4: Console.WriteLine("-- V-Shape Array --"); break;
                }
                for (int i = 50000; i <= 200000; i += 10000)
                {
                    int[] NumbersToSort = new int[i];
                    switch (j)
                    {
                        case 0: Generators.GenerateRandom(NumbersToSort, Driver.rnd); break;
                        case 1: Generators.GenerateConstans(NumbersToSort); break;
                        case 2: Generators.GenerateAscending(NumbersToSort); break;
                        case 3: Generators.GenerateDescending(NumbersToSort); break;
                        case 4: Generators.GenerateVShape(NumbersToSort); break;
                    }
                    //start pomiaru czasu
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    Algorithms.CocktailSort(NumbersToSort);
                    watch.Stop();
                    //stop pomiaru czasu
                    Console.WriteLine($"{i} \t {watch.ElapsedMilliseconds}");
                }
            }
        }        
        static public void HeapOption()
        {
            Console.WriteLine("---- Heap Sort ---- \nSize \t Time(ms)");
            for (int j = 0; j < 5; j++)
            {
                switch (j)
                {
                    case 0: Console.WriteLine("-- Random Array --"); break;
                    case 1: Console.WriteLine("-- Constant Array --"); break;
                    case 2: Console.WriteLine("-- Ascending Array --"); break;
                    case 3: Console.WriteLine("-- Descending Array --"); break;
                    case 4: Console.WriteLine("-- V-Shape Array --"); break;
                }
                for (int i = 50000; i <= 200000; i += 10000)
                {
                    int[] NumbersToSort = new int[i];
                    switch (j)
                    {
                        case 0: Generators.GenerateRandom(NumbersToSort, Driver.rnd); break;
                        case 1: Generators.GenerateConstans(NumbersToSort); break;
                        case 2: Generators.GenerateAscending(NumbersToSort); break;
                        case 3: Generators.GenerateDescending(NumbersToSort); break;
                        case 4: Generators.GenerateVShape(NumbersToSort); break;
                    }
                    //start pomiaru czasu
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    Algorithms.HeapSort(NumbersToSort);
                    watch.Stop();
                    //stop pomiaru czasu
                    Console.WriteLine($"{i} \t {watch.ElapsedMilliseconds}");
                }
            }
        }        
        static public void Option(int op)
        {
            switch (op)
            {
                case 1: InsertionOption(); break;
                case 2: SelectionOption(); break;
                case 3: CocktailOption(); break;
                case 4: HeapOption(); break;
                default:
                    break;
            }
        }
    }
}
