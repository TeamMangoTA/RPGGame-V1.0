using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rpg_Game_V1.Weapons.Interface;

namespace rpg_Game_V1.Weapons
{
    public class DarkStaff:Weapon
    {
        public int DmgValue { get; set; }
        public int AccuracyRating { get; set; }
        public int ManaCost { get; set; }

        public DarkStaff(string name, int dmg, int acc,int manaCost)
        {
            this.Name = name;
            this.DmgValue = dmg;
            this.AccuracyRating = acc;
            this.ManaCost = manaCost;
            this.EquipmentCost = 1;
        }

        public int HitMod
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append(string.Format("   ∙ Dmg: {0,-4}  Ar: {1,-4}  Sc: {2,-4}", this.DmgValue, this.AccuracyRating, this.ManaCost));
            return sb.ToString();
        }
    }
}
