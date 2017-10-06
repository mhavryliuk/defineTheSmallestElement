using System;

// Task: write a program that defines the smallest element in the array and its index.

// Задача: написать программу, которая определяет наименьший элемент в массиве и его порядковый номер.

namespace defineTheSmallestElement
{
    class Program
    {
        static int[] Input()
        {
            Console.Write("Size of array: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }

        static int Min(int[] a, out int index)
        {
            int min = a[0];
            index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    index = i;
                }
            }
            return min;
        }

        static void Main()
        {
            int[] a = Input();
            int index;
            int min = Min(a, out index);
            Console.WriteLine("\nThe smallest element {0} with the index {1}", min, index);

            Console.ReadLine();
        }
    }
}