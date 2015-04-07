using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.AbilityModels
{
    public abstract class Ability
    {
        public string Name { get; set; }
        public int StaminaEffect { get; set; }
        public int ManaEffect { get; set; }
        public virtual string AbilityType
        {
            get
            {
                return "Non";
            }
        }
    }
}
