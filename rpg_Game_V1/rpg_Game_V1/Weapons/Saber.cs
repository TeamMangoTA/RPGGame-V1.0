using rpg_Game_V1.AbilityModels;
using rpg_Game_V1.Weapons.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.Weapons
{
    public class Saber : Weapon, IWeapon
    {
        public int DmgValue { get; set; }
        public int AccuracyRating { get; set; }
        public int StaminaCost { get; set; }

        public Saber(string name, int dmg, int acc,int staminacost)
        {
            this.Name = name;
            this.DmgValue = dmg;
            this.AccuracyRating = acc;
            this.StaminaCost = staminacost;
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
    }
}
