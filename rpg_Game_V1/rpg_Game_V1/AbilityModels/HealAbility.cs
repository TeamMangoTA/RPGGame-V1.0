namespace rpg_Game_V1.AbilityModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using rpg_Game_V1.Weapons;
    
    public class HealAbility : AttackAbility
    {
        public int HealtDmg { get; set; }
        public int StaminaEffect { get; set; }
        public int ManaEffect { get; set; }
        public int HitModf { get; set; }

        public override string AbilityType
        {
            get
            {
                return "Heal";
            }
        }

        public HealAbility(Trinket trinket)
        {
            this.HealtDmg = trinket.DmgValue;
            this.StaminaEffect = 0;
            this.ManaEffect = 0;
            this.HitModf = int.MaxValue;
            this.Name = trinket.Name;
        }

        public override string ToString()
        {
            return this.Name + string.Format(" - Sc: {0}", this.HealtDmg);
        }
    }
}
