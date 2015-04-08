using rpg_Game_V1.EntityModels;
using rpg_Game_V1.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpg_Game_V1
{
    public partial class ChoiceWindow : Form
    {
        public BattlePath battlePath { get; set; }

        public ChoiceWindow()
        {
            InitializeComponent();
        }

        public ChoiceWindow(BattlePath bp)
        {
            InitializeComponent();
            this.battlePath = bp;
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            this.battlePath.inventoryScreen = new InventoryWindow(this.battlePath.player);
            battlePath.inventoryScreen.ShowDialog();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Program.Main();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            this.battlePath.battleScreen = new CombatScreen(this.battlePath.player, this.battlePath.enemy);
            this.battlePath.battleScreen.ShowDialog();
        }
    }
}
