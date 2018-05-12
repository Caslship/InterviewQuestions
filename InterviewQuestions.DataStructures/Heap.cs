using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.DataStructures
{
    public class Heap<T>
    {
        public T Value { get; private set; }
        private Heap<T> LeftChild { get; set; }
        private Heap<T> RightChild { get; set; }
        private IComparer<T> Comparer { get; }

        public Heap(T value, IComparer<T> comparer)
        {
            Value = value;
            Comparer = comparer;
        }

        public static Heap<T> Heapify(List<T> values, IComparer<T> comparer)
        {
            if (values == null || values.Count == 0)
            {
                throw new ArgumentException();
            }

            var root = new Heap<T>(values[0], comparer);

            for (var i = 1; i < values.Count; ++i)
            {
                root.Insert(values[i]);
            }

            return root;
        }

        public void Insert(T value)
        {
            if (ShouldComeAfter(value))
            {
                var oldValue = Value;
                Value = value;
                Insert(oldValue);
            }
            else
            {
                if (LeftChild == null)
                {
                    LeftChild = new Heap<T>(value, Comparer);
                }
                else if (RightChild == null)
                {
                    RightChild = new Heap<T>(value, Comparer);
                }
                else
                {
                    if (LeftChild.ShouldComeAfter(value))
                    {
                        LeftChild.Insert(value);
                    }
                    else
                    {
                        RightChild.Insert(value);
                    }
                }
            }
        }

        public T GetRoot()
        {
            return Value;
        }

        public T PopRoot()
        {
            var rootValue = Value;

            if (LeftChild == null && RightChild == null)
            {
                Value = default(T);
            }

            // TODO: Finish this

            return rootValue;
        }

        public bool ShouldComeBefore(T value)
        {
            return Comparer.Compare(Value, value) < 0;
        }

        public bool ShouldComeAfter(T value)
        {
            return !ShouldComeBefore(value);
        }

        public List<T> ToList()
        {
            var list = new List<T>();
            var nodeQueue = new Queue<Heap<T>>();

            nodeQueue.Enqueue(this);
            while (nodeQueue.Count > 0)
            {
                var node = nodeQueue.Dequeue();
                nodeQueue.Enqueue(node.LeftChild);
                nodeQueue.Enqueue(node.RightChild);

                list.Add(node.Value);
            }

            return list;
        }
    }
}
