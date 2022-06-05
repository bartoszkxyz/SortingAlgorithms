using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    class Generators
    {
        //Integer arrays generators
        public static void GenerateAscending(int[] t)
        {
            for (int i = 0; i < t.Length; ++i) t[i] = i;
        }
        public static void GenerateDescending(int[] t)
        {
            for (int i = (t.Length); i > 0; i--) t[i - 1] = i;
        }
        public static void GenerateRandom(int[] t, Random rnd, int maxValue = int.MaxValue)
        {
            for (int i = 0; i < t.Length; ++i) t[i] = rnd.Next(maxValue);
        }
        public static void GenerateConstans(int[] t)
        {
            for (int i = 0; i < t.Length; ++i) t[i] = 10000;
        }
        public static void GenerateVShape(int[] t)
        {
            int counter = 0;
            for (int i = (t.Length / 2); i > 0; i--) t[counter++] = i;
            for (int i = 1; i <= t.Length / 2; i++) t[counter++] = i;
        }        
        public static void GenerateAShape(int[] t)
        {
            int counter = 0;
            for (int i = 1; i <= t.Length/2; ++i) t[counter++] = i;
            for (int i = t.Length/2; i > 0; i--) t[counter++] = i;
        }

    }
}