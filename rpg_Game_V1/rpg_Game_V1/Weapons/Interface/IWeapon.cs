using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.Weapons.Interface
{
    public interface IWeapon
    {
        int DmgValue { get; set; }
        int StaminaCost { get; set; }
      
    }
}
