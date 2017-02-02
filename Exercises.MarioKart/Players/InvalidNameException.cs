using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises.MarioKart.Players
{
    public class InvalidNameException : Exception
    {
        public InvalidNameException(string message) : base(message) { }
    }
}
