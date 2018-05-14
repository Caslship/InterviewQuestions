using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewQuestions.Tests
{
    [TestClass]
    public class MergeSortTests
    {
        private MergeSort Sorter { get; } = new MergeSort();

        [TestMethod]
        public void ShouldSortIntValuesAscending()
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

            Assert.IsTrue(AreListsEqual(expected, sorted));
        }

        [TestMethod]
        public void ShouldSortIntValuesDescending()
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

            Assert.IsTrue(AreListsEqual(expected, sorted));
        }

        private bool AreListsEqual<T>(List<T> expected, List<T> actual) where T : IComparable<T>
        {
            if (expected.Count != actual.Count)
            {
                return false;
            }
            
            for (var i = 0; i < expected.Count; ++i)
            {
                if (expected[i].CompareTo(actual[i]) != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
