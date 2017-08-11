using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolH
{
    class H7
    {
        static void SetArray(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }
        }

        static void Main()
        {
            int[] A = new int[] { 1, 2, 3, 4, 5, 6 };
            H2.PrintArray(A);
            SetArray(A, 999);
            H2.PrintArray(A);
        }
    }
}
