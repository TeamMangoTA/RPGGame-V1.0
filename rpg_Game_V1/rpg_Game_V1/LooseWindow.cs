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
    public partial class LooseWindow : Form
    {
        public LooseWindow()
        {
            InitializeComponent();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Program.InitialiseGame();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
           // Environment.Exit(this);
        }
    }
}
