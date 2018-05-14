using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions.DataStructures;

namespace InterviewQuestions
{
    public class ReverseLinkedList
    {
        public Node<T> Reverse<T>(Node<T> head)
        {        
            if (head == null || head.Next == null)
            {
                return head;
            }

            var newHead = Reverse(head.Next);
            head.Next.Next = head;
            head.Next = null;

            return newHead;
        }
    }
}
