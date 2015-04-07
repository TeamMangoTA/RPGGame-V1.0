using rpg_Game_V1.AbilityModels;
using rpg_Game_V1.Weapons.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.Weapons
{
    class PlateArmor:Armor,IArmor
    {
        public int DefRatingMod { get; set; }

        public PlateArmor(string name, int def, string imageLocation)
            : base(imageLocation)
        {
            this.Name = name;
            this.DefRatingMod = def;
        }

        //public override Ability AddAbility()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
