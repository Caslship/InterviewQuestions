using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewQuestions.Tests
{
    [TestClass]
    public class EditStepLadderTests
    {
        private EditStepLadder Ladder { get; } = new EditStepLadder();

        [TestMethod]
        public void ShouldReturnMaxEditSteps5()
        { 
            var words = new List<string>()
            {
                "cat",
                "dig",
                "dog",
                "fig",
                "fin",
                "fine",
                "fog",
                "log",
                "wine"
            };

            var maxEditSteps = Ladder.ComputeMaxEditSteps(words);

            Assert.AreEqual(maxEditSteps, 5);
        }

        [TestMethod]
        public void ShouldHandleNoPossibleEditStepsAtLastWord()
        {
            var words = new List<string>()
            {
                "cat",
                "dig",
                "dog",
                "fig",
                "fin",
                "fine",
                "fog",
                "log",
                "wine",
                "zebra"
            };

            var maxEditSteps = Ladder.ComputeMaxEditSteps(words);

            Assert.AreEqual(maxEditSteps, 5);
        }

        [TestMethod]
        public void ShouldHandleNoPossibleEditSteps()
        {
            var words = new List<string>()
            {
                "cat",
                "dig",
                "fin",
                "fog",
                "wine",
                "zebra"
            };

            var maxEditSteps = Ladder.ComputeMaxEditSteps(words);

            Assert.AreEqual(maxEditSteps, 1);
        }
    }
}
