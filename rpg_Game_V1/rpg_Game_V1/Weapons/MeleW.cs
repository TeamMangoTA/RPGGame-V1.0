using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.Weapons
{
    public abstract class MeleW : Weapon
    {
        public virtual string GetType()
        {
            return "Mele";
        }
    }
}
