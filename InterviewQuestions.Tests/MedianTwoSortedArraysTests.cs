using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewQuestions.Tests
{
    [TestClass]
    public class MedianTwoSortedArraysTests
    {
        private MedianTwoSortedArrays Finder { get; } = new MedianTwoSortedArrays();

        [TestMethod]
        public void ShouldReturnMedian6()
        {
            var a = new List<int>
            {
                1,
                4
            };

            var b = new List<int>
            {
                8,
                9
            };

            var median = Finder.FindMedian(a, b);

            Assert.AreEqual(6.0, median);
        }

        [TestMethod]
        public void ShouldReturnMedian2()
        {
            var a = new List<int>
            {
                1,
                4
            };

            var b = new List<int>
            {
                1,
                3
            };

            var median = Finder.FindMedian(a, b);

            Assert.AreEqual(2.0, median);
        }

        [TestMethod]
        public void ShouldReturnMedian5()
        {
            var a = new List<int>
            {
                1,
                3,
                5,
                7,
                9
            };

            var b = new List<int>
            {
                2,
                4,
                6,
                8
            };

            var median = Finder.FindMedian(a, b);

            Assert.AreEqual(5.0, median);
        }

        [TestMethod]
        public void ShouldReturnMedian7()
        {
            var a = new List<int>
            {
                1,
                2,
                3
            };

            var b = new List<int>
            {
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                12,
                13
            };

            var median = Finder.FindMedian(a, b);

            Assert.AreEqual(7.0, median);
        }

        [TestMethod]
        public void ShouldReturnMedian5_5()
        {
            var a = new List<int>
            {
                1,
                3,
                7
            };

            var b = new List<int>
            {
                3,
                4,
                7,
                9,
                10
            };

            var median = Finder.FindMedian(a, b);

            Assert.AreEqual(5.5, median);
        }
    }
}
