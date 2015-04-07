﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rpg_Game_V1.ActionModels.Interface;
using rpg_Game_V1.EntityModels;
using rpg_Game_V1.AbilityModels;
namespace rpg_Game_V1.ActionModels
{
    public class HealAction : GameAction, IHealer
    {
        public int DmgValue { get; set; }
        //public string ID { get; set; }
        public int ManaEffect { get; set; }
        public int StaminaEffect { get; set; }


        public HealAction(Player p1, Player p2, HealAbility a1)
            : base(p1, p2, a1)
        {

            var temp = a1;
            this.DmgValue = temp.HealtDmg;
            this.ManaEffect = temp.ManaEffect;
            this.StaminaEffect = temp.StaminaEffect;

        }

        public int Resolve()
        {
            this.Orgin.ChangeHealth(this.DmgValue);
            this.Orgin.ChangeStamina(1);

            return 1;
        }
       
    }
}
