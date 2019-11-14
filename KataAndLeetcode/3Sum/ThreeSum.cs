using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Sum
{
    public class ThreeSum
    {
        public IList<IList<int>> SumService(int[] nums)
        {
            var arr = nums.Distinct().ToArray();
            var length = arr.Length;

            Array.Sort(arr);
            var tempArr = new int[3];
            var tempList = new List<int>();
            IList<IList<int>> resultList = new List<IList<int>>();
            for (var i = 0; i < length - 2; i++)
            {
                for (var j = i + 1; j < length - 1; j++)
                {
                    for (var k = j + 1; k < length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            tempArr[0] = arr[i];
                            tempArr[1] = arr[j];
                            tempArr[2] = arr[k];
                            tempList = tempArr.ToList<int>();
                            resultList.Add(tempList);
                        }
                    }
                }
            }
            return resultList;

        }
    }
}
