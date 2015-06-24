using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.State.DephtFirstSearch
{
    public class Node
    {
        private List<Node> _adjacents = new List<Node>();
        private Color _color { get; set; }
        private string _name { get; set; }

        public Node(string name)
        {
            this._name = name;
            this._color = new White();
        }

        public void SearchDepht(List<Node> nodes)
        {
            _color.Search(this, nodes);
        }

        public List<Node> GetAdjacents()
        {
            return _adjacents;
        }

        public void AddAdjacent(Node adjacent)
        {
            _adjacents.Add(adjacent);
        }

        public void SetColor(Color color, List<Node> nodes)
        {
            _color = color;
            _color.TookOver(this, nodes);
        }

        public string ToString()
        {
            return _name;
        }
    }
}
