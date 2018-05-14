using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class MergeSort
    {
        private IComparer<T> GetDefaultComparer<T>() where T : IComparable<T>
        {
            return Comparer<T>.Default;
        }

        public List<T> Sort<T>(List<T> values) where T : IComparable<T>
        {
            return Sort(values, GetDefaultComparer<T>());
        }

        public List<T> Sort<T>(List<T> values, IComparer<T> comparer)
        {
            var count = values.Count;
            if (values.Count <= 1)
            {
                return values;
            }

            var firstHalf = new List<T>();
            var secondHalf = new List<T>();
            var countHalf = count / 2;

            for (var i = 0; i < count; ++i)
            {
                if (i < countHalf)
                {
                    firstHalf.Add(values[i]);
                }
                else
                {
                    secondHalf.Add(values[i]);
                }
            }
            var sortedFirstHalf = Sort(firstHalf, comparer);
            var sortedSecondHalf = Sort(secondHalf, comparer);

            return Merge(sortedFirstHalf, sortedSecondHalf, comparer);
        }

        private List<T> Merge<T>(List<T> first, List<T> second, IComparer<T> comparer)
        {
            var merged = new List<T>();
            var i = 0;
            var j = 0;

            while (i < first.Count || j < second.Count)
            {
                var exhaustedFirst = i >= first.Count;
                var exhaustedSecond = j >= second.Count;

                if (!exhaustedFirst && !exhaustedSecond)
                {
                    if (comparer.Compare(first[i], second[j]) <= 0)
                    {
                        merged.Add(first[i++]);
                    }
                    else
                    {
                        merged.Add(second[j++]);
                    }
                }
                else if (!exhaustedFirst)
                {
                    merged.Add(first[i++]);
                }
                else
                {
                    merged.Add(second[j++]);
                }
            }

            return merged;
        }
    }
}
