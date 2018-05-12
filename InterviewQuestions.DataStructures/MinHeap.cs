using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.DataStructures
{
    public class MinHeap<T> : Heap<T> where T : IComparable<T>
    {
        public static IComparer<T> MinHeapComparer { get; } = Comparer<T>.Create((x, y) =>
        {
            return x.CompareTo(y);
        });

        public MinHeap(T value) : base(value, MinHeapComparer) { }

        public static Heap<T> Heapify(List<T> values)
        {
            return Heap<T>.Heapify(values, MinHeapComparer);
        }
    }
}
