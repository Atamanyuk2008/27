
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, -4, 7, -19, 25, -1, 12 };
            FindMaxElement(array);
            FindMinElement(array);
            SwapMaxMinElements(array);
            Console.WriteLine();
            FindNumberOfElementsBetweenMaxAndMin(array);
            Console.ReadKey();
        }
        public static void FindMaxElement(int[] array)
        {
            int max = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
            Console.WriteLine($"Максимальный элемент {max}  его индекс {index}");
        }
        public static void FindMinElement(int[] array)
        {
            int min = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            Console.WriteLine($"Минимальный элемент {min}  его индех {index}");
        }
        public static void SwapMaxMinElements(int[] array)
        {
            int max = array[0];
            int min = array[0];
            int indexMax = 0;
            int indexMin = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indexMax = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    indexMin = i;
                }
            }
            array[indexMax] = min;
            array[indexMin] = max;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public static void FindNumberOfElementsBetweenMaxAndMin(int[] array)
        {
            int max = array[0];
            int min = array[0];
            int indexMax = 0;
            int indexMin = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indexMax = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    indexMin = i;
                }
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i > indexMin && i < indexMax)
                {
                    count++;
                }
            }
            Console.WriteLine($"Кол-во элементов между максимальным и минимальным: {count}");
        }
    }
}
