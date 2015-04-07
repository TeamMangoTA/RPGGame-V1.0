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
            this.InventoryItems.Text = string.Join("\n", Human.Inventory );
            this.comboBoxEquip.Items.AddRange(this.ItemsNames());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string[] ItemsNames()
        {
            var invet = this.Human.Inventory;

            var output = invet.Select(item => item.ToString()).ToArray();

            return  output;
        }

        private void buttonEquipItem_Click(object sender, EventArgs e)
        {
            var index = this.comboBoxEquip.SelectedIndex;
            var item = this.Human.Inventory[index];

            // Trinket before weapon because trinkit is weapon itself and sets as weapon
            if (item is Trinket)
            {
                this.Human.EqipTrinket(item);
            }
            else if(item is Weapon)
            {
                this.Human.EquipWeapon(item);
            }
            else if(item is Armor)
            {
                this.Human.EquipArmor(item);
            }
            

            this.SetUpEquipment();
            this.InventoryItems.Text = string.Join("\n", Human.Inventory);
            this.comboBoxEquip.Items.Clear();
            this.comboBoxEquip.Items.AddRange(this.ItemsNames());
            this.Update();
        }

        private void SetUpEquipment()
        {
            this.comboBoxUnequip.Items.Clear();
            List<string> equipment = new List<string>();
            int count = 0;
            foreach (var item in this.Human.Equiped)
            {
                if(item is Weapon)
                {
                 
                    switch(count)
                    {
                        case 0:
                            this.pictureBox1.Load(item.Image);
                            // Labesls for Items stas starts with stats
                            this.StatsWeaponOneLabel.Text=item.ToString();
                            break;
                        case 1:
                            this.pictureBox2.Load(item.Image);
                            this.StatsWeaponTwooLabel.Text = item.ToString();
                            break;
                        default:
                            break;
                    }
                    count++;
                }
                else if(item is Armor)
                {
               
                    this.pictureBox3.Load(item.Image);
                    this.StatsArmorLabel.Text = item.ToString();
                }
                else
                {
                    this.pictureBox4.Load(item.Image);
                    this.StatsTrinketLabel.Text = item.ToString();
                }

                equipment.Add(item.ToString());
            }

            this.comboBoxUnequip.Items.AddRange(equipment.ToArray());


        }

        private void buttonUnequip_Click(object sender, EventArgs e)
        {
            var index = this.comboBoxUnequip.SelectedIndex;
            var item = this.Human.Equiped[index];

            if(item is Weapon)
            {
                this.Human.UneqipWeapon(item);
            }
            else if(item is Armor)
            {
                this.Human.UneqipArmour(item);
            }
            else
            {
                this.Human.UneqipTrinket(item);
            }

            this.InventoryItems.Text = string.Join("\n", Human.Inventory);
            this.comboBoxEquip.Items.Clear();
            this.comboBoxEquip.Items.AddRange(this.ItemsNames());
            
        }


    }
}

