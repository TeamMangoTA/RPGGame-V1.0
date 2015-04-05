using rpg_Game_V1.AbilityModels;
using rpg_Game_V1.ActionModels.Interface;
using rpg_Game_V1.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpg_Game_V1.ActionModels
{
    class WeaponAttack : OffensiveA, IOffensive
    {
        public int DmgValue { get; set; }
        //public string ID { get; set; }
        public int ManaEffect { get; set; }
        public int StaminaEffect { get; set; }

        public bool Defend
        {
            get;
            set;
        }

        public WeaponAttack(Player p1, Enemy p2, LightAttackAbility a1)
            : base(p1, p2, a1)
        {

            var temp = a1;
            this.DmgValue = temp.HealtDmg;
            this.ManaEffect = temp.ManaEffect;
            this.StaminaEffect = temp.StaminaEffect;

            if (p2.Info.DefenceRating > temp.HitModf)
            {
                this.Defend = true;
            }
            else
            {
                this.Defend = false;
                
            }

        }

        public bool Resolve()
        {
            this.Orgin.ChangeMana(-this.ManaEffect);
            this.Orgin.ChangeStamina(-this.StaminaEffect);

            if (this.Defend == false)
            {
                this.Target.ChangeHealth(-this.DmgValue);
                
               
            }
            else
            {
                Console.WriteLine("Blocked");
            }

            return this.Defend;
        }

        public void HitResponse()
        {
            Application.Run(new Form2());
        }
    }
}
