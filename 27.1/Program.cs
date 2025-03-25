using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Input(array);
            Output1(array);
            Output2(array);
            Console.ReadKey();
        }

        static int[] Input(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"array[{i}]= ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }

        static void Output1(int[] array)
        {
            Console.WriteLine("for:");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }
        }

        static void Output2(int[] array)
        {
            Array.Reverse(array);
            Console.WriteLine("Reverse:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }
        }
    }
}
