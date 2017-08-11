using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolH
{
    class H3
    {
        public static bool InString(string s1, string s2)
        {
            s1 = s1.ToUpper();
            s2 = s2.ToUpper();

            if (s2.Length > s1.Length) return false;

            if (s2.Length == s1.Length) return s1 == s2;

            for (int i = 0; i < s1.Length; i++)
            {
                if (i + s2.Length > s1.Length) return false;

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
                    if (!different) return true;
                }
            }
            return false;
        }

        static void Main()
        {
            Console.WriteLine(InString("The brown fox", "O"));
            Console.WriteLine(InString("The brown fox", "FOX"));
            Console.WriteLine(InString("The brown fox", "bRO"));
            Console.WriteLine(InString("T", "bRO"));
            Console.WriteLine(InString("The brash basah complex", "bRO"));
        }
    }
}
