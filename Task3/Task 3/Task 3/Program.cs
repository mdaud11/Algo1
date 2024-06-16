using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            graph.AddNode(1);
            graph.AddNode(2);
            graph.AddNode(3);
            graph.AddNode(4);
            graph.AddNode(5);
            graph.AddNode(6);

            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 1);
            graph.AddEdge(4, 5);
            graph.AddEdge(5, 6);

            Console.WriteLine("The number of nodes in the graph is: " + graph.NodeCount());
            Console.WriteLine();

            Console.WriteLine("The number of edges in the graph is " + graph.Edges);
            Console.WriteLine();

            LinkedList<Graph_Node> result = graph.BreadthFirstSearch(1);

            Console.WriteLine("The IDs visited are:");
            foreach (Graph_Node node in result) 
            {
                Console.WriteLine(node.Id.ToString());
            }
            Console.ReadKey();
        }
    }
}
