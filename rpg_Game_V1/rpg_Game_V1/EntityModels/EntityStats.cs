﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.EntityModels
{
    public struct EntityStats
    {
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Stamina { get; set; }

        public int Dex { get; set; }
        public int Int { get; set; }
        public int Str { get; set; }

        public EntityStats(int health, int mana, int stamina, int dex, int intelligence, int strenght):this()
        {
            this.Health = health;
            this.Mana = mana;
            this.Stamina = stamina;
            this.Dex = dex;
            this.Int = intelligence;
            this.Str = strenght;
        }
    }
}
