using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class QuickSort
    {
        int[] array;
        int temp;
        public int[] Sort(int[] array)
        {
            this.array = array;
            Sort(0, array.Length - 1);
            return array;
        }

        private void Sort(int Left, int Right)
        {
            if(Left >= Right)
            {
                return; 
            }

            int pivot = Sorting(Left, Right);
            Sort(Left, pivot - 1);
            Sort(pivot + 1, Right);

        }

        private int Sorting(int Left, int Right)
        {
            int marker = Left;

            //pivot == Right(before 'for')
            for (int index = Left; index <= Right; index++)
            {
                if(array[index].CompareTo(array[Right]) == -1)
                {
                    temp = array[index];
                    array[index] = array[marker];
                    array[marker] = temp;
                    marker++;
                }
            }

            temp = array[marker];
            array[marker] = array[Right];
            array[Right] = temp;
            
            return marker;
            //pivot is marker
        }
    }
}
