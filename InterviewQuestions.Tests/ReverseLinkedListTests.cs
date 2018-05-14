using System;
using System.Collections.Generic;
using InterviewQuestions.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewQuestions.Tests
{
    [TestClass]
    public class ReverseLinkedListTests
    {
        private ReverseLinkedList Reverser { get; } = new ReverseLinkedList();

        [TestMethod]
        public void ShouldReverseLinkedList()
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

            var expected = Node<int>.CreateLinkedList(
                new List<int>
                {
                    7,
                    4,
                    3,
                    2,
                    1
                }
            );

            var reversed = Reverser.Reverse(head);       

            Assert.IsTrue(AreLinkedListsEqual(expected, reversed));
        }

        [TestMethod]
        public void ShouldHandleNullLinkedList()
        {
            Node<int> head = null;

            var reversed = Reverser.Reverse(head);

            Assert.AreEqual(null, reversed);
        }

        private bool AreLinkedListsEqual<T>(Node<T> expected, Node<T> actual) where T : IComparable<T>
        {
            while (expected != null && actual != null)
            {
                if (expected.Value.CompareTo(actual.Value) != 0)
                {
                    return false;
                }

                expected = expected.Next;
                actual = actual.Next;
            }

            if (actual != null || expected != null)
            {
                return false;
            }

            return true;
        }
    }
}
