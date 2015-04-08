namespace rpg_Game_V1.AbilityModels
{
    using System;

    using AbilityModels.Interface;
    using ActionModels;

    public class DeffAbility:Ability,IAbility
    {
        public DeffAbility(int healthDamage,int staminaCost,int manaCost, int hitPercent, string name)
        {
            this.HealtDmg = healthDamage;
            this.StaminaEffect = staminaCost;
            this.ManaEffect = manaCost;
            this.HitModf = hitPercent;
            this.Name = name;
        }

        public int HealtDmg { get; set; }

        public int HitModf { get; set; }

        public override string AbilityType
        {
            get
            {
                return "Def";
            }
        }

        public GameAction CreatAction()
        {
            throw new NotImplementedException();
        }
    }
}
