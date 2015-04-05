using rpg_Game_V1.AbilityModels.Interface;
using rpg_Game_V1.ActionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.AbilityModels
{
    public abstract class AttackAbility:Ability
    {
        
        public override string AbilityType
        {
            get
            {
                return "Attack";
            }
        }

        
    }
}
