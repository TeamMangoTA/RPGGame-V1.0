using rpg_Game_V1.AbilityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.EntityModels
{
    class Player:GoodEntity
    {

        private const int WeaponsLimit = 2;
        private const int ArmorLimit = 1;
        private const int TrinketsLimit = 4; 

        List<Ability> Skills = new List<Ability>();



        public Player(string name,int health,int mana, int stamina,
            int dexterity, int intelligence, int strenght)
            :base(name,health,mana,stamina,dexterity,intelligence,strenght)
        {
            
        }

        public int AvailableWeapons { get; set; }
        public int AvailableArmor { get; set; }
        public int AvailableTrinkets { get; set; }

    }
}
