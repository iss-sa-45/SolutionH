using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolH
{
    class H5
    {
        public static string Hex(int i)
        {
            char[] hexChars = new char[]
            {'0', '1', '2', '3', '4',
             '5', '6', '7', '8', '9',
             'A', 'B', 'C', 'D', 'E', 'F' };

            string hex = "";

            do
            {
                int remainder = i % 16;
                hex = hexChars[remainder] + hex;

                i = i / 16;

            } while (i > 0);

            return hex;
        }

        static void Main()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(Hex(i));
            }
        }
    }
}
