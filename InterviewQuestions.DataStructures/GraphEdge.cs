using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.DataStructures
{
    public class GraphEdge<T>
    {
        public int Cost { get; }
        public GraphNode<T> A { get; }
        public GraphNode<T> B { get; }

        public GraphEdge(GraphNode<T> a, GraphNode<T> b) : this(a, b, 0) { }

        public GraphEdge(GraphNode<T> a, GraphNode<T> b, int cost)
        {
            A = a;
            B = b;
            Cost = cost;
        }
    }
}
