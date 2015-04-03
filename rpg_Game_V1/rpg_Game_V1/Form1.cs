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
        public CombatScreen()
        {
            InitializeComponent();
        }

        public CombatScreen(string imageLocation)
        {
            InitializeComponent();
            this.EnemyPicture.Load(imageLocation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
