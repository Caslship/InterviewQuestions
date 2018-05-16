using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewQuestions.DataStructures.Tests
{
    [TestClass]
    public class MinHeapTests
    {
        [TestMethod]
        public void ShouldReturnSmallestNumber2()
        {
            var heap = new MinHeap<int>(
                new List<int>
                {
                    6,
                    4,
                    5,
                    7,
                    3,
                    2,
                    8
                }
            );

            var min = heap.PeekRoot();

            Assert.AreEqual(2, min);
        }
    }
}
