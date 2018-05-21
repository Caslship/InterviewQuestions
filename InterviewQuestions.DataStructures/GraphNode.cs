using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.DataStructures
{
    public class GraphNode
    {
        public List<GraphEdge> Connections { get; }

        public GraphNode() : this(new List<GraphNode>()) { }

        public GraphNode(List<GraphNode> connectedNodes)
        {
            Connections = new List<GraphEdge>();

            foreach (var node in connectedNodes)
            {
                Connections.Add(
                    new GraphEdge(this, node)
                );
            }
        }
    }
}
