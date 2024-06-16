using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Strings
{
    internal class Graph_Node
    {
        private string name;

        public string Name { get { return name; } }

        private LinkedList<Graph_Node> adjList = new LinkedList<Graph_Node>();

        public LinkedList<Graph_Node> AdjList { get { return adjList; } }

        public Graph_Node(string name)
        {
            this.name = name;
        }

        public void AddEdge(Graph_Node node)
        {
            adjList.AddLast(node);

        }
    }
}
