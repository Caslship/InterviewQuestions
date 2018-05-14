using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.Tests
{
    public static class TestUtilities
    {
        private static IComparer<T> GetDefaultComparer<T>() where T : IComparable<T>
        {
            return Comparer<T>.Default;
        }

        public static bool AreListsEqual<T>(List<T> expected, List<T> actual) where T : IComparable<T>
        {
            return AreListsEqual(expected, actual, GetDefaultComparer<T>());
        }

        public static bool AreListsEqual<T>(List<T> expected, List<T> actual, IComparer<T> comparer)
        {
            if (expected.Count != actual.Count)
            {
                return false;
            }

            for (var i = 0; i < expected.Count; ++i)
            {
                if (comparer.Compare(expected[i], actual[i]) != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
