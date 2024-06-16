using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Strings
{
    internal class Graph
    {
        private LinkedList<Graph_Node> nodes = new LinkedList<Graph_Node>();
        private int edges = 0;
        public int Edges { get { return edges; } } // part 2

        public Graph() { }


        public int NodeCount() { return nodes.Count; } // part 1

        public void AddNode(string name)
        {
            Graph_Node node = new Graph_Node(name);
            nodes.AddLast(node);

        }


        public Graph_Node findNode(string name)
        {

            foreach (Graph_Node n in nodes)
            {
                if (n.Name == name) return n;

            }
            return null;

        }

        public void AddEdge(string from, string to)
        {

            Graph_Node fromNode = findNode(from);
            Graph_Node toNode = findNode(to);

            fromNode.AddEdge(toNode);
            edges++;
        }

        public LinkedList<Graph_Node> BreadthFirstSearch(string start)
        {
            LinkedList<Graph_Node> visited = new LinkedList<Graph_Node>();
            Queue<Graph_Node> toVisit = new Queue<Graph_Node>();

            Graph_Node startNode = findNode(start);

            toVisit.Enqueue(startNode);

            while (toVisit.Count > 0)
            {
                Graph_Node current = toVisit.Peek();
                toVisit.Dequeue();
                visited.AddLast(current);

                foreach (Graph_Node node in current.AdjList)
                {
                    if (!toVisit.Contains(node) && !visited.Contains(node))
                    {
                        toVisit.Enqueue(node);
                    }
                }
            }

            return visited;
        }

        public bool isTraversalPossible(string from, string to)
        {
            LinkedList<Graph_Node> result = BreadthFirstSearch(from);

            foreach (Graph_Node node in result)
            {
                if (node.Name == to) return true;
            }
            return false;
        }
    }
}
