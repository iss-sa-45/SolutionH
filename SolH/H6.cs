using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolH
{
    class H6
    {
        public static string Substitute(string s, char c1, char c2)
        {
            string newString = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c1)
                {
                    newString += c2;
                }
                else
                {
                    newString += s[i];
                }
            }
            return newString;
        }

        static void Main()
        {
            Console.WriteLine(Substitute("abcde", 'a', 'Z'));
        }
    }
}
