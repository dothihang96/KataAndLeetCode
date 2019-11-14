using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum.Tests
{
    [TestClass()]
    public class TwoSumTests
    {
        private SumService _sumService = new SumService();
        [TestMethod()]
        public void SortedList_twoSumTest()
        {
            int[] nums = new int[] { 2, 3, 7, 8 };
            int target = 9;
            int[] expected = new int[] { 0, 2 };
            var actual = _sumService.TwoSum(nums, target);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NoResult_twoSumTest()
        {
            int[] nums = new int[] { 2, 3, 6, 8 };
            int target = 100;
            int[] expected = null;
            var actual = _sumService.TwoSum(nums, target);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SameMemberInArray_twoSumTest()
        {
            int[] nums = new int[] { 3, 3 };
            int target = 6;
            int[] expected = { 0, 1 };
            var actual = _sumService.TwoSum(nums, target);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}