namespace rpg_Game_V1.AbilityModels
{
    using System;
    
    using rpg_Game_V1.Weapons;
    using rpg_Game_V1.ActionModels;
    using rpg_Game_V1.EntityModels;
    
    public class HealAbility : AttackAbility
    {
        public HealAbility(Trinket trinket)
        {
            this.HealtDmg = trinket.DmgValue;
            this.StaminaEffect = 0;
            this.ManaEffect = 0;
            this.HitModf = int.MaxValue;
            this.Name = trinket.Name;
        }

        public int HealtDmg { get; set; }
        public int StaminaEffect { get; set; }
        public int ManaEffect { get; set; }
        public int HitModf { get; set; }

        public HealAction CreatAction(Entity origin)
        {            
            var player = (Player)origin;

            return new HealAction(player, player, this);           
        }

        public override string AbilityType
        {
            get
            {
                return "Heal";
            }
        }

        public override string ToString()
        {
            return this.Name + string.Format(" - Sc: {0}", this.HealtDmg);
        }
    }
}
