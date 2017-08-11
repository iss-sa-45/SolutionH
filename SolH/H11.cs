using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolH
{
    class H11
    {
        delegate double DoubleOps(double x);

        static double[] ProcessArray(double[] arr, DoubleOps ops)
        {
            double[] newArray = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = ops(arr[i]);
            }

            return newArray;
        }

        static void Main()
        {
            double[] A = new double[] { 1.0, 2.0, 3.0, 4.0 };
            double[] B = ProcessArray(A, Sqrt);

            PrintArray(B);
        }

        static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        public static void PrintArray(double[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine("]");
        }
    }
}
