using rpg_Game_V1.ActionModels;
using rpg_Game_V1.EntityModels;
using rpg_Game_V1.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.AbilityModels
{
    public class LightAttackAbility:AttackAbility
    {

        public int HealtDmg { get; set; }
        public int StaminaEffect { get; set; }
        public int ManaEffect { get; set; }
        public int HitModf { get; set; }

        public override string AbilityType
        {
            get
            {
                return "Attack";
            }
        }

        public LightAttackAbility(int healthDamage, int staminaCost, int manaCost, int hitPercent, string name)
        {
            this.HealtDmg = healthDamage;
            this.StaminaEffect = staminaCost;
            this.ManaEffect = manaCost;
            this.HitModf = hitPercent;
            this.Name = name;
        }

        public LightAttackAbility(Saber sword)
        {
            this.HealtDmg = sword.DmgValue;
            this.ManaEffect = 0;
            this.StaminaEffect = sword.StaminaCost;
            this.HitModf = sword.AccuracyRating;
            this.Name = sword.Name + " Light Attack";
        }

        public WeaponAttack CreatAction(Entity origin,Entity target)
        {
            if (origin is Player)
            {
                var player = (Player)origin;
                var mob = (Enemy)target;
                return new WeaponAttack(player, mob, this);
            }
            else
            {
                var player = (Enemy)origin;
                var mob = (Player)target;
                return new WeaponAttack(player, mob, this);
            }
        }

        public override string ToString()
        {
            return this.Name + string.Format(" Stamina Cost: {0}", this.StaminaEffect);
        }
    }
}
