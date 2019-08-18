using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class CountCharacters
    {
        public int Countcharacters(string[] words, string chars)
        {
            Dictionary<char,int> map = new Dictionary<char,int>();
            int q=0;
            foreach (char ch in chars.ToCharArray())
            {
                if(!map.ContainsKey(ch))
                map.Add(ch, q++);
            }
            Stack<string> stack = new Stack<string>();

            foreach (string str in words)
            { 
                stack.Push(str);
                foreach (char chtemp  in str.ToCharArray())
                {
                    if (!map.ContainsKey(chtemp))
                    {
                        stack.Pop();
                        break;
                    }
                }
            }
            int length = 0;
            while (stack.Count >  0)
            {
                string currentString = stack.Peek();
                length += currentString.Length;
                stack.Pop();
            }
           
                
            


            return length;
        }
    }
}
