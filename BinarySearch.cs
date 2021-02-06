using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class BinarySearch 
    {
        public int Search(int[] mas, int targer)
        {
            int min = 0;
            int high = mas.Length - 1;

            while(min <= high)
            {
                int midle = (min + high) / 2;
                int guess = mas[midle];

                if(guess.Equals(targer))
                {
                    return midle;
                }

                if (guess < targer)
                {
                    min = midle + 1;
                }
                else high = midle - 1;
            }

            return -1;
        }
    }
}
