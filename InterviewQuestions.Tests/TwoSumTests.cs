using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewQuestions.Tests
{
    [TestClass]
    public class TwoSumTests
    {
        private TwoSum Finder { get; } = new TwoSum();

        [TestMethod]
        public void ShouldExistPairWithSumEqualTo7()
        {
            var values = new List<int>
            {
                5,
                3,
                5,
                4,
                8,
                9
            };

            Assert.IsTrue(Finder.ExistsPairEqualToSum(7, values));
        }

        [TestMethod]
        public void ShouldNotExistPairWithSumEqualTo8()
        {
            var values = new List<int>
            {
                5,
                4,
                6,
                7,
                9
            };

            Assert.IsFalse(Finder.ExistsPairEqualToSum(8, values));
        }
    }
}
