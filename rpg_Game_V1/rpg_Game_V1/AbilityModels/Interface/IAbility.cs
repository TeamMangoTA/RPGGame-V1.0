using rpg_Game_V1.ActionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.AbilityModels.Interface
{
    public interface IAbility
    {
        int HealtDmg { get; set; }
        int StaminaEffect { get; set; }
        int ManaEffect { get; set; }
        string Name { get; set; }

        GameAction CreatAction();
    }
}
