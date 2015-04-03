using rpg_Game_V1.AbilityModels;
using rpg_Game_V1.ActionModels.Interface;
using rpg_Game_V1.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.ActionModels
{
    class WeaponAttack : OffensiveA, IOffensive
    {
        public int DmgValue { get; set; }
        //public string ID { get; set; }

        public bool Defend
        {
            get;
            set;
        }

        public WeaponAttack(Player p1, Enemy p2, Ability a1)
            : base(p1, p2, a1)
        {

            var temp = (AttackAbility)a1;
            this.DmgValue = temp.HealtDmg;
            if (p2.Info.DefenceRating > temp.HitModf)
            {
                this.Defend = true;
            }
            else
            {
                this.Defend = false;
            }

        }

        public void Resolve()
        {
            if (this.Defend == false)
            {
                this.Target.ChangeHealth(-this.DmgValue);
            }
            else
            {
                Console.WriteLine("Blocked");
            }
        }
    }
}
