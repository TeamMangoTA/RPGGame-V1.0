using rpg_Game_V1.EntityModels;
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
    public partial class CombatScreen : Form
    {
        public Player HumanPlayer { get; set; }
        public Enemy Mob { get; set; }

        public CombatScreen()
        {
            InitializeComponent();
        }

        public CombatScreen(string imageLocation)
        {
            InitializeComponent();
            this.EnemyPicture.Load(imageLocation);
        }

        public CombatScreen(Player human, Enemy mob)
        {
            InitializeComponent();
            this.HumanPlayer = human;
            this.Mob = mob;
            this.label1.Text = this.HumanPlayer.ToString();
            this.label2.Text = this.Mob.ToString();
            this.EnemyPicture.Load(mob.Image);
            this.comboBox1.Items.AddRange(human.AbilityList());
            this.comboBox1.Items.Add("No Action");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var r = -1;
            if (this.comboBox1.SelectedIndex != this.comboBox1.Items.Count - 1)
            {
                r = this.HumanPlayer.DoAttack(this.Mob, this.comboBox1.SelectedIndex);
            }
            
            switch(r)
            {
                case 0:
                    this.HeroAttackResult.Load(@"../../miss.jpg");
                    break;
                case 1:
                    this.HeroAttackResult.Load(@"../../hit.jpg");
                    break;
                default:
                    this.HeroAttackResult.Load(@"../../noattack.jpg");
                    break;
            }
            if (r == -1) { this.HumanPlayer.ChangeStamina(1); }

            var r1 = this.Mob.DoAttack(this.HumanPlayer, 0);

            switch (r1)
            {
                case 0:
                    this.pictureBox2.Load(@"../../miss.jpg");
                    break;
                case 1:
                    this.pictureBox2.Load(@"../../hit.jpg");
                    break;
                default:
                    this.pictureBox2.Load(@"../../noattack.jpg");
                    break;
            }
            this.label1.Text = this.HumanPlayer.ToString();
            this.label2.Text = this.Mob.ToString();
            this.Update();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HeroAttackResult_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
