﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.EntityModels
{
    class Player:GoodEntity
    {
        
        public Player(string name,int health,int mana, int stamina,
            int dexterity, int intelligence, int strenght)
            :base(name,health,mana,stamina,dexterity,intelligence,strenght)
        {
            
        }
    }
}
