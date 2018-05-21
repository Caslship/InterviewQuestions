using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.DataStructures
{
    public class GraphEdge
    {
        public int Cost { get; }
        public GraphNode A { get; }
        public GraphNode B { get; }

        public GraphEdge(GraphNode a, GraphNode b) : this(a, b, 0) { }

        public GraphEdge(GraphNode a, GraphNode b, int cost)
        {
            A = a;
            B = b;
            Cost = cost;
        }
    }
}
