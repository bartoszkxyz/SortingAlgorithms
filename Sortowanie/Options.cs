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
            using StreamWriter file = new("Data.txt", append: true);
            file.WriteLineAsync("---- Insertion Sort ---- \nSize \t Time(ms)");
            for (int j = 0; j < 5; j++)
            {
                switch (j)
                {
                    case 0: file.WriteLineAsync("-- Random Array --"); break;
                    case 1: file.WriteLineAsync("-- Constant Array --"); break;
                    case 2: file.WriteLineAsync("-- Ascending Array --"); break;
                    case 3: file.WriteLineAsync("-- Descending Array --"); break;
                    case 4: file.WriteLineAsync("-- V-Shape Array --"); break;
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
                    file.WriteLineAsync($"{watch.ElapsedMilliseconds}");
                    //streamWriter.WriteLine($"{i} \t {watch.ElapsedMilliseconds}");
                }
            }
        }
        static public void SelectionOption()
        {
            using StreamWriter file = new("Data.txt", append: true);
            file.WriteLineAsync("---- Selection Sort ---- \nSize \t Time(ms)");
            for (int j = 0; j < 5; j++)
            {
                switch (j)
                {
                    case 0: file.WriteLineAsync("-- Random Array --"); break;
                    case 1: file.WriteLineAsync("-- Constant Array --"); break;
                    case 2: file.WriteLineAsync("-- Ascending Array --"); break;
                    case 3: file.WriteLineAsync("-- Descending Array --"); break;
                    case 4: file.WriteLineAsync("-- V-Shape Array --"); break;
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
                    file.WriteLineAsync($"{watch.ElapsedMilliseconds}");
                }
            }
        }
        static public void CocktailOption()
        {
            using StreamWriter file = new("Data.txt", append: true);
            file.WriteLineAsync("---- Cocktail Sort ---- \nSize \t Time(ms)");
            for (int j = 0; j < 5; j++)
            {
                switch (j)
                {
                    case 0: file.WriteLineAsync("-- Random Array --"); break;
                    case 1: file.WriteLineAsync("-- Constant Array --"); break;
                    case 2: file.WriteLineAsync("-- Ascending Array --"); break;
                    case 3: file.WriteLineAsync("-- Descending Array --"); break;
                    case 4: file.WriteLineAsync("-- V-Shape Array --"); break;
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
                    file.WriteLineAsync($"{watch.ElapsedMilliseconds}");
                }
            }
        }
        static public void HeapOption()
        {
            using StreamWriter file = new("Data.txt", append: true);
            file.WriteLineAsync("---- Heap Sort ---- \nSize \t Time(ms)");
            for (int j = 0; j < 5; j++)
            {
                switch (j)
                {
                    case 0: file.WriteLineAsync("-- Random Array --"); break;
                    case 1: file.WriteLineAsync("-- Constant Array --"); break;
                    case 2: file.WriteLineAsync("-- Ascending Array --"); break;
                    case 3: file.WriteLineAsync("-- Descending Array --"); break;
                    case 4: file.WriteLineAsync("-- V-Shape Array --"); break;
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
                    //Console.WriteLine($"{i} \t {watch.ElapsedMilliseconds}");
                    file.WriteLineAsync($"{watch.ElapsedMilliseconds}");
                }
            }
        }

            static public void QuickSortRecOption()
            {
                using StreamWriter file = new("Data.txt", append: true);
                file.WriteLineAsync("---- Quick Sort Rec ----");
                file.WriteLineAsync("-- Random Array --");

                for (int i = 50000; i <= 200000; i += 10000)
                {
                    int[] NumbersToSort = new int[i];
                    Generators.GenerateRandom(NumbersToSort, Driver.rnd);

                    //start pomiaru czasu
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    Algorithms.QuickSortRec(NumbersToSort, 0, NumbersToSort.Length - 1);
                    watch.Stop();
                    //stop pomiaru czasu
                    file.WriteLineAsync($"{watch.ElapsedMilliseconds}");
                }
        }
        static public void QuickSortIterOption()
        {
            using StreamWriter file = new("Data.txt", append: true);
            file.WriteLineAsync("---- Quick Sort Iter ----");
            file.WriteLineAsync("-- Random Array --");
            
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] NumbersToSort = new int[i];
                Generators.GenerateRandom(NumbersToSort, Driver.rnd);

                //start pomiaru czasu
                var watch = System.Diagnostics.Stopwatch.StartNew();
                Algorithms.QuickSortIter(NumbersToSort);
                watch.Stop();
                //stop pomiaru czasu
                file.WriteLineAsync($"{watch.ElapsedMilliseconds}");
            }
        }
    }
}