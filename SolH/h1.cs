using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolH
{
    class H1
    {
        static int ReadInteger(string message)
        {
            Console.Write(message);
            int output;
            bool isParsable = false;

            do
            {
                isParsable = Int32.TryParse(Console.ReadLine(), out output);

                if (!isParsable)
                {
                    Console.WriteLine("Your input is not an integer.");
                }
            } while (!isParsable);

            return output;
        }

        static void Main(string[] args)
        {
            int x = ReadInteger("Please enter x: ");
            Console.WriteLine(x);
        }
    }
}
