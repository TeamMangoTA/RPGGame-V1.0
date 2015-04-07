namespace rpg_Game_V1.AbilityModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class HealAbility : Ability
    {
        public int staminaEffect { get; set; }

        public override string AbilityType
        {
            get
            {
                return "Heal";
            }
        }

       public HealAbility(int stamina)
        {
            this.staminaEffect = stamina;
        }
    }
}
