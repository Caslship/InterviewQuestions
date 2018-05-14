using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.DataStructures
{
    public class Node<T>
    {
        public T Value { get; }
        public Node<T> Next { get; set; }

        public Node(T value, Node<T> next)
        {
            Value = value;
            Next = next;
        }

        public int Count()
        {
            return Count(this);
        }

        public int Count(Node<T> head)
        {
            return Count(head, 0);
        }

        private int Count(Node<T> head, int count)
        {
            if (head == null)
            {
                return count;
            }

            return Count(head.Next, count + 1);
        }

        public T ElementAt(int index)
        {
            return ElementAt(this, index);
        }

        public T ElementAt(Node<T> head, int index)
        {
            if (head == null || (head.Next == null && index > 0) || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                return head.Value;
            }

            return ElementAt(head.Next, index - 1);
        }

        public static Node<T> CreateLinkedList(List<T> values)
        {
            if (values == null || values.Count == 0)
            {
                return null;
            }

            var head = new Node<T>(values[0], null);
            var current = head;

            for (var i = 1; i < values.Count; ++i)
            {
                current.Next = new Node<T>(values[i], null);
                current = current.Next;
            }

            return head;
        }
    }
}
