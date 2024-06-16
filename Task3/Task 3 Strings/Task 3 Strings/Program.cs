using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            graph.AddNode("Dave");
            graph.AddNode("Peggy");
            graph.AddNode("Rabia");
            graph.AddNode("Anwar");
            graph.AddNode("Rob");
            graph.AddNode("Haniy");

            graph.AddEdge("Dave", "Peggy");
            graph.AddEdge("Peggy", "Rabia");
            graph.AddEdge("Peggy", "Rob");
            graph.AddEdge("Rabia", "Anwar");
            graph.AddEdge("Anwar", "Rob");
            graph.AddEdge("Anwar", "Dave");
            graph.AddEdge("Rob", "Haniy");

            Console.WriteLine("The number of nodes in the graph is: " + graph.NodeCount());
            Console.WriteLine();

            Console.WriteLine("The number of edges in the graph is " + graph.Edges);
            Console.WriteLine();

            LinkedList<Graph_Node> result = graph.BreadthFirstSearch("Dave");

            Console.WriteLine("The names visited are:");
            foreach (Graph_Node node in result)
            {
                Console.WriteLine(node.Name.ToString());
            }
            Console.WriteLine();

            bool traversalResult = graph.isTraversalPossible("Dave", "Rob");
            Console.WriteLine("Is traversal from Dave to Rob possible?");
            if (traversalResult) Console.WriteLine("Yes");
            else Console.WriteLine("No");

            Console.ReadKey();
        }
    }
}
