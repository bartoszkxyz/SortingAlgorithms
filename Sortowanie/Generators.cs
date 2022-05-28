using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    class Generators
    {
        //arrays generators
        public static void GenerateAscendingArray(int[] t)
        {
            for (int i = 0; i < t.Length; ++i) t[i] = i;
        }
        public static void GenerateDescendingArray(int[] t)
        {
            for (int i = (t.Length); i > 0; i--) t[i - 1] = i;
        }
        public static void GenerateRandomArray(int[] t, Random rnd, int maxValue = int.MaxValue)
        {
            for (int i = 0; i < t.Length; ++i) t[i] = rnd.Next(maxValue);
        }
        public static void GenerateConstansArray(int[] t)
        {
            for (int i = 0; i < t.Length; ++i) t[i] = 10000;
        }
        public static void GenerateVShape(int[] t)
        {
            int counter = 0;
            for (int i = (t.Length / 2); i > 0; i--) t[counter++] = i;
            for (int i = 1; i < ((t.Length / 2) + 1); i++) t[counter++] = i;
        }
    }
}
