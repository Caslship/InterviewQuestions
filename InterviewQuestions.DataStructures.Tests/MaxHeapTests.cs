using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewQuestions.DataStructures.Tests
{
    [TestClass]
    public class MaxHeapTests
    {
        [TestMethod]
        public void ShouldReturnBiggestNumber7()
        {
            var heap = new MaxHeap<int>(
                new List<int>
                {
                    3,
                    6,
                    4,
                    5,
                    7,
                    2,
                    1
                }
            );

            var max = heap.PeekRoot();

            Assert.AreEqual(7, max);
        }
    }
}
