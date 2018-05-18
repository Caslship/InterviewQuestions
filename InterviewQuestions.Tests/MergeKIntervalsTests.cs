using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewQuestions.DataStructures;

namespace InterviewQuestions.Tests
{
    [TestClass]
    public class MergeKIntervalsTests
    {
        private MergeKIntervals Merger { get; } = new MergeKIntervals();

        [TestMethod]
        public void ShouldMerge1And3With2And6()
        {
            var intervals = new List<Interval>
            {
                new Interval { Lo = 1, Hi = 3 },
                new Interval { Lo = 2, Hi = 6 },
                new Interval { Lo = 8, Hi = 10 },
                new Interval { Lo = 15, Hi = 18 }
            };

            var expected = new List<Interval>
            {
                new Interval { Lo = 1, Hi = 6 },
                new Interval { Lo = 8, Hi = 10 },
                new Interval { Lo = 15, Hi = 18 }
            };

            var merged = Merger.Merge(intervals);

            Assert.IsTrue(AreIntervalListsEqual(expected, merged));
        }

        [TestMethod]
        public void ShouldMerge1And4With4And5()
        {
            var intervals = new List<Interval>
            {
                new Interval { Lo = 1, Hi = 4 },
                new Interval { Lo = 4, Hi = 5 }
            };

            var expected = new List<Interval>
            {
                new Interval { Lo = 1, Hi = 5 },
            };

            var merged = Merger.Merge(intervals);

            Assert.IsTrue(AreIntervalListsEqual(expected, merged));
        }

        [TestMethod]
        public void ShouldMerge1And2With0And3()
        {
            var intervals = new List<Interval>
            {
                new Interval { Lo = 1, Hi = 2 },
                new Interval { Lo = 0, Hi = 3 }
            };

            var expected = new List<Interval>
            {
                new Interval { Lo = 0, Hi = 3 },
            };

            var merged = Merger.Merge(intervals);

            Assert.IsTrue(AreIntervalListsEqual(expected, merged));
        }

        private bool AreIntervalListsEqual(List<Interval> a, List<Interval> b)
        {
            if (a.Count != b.Count)
            {
                return false;
            }

            for (var i = 0; i < a.Count; ++i)
            {

                if (a[i].Hi != b[i].Hi || a[i].Lo != b[i].Lo)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
