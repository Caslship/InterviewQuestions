using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.DataStructures
{
    public class GraphNode<T>
    {
        public T Value { get; }
        public List<GraphEdge<T>> Connections { get; }
    }
}
