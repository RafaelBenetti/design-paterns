using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises.MarioKart.Equipments
{
    public class PistonRocket : IEquip
    {
        public PistonRocket()
        {
            Level = 2;
        }

        public PistonRocket(int level)
        {
            if (level < 1 || level > 5)
                this.Level = 2;
            else
                this.Level = level;
        }

        public int Level { get; set; }

        public int GetBonusValue()
        {
            return this.Level;
        }
    }
}
