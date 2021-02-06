using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class InsertSort
    {
        public int[] Sort(int[] arrayToSort)
        {
            int min = 0;

            for (int index = 0; index < arrayToSort.Length; index++)
            {
                for (int index2 = index; index2 < arrayToSort.Length; index2++)
                {
                    if(arrayToSort[index2] < arrayToSort[min])
                    {
                        min = index2;
                    }
                }

                int temp = arrayToSort[index];
                arrayToSort[index] = arrayToSort[min];
                arrayToSort[min] = temp;
            }

            return arrayToSort;
        }
    }
}
