﻿namespace rpg_Game_V1.Weapons
{  
    using System.Text;
   
    using AbilityModels;
    using Weapons.Interface;

    public class Trinket : Weapon
    {  
        public Trinket(string name, int dmg, int acc, int staminacost, string imageLocation)
            : base(imageLocation)
        {
            this.Name = name;
            this.DmgValue = dmg;
            this.AccuracyRating = acc;
            this.StaminaCost = staminacost;
        }

        public int DmgValue { get; set; }
        public int AccuracyRating { get; set; }
        public int StaminaCost { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append(string.Format("   ∙ Dmg: {0,-4}  Ar: {1,-4}  Sc: {2,-4}", this.DmgValue, this.AccuracyRating, this.StaminaCost));
            return sb.ToString();
        }
    }
}
