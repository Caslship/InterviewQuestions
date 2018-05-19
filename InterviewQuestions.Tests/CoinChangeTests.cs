using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewQuestions.Tests
{
    [TestClass]
    public class CoinChangeTests
    {
        private CoinChange Calculator { get; } = new CoinChange();

        [TestMethod]
        public void ShouldReturnMinChangeCount2()
        {
            var minChange = Calculator.ComputeMinChangeCount(30);

            Assert.AreEqual(2, minChange);
        }

        [TestMethod]
        public void ShouldReturnMinChangeCount3()
        {
            var minChange = Calculator.ComputeMinChangeCount(40);

            Assert.AreEqual(3, minChange);
        }

        [TestMethod]
        public void ShouldReturnMinChangeCount6()
        {
            var minChange = Calculator.ComputeMinChangeCount(19);

            Assert.AreEqual(6, minChange);
        }

        [TestMethod]
        public void ShouldReturnChangePermutationsCount4()
        {
            var changePermutations = Calculator.ComputeChangePermutationsCount(10);

            Assert.AreEqual(4, changePermutations);
        }

        [TestMethod]
        public void ShouldReturnChangePermutationsCount2()
        {
            var changePermutations = Calculator.ComputeChangePermutationsCount(7);

            Assert.AreEqual(2, changePermutations);
        }
    }
}
