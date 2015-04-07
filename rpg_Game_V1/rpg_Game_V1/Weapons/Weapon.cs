﻿using rpg_Game_V1.AbilityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.Weapons
{
    public abstract class Weapon:Items
    {
        public Weapon(string imageLocation)
            : base(imageLocation)
        { 
        }

        public int DmgValue { get; set; }
        public int AccuracyRating { get; set; }
    }
}
