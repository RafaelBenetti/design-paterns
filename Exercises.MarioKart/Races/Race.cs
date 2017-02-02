using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises.MarioKart.Races
{
    abstract class Race
    {
        public WeatherEnum Weather { get; set; }
        public Route Route { get; set; }
    }
}
