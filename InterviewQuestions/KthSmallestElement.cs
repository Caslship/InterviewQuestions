using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions.DataStructures;

namespace InterviewQuestions
{
    public class KthSmallestElement<T> where T : IComparable<T>
    {
        public T FindKthSmallestElement(int k, List<T> elements)
        {
            if (k > elements.Count)
            {
                throw new ArgumentException();
            }

            var heap = MinHeap<T>.Heapify(elements);

            for (var i = 0; i < k - 1; ++i)
            {
                heap.PopRoot();
            }

            return heap.PopRoot();
        }
    }
}
