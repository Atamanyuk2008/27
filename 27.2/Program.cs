using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Random rand = new Random();
                int n = 10; 
                int[] array = new int[n];

                for (int i = 0; i < n; i++)
                {
                    array[i] = rand.Next(1, 101); 
                }

                Console.WriteLine("Массив до сортировки:");
                PrintArray(array);
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - 1 - i; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("\nМассив после сортировки :");
                PrintArray(array);
                for (int i = 0; i < n; i++)
                {
                    array[i] = rand.Next(1, 101);
                }
                Console.WriteLine("\nМассив до сортировки :");
                PrintArray(array);
                Array.Sort(array);
                Console.WriteLine("\nМассив после сортировки :");
                PrintArray(array);
            }
            static void PrintArray(int[] array)
            {
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine(); 
            Console.ReadKey();
        }
        
        }

    }

