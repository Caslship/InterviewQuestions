using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewQuestions.Tests
{
    [TestClass]
    public class KthSmallestElementTests
    {
        private KthSmallestElement<int> Finder { get; } = new KthSmallestElement<int>();

        [TestMethod]
        public void ShouldReturn3rdSmallestElement5()
        {
            var values = new List<int>
            {
                1,
                9,
                7,
                2,
                8,
                5,
                6
            };

            var element = Finder.FindKthSmallestElement(3, values);

            Assert.AreEqual(5, element);
        }
    }
}
