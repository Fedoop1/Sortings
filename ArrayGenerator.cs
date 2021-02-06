using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class ArrayGenerator
    {
        Random rnd = new Random(DateTime.Now.Millisecond);

        public int[] Generate(int size)
        {
            int[] newArray = new int[size];

            for (int index = 0; index < newArray.Length; index++)
            {
                newArray[index] = rnd.Next(0, 1000);
            }

            return newArray;
        }
    }
}
