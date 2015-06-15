﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Players
{
    public class ManagementBasketballPlayer : ManagementPlayer
    {
        public override Player CreatePlayer()
        {
            return new BasketballPlayer();
        }
    }
}