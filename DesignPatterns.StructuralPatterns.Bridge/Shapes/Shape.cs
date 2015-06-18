using DesignPatterns.StructuralPatterns.Bridge.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Bridge.Shapes
{
    public abstract class Shape
    {
        protected IPainter _painter;
        public string Color;

        protected Shape(IPainter painter)
        {
            this._painter = painter;
            this.Color = painter.GetColor();
        }

        public abstract void Paint();
    }
}
