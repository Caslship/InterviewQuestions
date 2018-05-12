using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.DataStructures
{
    public class MaxHeap<T> : Heap<T> where T : IComparable<T>
    {
        public static IComparer<T> MaxHeapComparer { get; } = Comparer<T>.Create((x, y) =>
        {
            return -1 * x.CompareTo(y);
        });

        public MaxHeap(T value) : base(value, MaxHeapComparer) { }

        public static Heap<T> Heapify(List<T> values)
        {
            return Heap<T>.Heapify(values, MaxHeapComparer);
        }
    }
}
