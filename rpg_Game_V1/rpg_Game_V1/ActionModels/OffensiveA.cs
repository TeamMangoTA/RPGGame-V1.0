using rpg_Game_V1.AbilityModels;
using rpg_Game_V1.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.ActionModels
{
    abstract class OffensiveA : GameAction
    {
        public bool IsValid { get; set; }

        public OffensiveA(Player p1, Enemy p2, Ability a1)
            : base(p1, p2, a1)
        {
            if (p1.IsGood != p2.IsGood)
            {
                this.IsValid = true;
            }

            else { this.IsValid = false; }
        }
    }
}
