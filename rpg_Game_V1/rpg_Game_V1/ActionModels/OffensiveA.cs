using rpg_Game_V1.AbilityModels;
using rpg_Game_V1.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.ActionModels
{
    public abstract class OffensiveA : GameAction
    {
        public bool IsValid { get; set; }

        public OffensiveA(Entity p1, Entity p2, Ability a1)
            : base(p1, p2, a1)
        {
          
        }


    }
}
