using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class SumService
    {
        public int[] TwoSum(int[] inputArray, int target)
        {
            for (var i = 0; i < inputArray.Length - 1; i++)
            {
                for (var j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] + inputArray[j] != target) continue;
                    return new[] { i, j };
                }
            }
            return null;
        }
    }
}
