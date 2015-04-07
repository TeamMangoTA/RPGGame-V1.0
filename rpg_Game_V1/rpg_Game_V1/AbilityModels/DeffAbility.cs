using rpg_Game_V1.AbilityModels.Interface;
using rpg_Game_V1.ActionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.AbilityModels
{
    public class DeffAbility:Ability,IAbility
    {
        public int HealtDmg { get; set; }
    
        public int HitModf { get; set; }

        public override string AbilityType
        {
            get
            {
                return "Def";
            }
        }
        public DeffAbility(int healthDamage,int staminaCost,int manaCost, int hitPercent, string name)
        {
            this.HealtDmg = healthDamage;
            this.StaminaEffect = staminaCost;
            this.ManaEffect = manaCost;
            this.HitModf = hitPercent;
            this.Name = name;
        }


        public GameAction CreatAction()
        {
            throw new NotImplementedException();
        }
    }
}
