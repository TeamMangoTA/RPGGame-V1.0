
namespace rpg_Game_V1.Weapons
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using rpg_Game_V1.AbilityModels;
    using rpg_Game_V1.Weapons.Interface;

    public class Trinket : Weapon
    {
        public int DmgValue { get; set; }
        public int AccuracyRating { get; set; }
        public int StaminaCost { get; set; }

        public Trinket(string name, int dmg, int acc, int staminacost, string imageLocation)
            : base(imageLocation)
        {
            this.Name = name;
            this.DmgValue = dmg;
            this.AccuracyRating = acc;
            this.StaminaCost = staminacost;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append(string.Format("   ∙ Dmg: {0,-4}  Ar: {1,-4}  Sc: {2,-4}", this.DmgValue, this.AccuracyRating, this.StaminaCost));
            return sb.ToString();
        }
    }
}
