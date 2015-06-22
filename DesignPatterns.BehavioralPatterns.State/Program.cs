using DesignPatterns.BehavioralPatterns.State.DephtFirstSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.State
{
    class Program
    {
        static void Main(string[] args)
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");
            Node nodeG = new Node("G");
            Node nodeH = new Node("H");

            nodeA.AddAdjacent(nodeB);
            nodeB.AddAdjacent(nodeC);
            nodeC.AddAdjacent(nodeD);
            nodeD.AddAdjacent(nodeB);
            nodeA.AddAdjacent(nodeE);

            nodeE.AddAdjacent(nodeF);
            nodeF.AddAdjacent(nodeC);
            nodeF.AddAdjacent(nodeG);
            nodeF.AddAdjacent(nodeH);
            nodeA.AddAdjacent(nodeH);

            List<Node> nodes = new List<Node>();
            nodeA.SearchDepht(nodes);

            foreach (var node in nodes)
            {
                node.ToString();
            }

            Console.ReadKey();
        }
    }
}
