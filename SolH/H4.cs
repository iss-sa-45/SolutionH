using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolH
{
    class H4
    {
        public static int FindWord(string s1, string s2)
        {
            s1 = s1.ToUpper();
            s2 = s2.ToUpper();

            if (s2.Length > s1.Length) return -1;

            if (s2.Length == s1.Length) return 0;

            for (int i = 0; i < s1.Length; i++)
            {
                if (i + s2.Length > s1.Length) return -1;

                if (s1[i] == s2[0])
                {
                    bool different = false;
                    //initiate comparison
                    for (int j = 1; j < s2.Length; j++)
                    {
                        if (s1[i + j] != s2[j])
                        {
                            //not the same
                            different = true;
                            break;
                        }
                    }
                    if (!different) return i;
                }
            }
            return -1;
        }

        static void Main()
        {
            Console.WriteLine(FindWord("The brown fox", "O"));
            Console.WriteLine(FindWord("The brown fox", "FOX"));
            Console.WriteLine(FindWord("The brown fox", "bRO"));
            Console.WriteLine(FindWord("T", "bRO"));
            Console.WriteLine(FindWord("The brash basah complex", "bRO"));
        }
    }
}
