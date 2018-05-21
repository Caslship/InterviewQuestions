using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions.DataStructures;

namespace InterviewQuestions
{
    public class DijkstrasAlgorithm
    {
        public List<GraphNode> FindShortestPath(List<GraphNode> graph, GraphNode source, GraphNode destination)
        {
            var distance = new Dictionary<GraphNode, int>();
            var previous = new Dictionary<GraphNode, GraphNode>();
            var unvisited = new List<GraphNode>(graph.Count);

            foreach (var node in graph)
            {
                distance[node] = int.MaxValue;
                previous[node] = null;

                unvisited.Add(node);
            }

            distance[source] = 0;

            while (unvisited.Count != 0)
            {
                var current = unvisited[0];

                foreach (var node in unvisited.Skip(1))
                {
                    if (distance[node] < distance[current])
                    {
                        current = node;
                    }
                }

                if (current == destination)
                {
                    var path = new Stack<GraphNode>();
                    path.Push(current);

                    while (previous[current] != null)
                    {
                        current = previous[current];
                        path.Push(current);
                    }

                    path.ToList();
                }

                foreach (var connection in current.Connections)
                {
                    var neighbor = connection.B;
                    var neighborDistance = distance[current] + connection.Cost;

                    if (neighborDistance < distance[neighbor])
                    {
                        distance[neighbor] = neighborDistance;
                        previous[neighbor] = current;
                    }
                }

                unvisited.Remove(current);
            }

            return null;
        }
    }
}
