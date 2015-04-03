using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.EntityModels.Interfaces
{
    public interface IEntity
    {
        EntityStats Info { get; set; }

        string Name { get; set; }

        void ChangeHealth(int health);
        void ChangeMana(int mana);
        void ChangeStamina(int stamina);

    }
}
