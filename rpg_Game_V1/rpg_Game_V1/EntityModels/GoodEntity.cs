using rpg_Game_V1.EntityModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.EntityModels
{
    public abstract class GoodEntity : Entity,IEntity
    {
        public bool IsGood { get; private set; }

        public GoodEntity(string name,int health,int mana, int stamina,
            int dexterity, int intelligence, int strenght, int defenceRation)
            :base(name,health,mana,stamina,dexterity,intelligence,strenght,defenceRation)
        {
            this.IsGood = true;
        }

    }
}
