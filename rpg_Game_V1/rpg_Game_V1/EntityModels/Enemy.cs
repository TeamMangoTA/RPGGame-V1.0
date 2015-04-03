using rpg_Game_V1.EntityModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.EntityModels
{
    class Enemy:BadEntity,IEntity
    {
        public string Image { get; set; }

        public Enemy(string name,int health,int mana, int stamina,
            int dexterity, int intelligence, int strenght, string imageLoc)
            :base(name,health,mana,stamina,dexterity,intelligence,strenght)
        {
            this.Image = imageLoc;
        }
    }
}
