using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseWords
{
    /// <summary>
    /// Summary description for ReverseWordsTest
    /// </summary>
    [TestClass]
    public class ReverseWordsTest
    {
        private ReverseWords reverseWords = new ReverseWords();

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void InputIsAStringWithOneUnitSpace_ReverseWordsTest()
        {
            var input = "This is a test!";
            var actual = reverseWords.GetReverseWords(input);
            var expected = "sihT si a !tset";

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void InputIsNull_ShouldReturnNull_ReverseWordsTest()
        {
            string input = null;
            var actual = reverseWords.GetReverseWords(input);
            string expected = null;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InputIsEmptyString_ReverseWordsTest()
        {
            string input = String.Empty;
            var actual = reverseWords.GetReverseWords(input);
            string expected = "String is empty";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InputIsOneWord_ShouldReturnThatWord_ReverseWordsTest()
        {
            string input = "H";
            var actual = reverseWords.GetReverseWords(input);
            string expected = "H";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InputIsAStringHasSomeTwoSpaces_ShouldReturnReverseWordsButSpacesRetain_ReverseWordsTest()
        {
            string input = "double  spaces";
            var actual = reverseWords.GetReverseWords(input);
            string expected = "elbuod  secaps";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InputIsAStringHasSomeMoreSpaces_ShouldReturnReverseWordsButSpacesRetain_ReverseWordsTest()
        {
            string input = "more        spaces";
            var actual = reverseWords.GetReverseWords(input);
            string expected = "erom        secaps";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InputIsAStringStartWithSpaces_ShouldReturnReverseWordsButSpacesRetain_ReverseWordsTest()
        {
            string input = "  more        spaces";
            var actual = reverseWords.GetReverseWords(input);
            string expected = "  erom        secaps";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InputIsAStringEndWithSpaces_ShouldReturnReverseWordsButSpacesRetain_ReverseWordsTest()
        {
            string input = "  more        spaces     ";
            var actual = reverseWords.GetReverseWords(input);
            string expected = "  erom        secaps     ";

            Assert.AreEqual(expected, actual);
        }
    }
}
