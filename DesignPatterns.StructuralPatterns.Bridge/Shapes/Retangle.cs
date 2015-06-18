using DesignPatterns.StructuralPatterns.Bridge.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Bridge.Shapes
{
    public class Retangle : Shape
    {
        public Retangle(IPainter painter) 
            : base(painter)
        {
        }
        
        public override void Paint()
        {
            _painter.Paint();
            Color = _painter.GetColor();
        }
    }
}
