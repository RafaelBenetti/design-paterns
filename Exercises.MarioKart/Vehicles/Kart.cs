using Exercises.MarioKart.Equipments;
using Exercises.MarioKart.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises.MarioKart.Vehicles
{
    public abstract class Kart
    {
        public Kart(Player player)
        {
            this.Player = player;
            this.Equipments = new List<IEquip>();
        }

        public Kart(Player player, List<IEquip> equips)
        {
            this.Player = player;
            this.Equipments = equips;
        }
        
        public Player Player { get; set; }
        
        public List<IEquip> Equipments { get; set; }

        public int Velocity
        {
            get
            {
                return CalculateVelocity() + CalculateVelocityPerType();
            }
        }

        protected abstract int CalculateVelocityPerType();

        private int CalculateVelocity()
        {            
            return 3 + Equipments.Sum(e => (int)e.GetBonusValue()) + (int)Player.Level + Equipments.Count;
        }
    }
}
