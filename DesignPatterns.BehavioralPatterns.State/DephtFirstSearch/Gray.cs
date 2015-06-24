using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.State.DephtFirstSearch
{
    public class Gray : Color
    {
        public override void TookOver(Node node, List<Node> nodes)
        {
            List<Node> adjacents = node.GetAdjacents();

            foreach (var adjacent in adjacents)
            {
                adjacent.SearchDepht(nodes);
                node.SetColor(new Black(), nodes);
            }
        }
    }
}
