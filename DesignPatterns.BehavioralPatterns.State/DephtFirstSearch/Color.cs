using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.State.DephtFirstSearch
{
    public abstract class Color
    {
        public virtual void Search(Node node, List<Node> nodes) { }
        public virtual void TookOver(Node node, List<Node> nodes) { }
    }
}
