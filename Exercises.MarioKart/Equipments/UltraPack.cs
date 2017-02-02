using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises.MarioKart.Equipments
{
    public class UltraPack : IEquip
    {
        public UltraPack(IEquip equip)
        {
            this.Equip = equip;
        }

        public IEquip Equip { get; set; }

        public int GetBonusValue()
        {
            int innerBonus = Equip.GetBonusValue();
            return innerBonus + (int)Math.Round((double)innerBonus / 100 * 20);
        }
    }
}
