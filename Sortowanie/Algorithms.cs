﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    class Algorithms
    {
        //Sorting algorithms
        public static void InsertionSort(int[] t)
        {
            for (uint i = 1; i < t.Length; i++)
            {
                uint j = i; // elementy 0 .. i-1 są już posortowane
                int Buf = t[j]; // bierzemy i-ty (j-ty) element
                while ((j > 0) && (t[j - 1] > Buf))
                { // przesuwamy elementy
                    t[j] = t[j - 1];
                    j--;
                }
                t[j] = Buf; // i wpisujemy na docelowe miejsce
            }
        }
        //^Insertion Sort
        public static void SelectionSort(int[] t)
        {
            uint k;
            for (uint i = 0; i < (t.Length - 1); i++)
            {
                int Buf = t[i]; // bierzemy i-ty element
                k = i; // i jego indeks
                for (uint j = i + 1; j < t.Length; j++)
                    if (t[j] < Buf) // szukamy najmniejszego z prawej
                    {
                        k = j;
                        Buf = t[j];
                    }
                t[k] = t[i]; // zamieniamy i-ty z k-tym
                t[i] = Buf;
            }
        }
        //^Selection Sort
        public static void CocktailSort(int[] t)
        {
            int Left = 1, Right = t.Length - 1, k = t.Length - 1;
            do
            {
                for (int j = Right; j >= Left; j--) // przesiewanie od dołu
                    if (t[j - 1] > t[j])
                    {
                        int Buf = t[j - 1]; 
                        t[j - 1] = t[j]; 
                        t[j] = Buf;
                        k = j; // zamiana elementów i zapamiętanie indeksu
                    }
                Left = k + 1; // zacieśnienie lewej granicy
                for (int j = Left; j <= Right; j++) // przesiewanie od góry
                    if (t[j - 1] > t[j])
                    {
                        int Buf = t[j - 1]; 
                        t[j - 1] = t[j]; 
                        t[j] = Buf;
                        k = j; // zamiana elementów i zapamiętanie indeksu
                    }
                Right = k - 1; // zacieśnienie prawej granicy
            }
            while (Left <= Right);
        }
        //^Coctail Sort
        //-------------Heap Sort
        public static void Heapify(int[] t, uint left, uint right)
        {
            uint i = left,
            j = 2 * i + 1;
            int buf = t[i]; // ojciec
            while (j <= right) // przesiewamy do dna stogu
            {
                if (j < right) // wybieramy większego syna
                    if (t[j] < t[j + 1]) j++;
                if (buf >= t[j]) break;
                t[i] = t[j];
                i = j;
                j = 2 * i + 1; // przechodzimy do dzieci syna
            }
            t[i] = buf;
        }

        public static void HeapSort(int[] t)
        {
            uint left = ((uint)t.Length / 2),
            right = (uint)t.Length - 1;
            while (left > 0) // budujemy kopiec idąc od połowy tablicy
            {
                left--;
                Heapify(t, left, right);
            }
            while (right > 0) // rozbieramy kopiec
            {
                int buf = t[left];
                t[left] = t[right];
                t[right] = buf; // największy element
                right--; // kopiec jest mniejszy
                Heapify(t, left, right); // ale trzeba go naprawić
            }
        }
        //-------------Heap Sort

        //-------------Quick Sort Rec
        public static void QuickSortRec(int[] t, int l, int p)
        {
            int i, j, x;
            i = l;
            j = p;
            x = t[(l + p) / 2]; // (pseudo)mediana
            do
            {
                while (t[i] < x) i++; // przesuwamy indeksy z lewej
                while (x < t[j]) j--; // przesuwamy indeksy z prawej
                if (i <= j) // jeśli nie minęliśmy się indeksami (koniec kroku)
                { // zamieniamy elementy
                    int buf = t[i]; 
                    t[i] = t[j]; 
                    t[j] = buf;
                    i++; 
                    j--;
                }
            }
            while (i <= j);
            if (l < j) QuickSortRec(t, l, j); // sortujemy lewą część (jeśli jest)
            if (i < p) QuickSortRec(t, i, p); // sortujemy prawą część (jeśli jest)
        }
        //-------------Quick Sort Rec


        //-------------Quick Sort Iter
        public static void QuickSortIter(int[] t)
        {
            int i, j, l, p, sp;
            int[] stos_l = new int[t.Length],
            stos_p = new int[t.Length]; 
            sp = 0; 
            stos_l[sp] = 0; 
            stos_p[sp] = t.Length - 1; 
            do
            {
                l = stos_l[sp]; 
                p = stos_p[sp]; sp--; 
                do
                {
                    int x;
                    i = l; j = p; 
                    x = t[(l + p) / 2];
                    //x = t[Driver.rnd.Next(i, j)];
                    //x = t[j]; 
                    do
                    {
                        while (t[i] < x) i++;
                        while (x < t[j]) j--;
                        if (i <= j)
                        {
                            int buf = t[i]; 
                            t[i] = t[j]; 
                            t[j] = buf;
                            i++; j--;
                        }
                    } while (i <= j);
                    if (i < p) {
                        sp++; 
                        stos_l[sp] = i; 
                        stos_p[sp] = p; 
                    }
                    p = j;
                } while (l < p);
            } while (sp >= 0);
        }
        //-------------Quick Sort Iter

    }
}