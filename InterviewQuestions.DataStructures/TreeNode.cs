using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.DataStructures
{
    public class TreeNode<T>
    {
        public T Value { get; }
        //public TreeNode<T> Parent { get; }
        public TreeNode<T> Right { get; set; }
        public TreeNode<T> Left { get; set; }

        //public TreeNode(T value) : this(value, null) { }

        public TreeNode(T value/*, TreeNode<T> parent*/)
        {
            Value = value;
            //Parent = parent;
            Right = null;
            Left = null;
        }
    }
}
