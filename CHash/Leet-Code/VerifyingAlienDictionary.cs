using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class VerifyingAlienDictionary
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        public bool IsAlienSorted(string[] words, string order)
        {
            char[] orderCharList = order.ToCharArray();

            int k = 0;
            foreach (char ch in orderCharList)
            {
                map.Add(ch, k++);
            }
            for (int i = 0; i < words.Length - 1; i++)
            {
                string firstWord = words[i];
                string secondWord = words[i + 1];
                if (!rankCheck(firstWord, secondWord)) return false;
            }
            return true;
        }
        public bool rankCheck(string firstWord, string secondWord)
        {

            for (int j = 0; j < firstWord.Length; j++)
            {
                if (j >= secondWord.Length) return false;
                char char1 = firstWord[j];
                char char2 = secondWord[j];
                Console.WriteLine(char1 + " " + char2);
                int rank1 = map[char1];
                int rank2 = map[char2];
                if (rank1 > rank2) return false;
                else if (rank1 == rank2)
                    continue;
                else return true;
            }
            return true;
        }
    }

}
