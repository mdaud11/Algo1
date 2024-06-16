using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Graph_Node
    {

        private int id;

        public int Id { get { return id; } }

        private LinkedList<Graph_Node> adjList = new LinkedList<Graph_Node>();

        public LinkedList<Graph_Node> AdjList {  get { return adjList; } }
     
        public Graph_Node(int id) 
        {
            this.id = id;
        }

        public void AddEdge(Graph_Node node)
        {
            adjList.AddLast(node);
        }
    }
}
