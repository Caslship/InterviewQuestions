using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewQuestions.Tests
{
    [TestClass]
    public class QuickSortTests
    {
        private QuickSort Sorter { get; } = new QuickSort();

        [TestMethod]
        public void ShouldQuickSortIntValuesAscending()
        {
            var values = new List<int>
            {
                3,
                6,
                2,
                1,
                5,
                4
            };

            var expected = new List<int>
            {
                1,
                2,
                3,
                4,
                5,
                6
            };

            var sorted = Sorter.Sort(values);

            Assert.IsTrue(TestUtilities.AreListsEqual(expected, sorted));
        }

        [TestMethod]
        public void ShouldQuickSortIntValuesDescending()
        {
            var values = new List<int>
            {
                3,
                6,
                2,
                1,
                5,
                4
            };

            var expected = new List<int>
            {
                6,
                5,
                4,
                3,
                2,
                1
            };

            var sorted = Sorter.Sort(
                values,
                Comparer<int>.Create((x, y) =>
                {
                    return y - x;
                })
            );

            Assert.IsTrue(TestUtilities.AreListsEqual(expected, sorted));
        }
    }
}
