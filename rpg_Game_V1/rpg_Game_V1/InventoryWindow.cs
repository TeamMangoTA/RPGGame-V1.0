using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




using rpg_Game_V1.EntityModels;
using rpg_Game_V1.Weapons;
namespace rpg_Game_V1
{
    public partial class InventoryWindow : Form
    {
        public Player Human { get; set; }

        public InventoryWindow()
        {
            InitializeComponent();
        }

        public InventoryWindow(Player player)
            : base()
        {
            InitializeComponent();
            this.Human = player;
            this.InventoryItems.Text = string.Join("\n", this.ItemsNames());
            this.comboBoxEquip.Items.AddRange(this.ItemsNames());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string[] ItemsNames()
        {
            var invet = this.Human.InventoryList();

            var output = invet.Select(item => item.ToString()).ToArray();

            return output;

        }

          }
}

