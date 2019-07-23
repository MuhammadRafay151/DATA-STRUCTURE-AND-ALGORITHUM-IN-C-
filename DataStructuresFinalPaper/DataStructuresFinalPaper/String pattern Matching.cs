using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalPaper
{
    class String_pattern_Matching
    {
        public void Naive(string text, string pattern)
        {
            bool flag;
            for (int i = 0; i <= text.Length - pattern.Length; i++)
            {
                flag = true;
                for (int j = 0; j < pattern.Length; j++)
                {
                    if (pattern[j] != text[i + j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    Console.WriteLine("Pattern match at {0}", i);
            }
        }
        public void Rabin_Karp(string text, string pattern)
        {
            long texthash;
            long patternhash;
            int radix = 256;
            int prime = 997;
            long rm = 1;
            for (int i = 0; i < pattern.Length - 1; i++)
            {
                rm = (radix * rm) % prime;
            }
            texthash = Hash(text, pattern.Length);
            patternhash = Hash(pattern, pattern.Length);
            for (int i = 0; i <= text.Length - pattern.Length; i++)
            {
                if (texthash == patternhash)
                    Console.WriteLine("Pattern match at {0}", i);
               
                    if (i<text.Length-pattern.Length )
                    {
                        texthash = (radix * (texthash - text[i] * rm) + text[pattern.Length + i]) % prime;
                        if (texthash < 0)
                            texthash += prime;
                    }

                
            }
        }
        public long Hash(string text, int length)
        {
            int d = 256;
            long u = 0;
            for (int i = 0; i < length; i++)
            {
                u = (d * u + text[i]) % 997;
            }
            return u;
        }
    }
}
