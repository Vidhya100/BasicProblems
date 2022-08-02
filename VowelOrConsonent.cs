using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public static class VowelOrConsonent
    {
        public static void CheckVowelOrConsonent()
        {
            Console.WriteLine("Enter alphabet.");
            string ch = Console.ReadLine();

            if (ch == "a" || ch == "e" || ch == "i" || ch == "o" || ch == "u")
            {
                Console.WriteLine("Given {0} is Vowel.",ch);
            }
            else
            {
                Console.WriteLine("Given {0} is Consonent.", ch);
            }
        }
    }
}
