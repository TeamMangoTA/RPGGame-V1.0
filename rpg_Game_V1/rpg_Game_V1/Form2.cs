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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.label1.Text = "Hit";
            this.label1.ForeColor = Color.Green;
            this.label1.Font = new Font(this.label1.Font.FontFamily, 140);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        
    }
}
