using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class StockQuestion
    {
        //Input: [7,1,5,3,6,4]
        //Output: 5
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length <= 0) return 0;
            int max = 0;
            int min = prices[0];
            for(int i = 1;  i <= prices.Length; i++)
            {
                max = Math.Max(max, prices[i] - min);
                min = Math.Min(min, prices[i]);
            }
            return max;
        }
    }
}
