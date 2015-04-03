using rpg_Game_V1.AbilityModels.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.AbilityModels
{
    class AttackAbility:Ability,IAbility
    {
        public int HealtDmg { get; set; }
        public int StaminaEffect { get; set; }
        public int ManaEffect { get; set; }
        public string Name { get; set; }

        public AttackAbility(int healthDamage,int staminaCost,int manaCost,string name)
        {
            this.HealtDmg = healthDamage;
            this.StaminaEffect = staminaCost;
            this.ManaEffect = manaCost;
            this.Name = name;
        }

        public void CreatAction()
        {
            throw new NotImplementedException();
        }
    }
}
