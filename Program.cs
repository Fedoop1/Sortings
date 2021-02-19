using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayGenerator arrayGenerator = new ArrayGenerator();
            InsertSort insertSort = new InsertSort();

            int[] insertSortMas = arrayGenerator.Generate(10);

            Console.WriteLine("\nBefore:");
            foreach (var item in insertSortMas)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n--- Insert Sort ---");
            insertSortMas = insertSort.Sort(insertSortMas);

            Console.WriteLine("After:");
            foreach (var item in insertSortMas)
            {
                Console.Write(item + " ");
            }

            QuickSort quickSort = new QuickSort();
            int[] quickSortMas = arrayGenerator.Generate(10);

            Console.WriteLine("\n\nBefore:");
            foreach (var item in quickSortMas)
            {
                Console.Write(item + " ");
            }

            int[] quickSorted = quickSort.Sort(quickSortMas);

            Console.WriteLine("\n--- Quick Sort ---");
            Console.WriteLine("After:");
            foreach (var item in quickSorted)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();

            
        }
    }
}
