using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolH
{
    class H9
    {
        static bool IsPrime(int n)
        {
            bool prime = false;
            if (n <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                        return false;
                }

                //there's no other factor between 1 and n so it must be prime
                return true;
            }
        }

        static void Main()
        {
            for (int i = 0; i < 100; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine("{0} is a prime number.", i);
                }
            }
        }
    }
}
