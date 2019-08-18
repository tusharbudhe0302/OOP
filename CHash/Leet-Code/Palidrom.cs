using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class Palindrome
    {
        public static void PrintPalidrom(string s)
        {
            char [] ip = s.ToCharArray() ;
            Array.Reverse(ip);
            string reverse = new string(ip);
           bool isPalindrome = reverse.Equals(s, StringComparison.OrdinalIgnoreCase);
            if (isPalindrome)
            {
                Console.WriteLine(s + " is Palindrome.");
            }
            else
            {
                Console.WriteLine(s + " is  not Palindrome.");
            }
        }
    }

}
