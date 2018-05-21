using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions.DataStructures;

namespace InterviewQuestions
{
    public class ValidateBinarySearchTree
    {
        public bool IsValid(TreeNode<int> root)
        {
            return IsValid(root, int.MinValue, int.MaxValue);
        }

        public bool IsValid(TreeNode<int> current, int minValue, int maxValue)
        {
            if (current.Left != null)
            {
                if (current.Left.Value < minValue || !IsValid(current.Left, minValue, current.Value))
                {
                    return false;
                }
            }

            if (current.Right != null)
            {
                if (current.Right.Value > maxValue || !IsValid(current.Right, current.Value, maxValue))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
