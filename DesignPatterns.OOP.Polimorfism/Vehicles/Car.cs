﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OOP.Polimorfism.Vehicles
{
    public class Car : Vehicle
    {
        public override string Move()
        {
            return "I move like a car...";
        }
    }
}
