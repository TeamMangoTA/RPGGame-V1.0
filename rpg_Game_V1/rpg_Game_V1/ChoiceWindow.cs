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
        public BattlePath battlePath;

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
            battlePath.inventoryScreen = new InventoryWindow(battlePath.player);
            battlePath.inventoryScreen.ShowDialog();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Program.Main();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            battlePath.battleScreen = new CombatScreen(battlePath.player, battlePath.enemy);
            battlePath.battleScreen.ShowDialog();
        }
    }
}
