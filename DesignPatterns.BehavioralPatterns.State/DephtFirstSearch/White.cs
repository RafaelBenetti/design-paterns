using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.State.DephtFirstSearch
{
    public class White : Color
    {
        public override void Search(Node node, List<Node> nodes)
        { 
            node.SetColor(new Gray(), nodes);
        }
    }
}
