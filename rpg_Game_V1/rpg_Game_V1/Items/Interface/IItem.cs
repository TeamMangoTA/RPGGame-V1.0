using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.Weapons.Interface
{
    public interface IItem
    {

        string Name { get; set; }
        int EquipmentCost { get; set; }
        string Image { get; set; }
    }
}
