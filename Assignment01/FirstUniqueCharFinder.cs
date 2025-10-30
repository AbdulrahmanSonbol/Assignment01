using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal class FirstUniqueCharFinder
    {

        public static char FindFirstNonRepeating(string name)
        {
            int[] freq = new int[26]; 

            foreach (char c in name)
            {
                if (char.IsLetter(c))
                {
                    char lower = char.ToLower(c);
                    freq[lower - 'a']++;
                }
            }

            foreach (char c in name)
            {
                if (char.IsLetter(c))
                {
                    char lower = char.ToLower(c);
                    if (freq[lower - 'a'] == 1)
                        return c; 
                }
            }

            return '0';

        }

    }
}
