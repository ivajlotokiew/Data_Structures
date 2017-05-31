using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03.LongestSubsequence.Tests
{
    using System.Collections.Generic;

    [TestClass]
    public class LongestSubsequenceTests
    {
        [TestMethod]
        public void FindLongestSubsequence_SequenceInTheMIddle_ShouldFindCorrectly()
        {
            var list = new List<int>() { 1, 1, 1, 5, 5, 69, 69, 2, 504, 504, 2, 2, 3, 3, 3, 3, 78, 78, 78, 78, 78, 78, 78, 104, 1004 }; // Should return 7 x 78

            var expected = new List<int>() { 78, 78, 78, 78, 78, 78, 78 };
            var result = LongestSubsequence.FindLongestSubsequence(list);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindLongestSubsequence_SequenceAtTheBegining_ShouldFindCorrectly()
        {
            var list = new List<int>() { 2, 2, 2, 2, 2, 2, 2, 2, 504, 504, 2, 2, 3, 3, 3, 3, 78, 78, 78, 78, 78, 78, 78, 104, 1004 }; // Should return 8 x 2

            var expected = new List<int>() { 2, 2, 2, 2, 2, 2, 2, 2 };
            var result = LongestSubsequence.FindLongestSubsequence(list);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindLongestSubsequence_SequenceAtTheEnd_ShouldFindCorrectly()
        {
            var list = new List<int>() { 504, 504, 2, 2, 3, 3, 3, 3, 78, 78, 78, 78, 78, 78, 78, 104, 1004, 2, 2, 2, 2, 2, 2, 2, 2 }; // Should return 8 x 2

            var expected = new List<int>() { 2, 2, 2, 2, 2, 2, 2, 2 };
            var result = LongestSubsequence.FindLongestSubsequence(list);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindLongestSubsequence_MoreThanOneLongest_ShouldFindLeftmost()
        {
            var list = new List<int>() { 69, 69, 1, 1, 2, 2, 3, 3 }; // Should return 2 x 69

            var expected = new List<int>() { 69, 69 };
            var result = LongestSubsequence.FindLongestSubsequence(list);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindLongestSubsequence_1Element_ShouldReturnCorrectly()
        {
            var list = new List<int>() { 1 }; // Should return 1

            var expected = new List<int>() { 1 };
            var result = LongestSubsequence.FindLongestSubsequence(list);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindLongestSubsequence_EmptyList_ShouldReturnEmptyList()
        {
            var list = new List<int>(); // Should return empty list

            var expected = new List<int>();
            var result = LongestSubsequence.FindLongestSubsequence(list);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
