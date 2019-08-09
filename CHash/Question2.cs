using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopcsharp
{
    class Question2
    {
        public IList<IList<int>> Generate(int numRows)
        {
            if (numRows == 0) return new List<IList<int>>();

            var pascalTriangle = new List<IList<int>>();
            int[] previousRow = new int[1] { 1 };
            pascalTriangle.Add(previousRow);

            for (int i = 2; i <= numRows; i++)
            {
                int[] currentRow = new int[i];
                currentRow[0] = 1;

                // calculating first half
                int midPoint = (int)Math.Ceiling(i / 2.0) - 1;
                for (int j = 1; j <= midPoint; j++)
                {
                    currentRow[j] = previousRow[j] + previousRow[j - 1];
                }

                // copying second half across
                int destIndex = midPoint + 1;
                int length = i - midPoint - 1;
                Array.Copy(currentRow, 0, currentRow, destIndex, length);
                Array.Reverse(currentRow, destIndex, length);

                pascalTriangle.Add(currentRow);
                previousRow = currentRow;
            }

            return pascalTriangle;
        }

    }
}
