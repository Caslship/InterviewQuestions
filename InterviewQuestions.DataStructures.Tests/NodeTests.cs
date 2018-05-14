using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewQuestions.DataStructures.Tests
{
    [TestClass]
    public class NodeTests
    {
        [TestMethod]
        public void ShouldReturnCount5()
        {
            var head = Node<int>.CreateLinkedList(
                new List<int>
                {
                    1,
                    2,
                    3,
                    4,
                    5
                }
            );

            var count = head.Count();

            Assert.AreEqual(5, count);
        }

        [TestMethod]
        public void ShouldReturn5thElement7()
        {
            var head = Node<int>.CreateLinkedList(
                new List<int>
                {
                    1,
                    2,
                    3,
                    4,
                    7
                }
            );

            var value = head.ElementAt(4);

            Assert.AreEqual(7, value);
        }
    }
}
