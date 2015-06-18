using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Bridge.Colors
{
    public class RedColor : IPainter
    {
        private const string COLOR = "red";

        public void Paint()
        {
            Console.WriteLine(string.Format("Painting {0}...", COLOR));
        }

        public string GetColor()
        {
            return COLOR;
        }
    }
}
