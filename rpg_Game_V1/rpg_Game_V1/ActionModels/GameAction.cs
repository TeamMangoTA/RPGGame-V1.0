using rpg_Game_V1.AbilityModels;
using rpg_Game_V1.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.ActionModels
{
    abstract class GameAction
    {
        public Entity Orgin { get; set; }
        public Entity Target { get; set; }


        public GameAction(Player p1, Enemy p2, Ability a1)
        {
            this.Orgin = p1;
            this.Target = p2;
        }

    }
}
