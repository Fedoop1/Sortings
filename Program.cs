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

            Console.WriteLine("Before:");
            foreach (var item in insertSortMas)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n--- Insert Sort ---\n");
            insertSortMas = insertSort.Sort(insertSortMas);

            Console.WriteLine("After:");
            foreach (var item in insertSortMas)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();

            
        }
    }
}
