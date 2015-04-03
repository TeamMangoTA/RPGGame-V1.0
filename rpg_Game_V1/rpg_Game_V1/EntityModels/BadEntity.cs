using rpg_Game_V1.EntityModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.EntityModels
{
    abstract class BadEntity:Entity,IEntity
    {
        public bool IsGood { get; private set; }

        public BadEntity(string name,int health,int mana, int stamina,
            int dexterity, int intelligence, int strenght)
            :base(name,health,mana,stamina,dexterity,intelligence,strenght)
        {
            this.IsGood = false;
        }
    }
}
