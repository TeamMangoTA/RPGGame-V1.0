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
            this.EnemyPicture.Load(mob.Image);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var r=this.HumanPlayer.DoAttack(this.Mob, 0);
            if (!r)
            {
                this.HeroAttackResult.Load(@"..\..\hit.jpg");
            }
            else
            {
                this.HeroAttackResult.Load(@"..\..\miss.jpg");
            }
            this.label1.Text = this.HumanPlayer.ToString();
            this.Update();

            

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
