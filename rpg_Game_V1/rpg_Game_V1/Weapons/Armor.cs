using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.Weapons
{
    abstract class Armor:Items
    {
        public Armor(string imageLocation)
            : base(imageLocation)
        { 
        }
        
    }
}
