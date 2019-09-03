using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class FractionToDecimal
    {
        public string FractionToDecimalCal(int numerator, int denominator)
        {
            float numerator2 = numerator;
            float denominator2 = denominator;
            float result = (numerator2 / denominator2);
            StringBuilder sb = new StringBuilder();
            sb.Append((int)result);
            double decimalresult = result - (int)result;
            int dotIndex = decimalresult.ToString().IndexOf('.');
            if (dotIndex < 0)
            {
                return sb.ToString();
            }
            sb.Append(".");
            string word = decimalresult.ToString().Substring(dotIndex + 1);
            Dictionary<char, int> map = new Dictionary<char, int>(); //Number and Count
            int k = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (!map.ContainsKey(word[i]))
                {
                    k = 1;
                    map.Add(word[i], k);
                }
                else
                {
                    k += 1;
                    map[word[i]] = k;
                }
            }
            foreach (var keyValue in map)
            {
                if (keyValue.Value > Convert.ToInt32(keyValue.Key.ToString()))
                {
                    sb.Append("(" + Convert.ToInt32(keyValue.Key.ToString()) + ")");
                    break;


                }
                else
                {
                    sb.Append(keyValue.Key);

                }

            }
            return sb.ToString();
        }
        StringBuilder sb = new StringBuilder();
        List<int> remiderList = new List<int>();
        int reminder_OP;
        public string FractionToDecimalCalGeek(int numerator, int denominator)
        {
            if(denominator == 1 || denominator == -1)
            {
                if(numerator >0 && denominator < 0)
                {
                    sb.Append("-" + numerator);
                }
                else
                {
                    sb.Append(numerator);
                }
             
                    return sb.ToString();
            }
            float result = (float)numerator / (float)denominator;
            string resultStr = result.ToString();
            int i = resultStr.IndexOf('.');
            int k = resultStr.Substring(i + 1).Length;
            if (i > 0 && k >1)
            {
                sb.Append(result.ToString().Substring(0, i + 1));
                // return getRecussionOfDigit(numerator, denominator);
                getRecussionOfDigit(numerator %= denominator, denominator);
                for (int j = 0; j < remiderList.Count; j++)
                {
                    if (remiderList.Last() == remiderList[j])
                    {
                        sb.Append("(" + remiderList[j] + ")");
                    }
                    else
                    {
                        sb.Append(remiderList[j]);
                    }
                }
            }
            else
            {
                 sb.Append(result).ToString();
            }

            return sb.ToString();
        }
        public void getRecussionOfDigit(int numerator, int denominator)
        {
            int denominatorLength = denominator.ToString().Length;
            string denominatorStr = "1";
            for (int l = 0; l < denominatorLength-1; l++)
            {
                denominatorStr += "0";
            }
            int j = 6;
            int multiplier = Convert.ToInt32(denominatorStr);
            while (j > 0)
            {
                Math.DivRem(numerator * multiplier, denominator, out reminder_OP);
                if (!remiderList.Contains(numerator * multiplier / denominator) && reminder_OP >= 0)
                {
                    remiderList.Add(numerator * multiplier / denominator);
                    numerator = reminder_OP;
                    j--;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
