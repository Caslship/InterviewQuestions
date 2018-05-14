using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class QuickSort
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
            return Sort(values, comparer, 0, values.Count - 1);
        }

        public List<T> Sort<T>(List<T> values, IComparer<T> comparer, int lo, int hi)
        {
            if (lo < hi)
            {
                var pivotIndex = Partition(values, comparer, lo, hi);
                Sort(values, comparer, lo, pivotIndex - 1);
                Sort(values, comparer, pivotIndex + 1, hi);
            }

            return values;
        }

        private int Partition<T>(List<T> values, IComparer<T> comparer, int lo, int hi)
        {
            var pivot = values[hi];
            var pivotIndex = lo - 1;

            for (var i = lo; i <= hi - 1; ++i)
            {
                if (comparer.Compare(values[i], pivot) < 0)
                {
                    Swap(values, i, ++pivotIndex);
                }
            }

            Swap(values, hi, ++pivotIndex);

            return pivotIndex;
        }

        private void Swap<T>(List<T> values, int i, int j)
        {
            var x = values[i];
            var y = values[j];

            values[i] = y;
            values[j] = x;
        }
    }
}
