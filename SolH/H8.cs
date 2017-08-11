using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolH
{
    class H8
    {
        static int[] ResizeArray(int[] array, int newsize)
        {
            int[] newArray = new int[newsize];

            int limit = Math.Min(array.Length, newsize); //coz the newsize may not be always bigger than array.Length

            for (int i = 0; i < limit; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }

        static void Main()
        {
            int[] A = new int[] { 1, 2, 3, 4, 5 };
            H2.PrintArray(A);

            int[] B = ResizeArray(A, 10);
            H2.PrintArray(B);

            int[] C = ResizeArray(B, 3);
            H2.PrintArray(C);
        }
    }
}
