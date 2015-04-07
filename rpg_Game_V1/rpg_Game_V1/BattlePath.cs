using rpg_Game_V1.EntityModels;
using rpg_Game_V1.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1
{
    public class BattlePath
    {

        public InventoryWindow inventoryScreen { get; set; }
        public CombatScreen battleScreen { get; set; }
        public Player player { get; set; }
        public Enemy enemy { get; set; }
        public MobFactory mFactory { get; set; }

        public BattlePath()
        {
            this.mFactory = MobFactory.Instance;
            this.enemy = mFactory.CreateEnemy();
            this.player = new Player("Pavel", 100, 100, 5, 0, 0, 0, 0);

            for (int i = 0; i < 7; i++)
            {
                var itemRnd = ItemFactory.CreateRandomItem();
                player.AddItem(itemRnd);                
            }

            inventoryScreen = new InventoryWindow(player);
           //inventoryScreen.ShowDialog();
            battleScreen = new CombatScreen(player, enemy);
          // battleScreen.ShowDialog();
        }
    }
}
