using rpg_Game_V1.AbilityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.Weapons
{
    public abstract class Items
    {
        public string Name { get; set; }
        //public abstract Ability AddAbility();
        public int EquipmentCost { get; set; }

        public override string ToString()
        {
            return this.Name + " - used slots: " + this.EquipmentCost;
        }
    }   
}
