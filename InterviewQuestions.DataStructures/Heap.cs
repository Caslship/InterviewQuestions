using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.DataStructures
{
    public class Heap<T>
    {
        private List<T> Values { get; }
        private IComparer<T> Comparer { get; }
        public int Count => Values.Count;

        public Heap(IComparer<T> comparer) : this(comparer, new List<T>()) { }

        public Heap(IComparer<T> comparer, List<T> values)
        {
            Comparer = comparer;
            Values = new List<T>();

            if (values != null)
            {
                foreach (var value in values)
                {
                    Add(value);
                }
            }
        }

        private int ParentIndex(int index) => (index - 1) / 2;
        private int RightChildIndex(int index) => (index * 2) + 1;
        private int LeftChildIndex(int index) => (index * 2) + 2;

        private void HeapifyUp()
        {
            var childIndex = Values.Count - 1;

            while (childIndex > 0)
            {
                var child = Values[childIndex];
                var parentIndex = ParentIndex(childIndex);
                var parent = Values[parentIndex];

                if (Comparer.Compare(parent, child) <= 0)
                {
                    break;
                }

                Values[parentIndex] = child;
                Values[childIndex] = parent;

                childIndex = parentIndex;
            }
        }

        private void HeapifyDown()
        {
            var parentIndex = 0;

            while (parentIndex < Values.Count)
            {
                var parent = Values[parentIndex];
                var leftChildIndex = LeftChildIndex(parentIndex);
                var rightChildIndex = RightChildIndex(parentIndex);              

                if (leftChildIndex >= Values.Count)
                {
                    break;
                }

                var childIndex = leftChildIndex;
                var child = Values[childIndex];

                if (rightChildIndex < Values.Count && Comparer.Compare(Values[rightChildIndex], child) < 0)
                {
                    childIndex = rightChildIndex;
                    child = Values[childIndex];                  
                }

                if (Comparer.Compare(parent, child) <= 0)
                {
                    break;
                }

                Values[parentIndex] = child;
                Values[childIndex] = parent;

                parentIndex = childIndex;
            }
        }

        public void Add(T value)
        {
            Values.Add(value);
            HeapifyUp();
        }

        public T PeekRoot()
        {
            if (Values.Count == 0)
            {
                throw new InvalidOperationException();
            }

            return Values[0];
        }

        public T PopRoot()
        {
            var root = PeekRoot();
            var childIndex = Values.Count - 1;
            var child = Values[childIndex];

            Values.RemoveAt(childIndex);

            if (Values.Count > 0)
            {
                Values[0] = child;
                HeapifyDown();
            }

            return root;
        }
    }
}
