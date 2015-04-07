using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rpg_Game_V1.ActionModels;
using rpg_Game_V1.EntityModels;
using rpg_Game_V1.Weapons;

namespace rpg_Game_V1.AbilityModels
{
    class LightMagicAbility:AttackAbility
    {
        public int HealtDmg { get; set; }
        
        public int HitModf { get; set; }

        public override string AbilityType
        {
            get
            {
                return "Attack";
            }
        }

        public LightMagicAbility(int healthDamage, int staminaCost, int manaCost, int hitPercent, string name)
        {
            this.HealtDmg = healthDamage;
            this.StaminaEffect = staminaCost;
            this.ManaEffect = manaCost;
            this.HitModf = hitPercent;
            this.Name = name;
        }
        public LightMagicAbility(DarkStaff staff)
        {
            this.HealtDmg = staff.DmgValue ;
            this.ManaEffect = staff.ManaCost;
            this.StaminaEffect = 0;
            this.HitModf = staff.AccuracyRating;
            this.Name = staff.Name + " Light Attack";
        }
       
        public LightMagicAbility(DarkStaff staff,Entity owner)
        {
            this.HealtDmg = staff.DmgValue + owner.Info.Int;
            this.ManaEffect = staff.ManaCost;
            this.StaminaEffect = 0;
            this.HitModf = staff.AccuracyRating;
            this.Name = staff.Name + " Light Attack";
        }
        public MagicAttack CreatAction(Entity origin,Entity target)
        {
            if (origin is Player)
            {
                var player = (Player)origin;
                var mob = (Enemy)target;
                return new MagicAttack(player, mob, this);
            }
            else
            {
                var player = (Enemy)origin;
                var mob = (Player)target;
                return new MagicAttack(player, mob, this);
            }
        }

        public override string ToString()
        {
            return this.Name + string.Format(" - Sc: {0}", this.StaminaEffect);
        }
    }
 }

