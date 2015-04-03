using rpg_Game_V1.EntityModels;
using rpg_Game_V1.Render;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpg_Game_V1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CombatScreen());

            var testEnemy=new Enemy("Billy",0,0,0,0,0,0,@"http://assets.sbnation.com/assets/795920/zergling-300.jpg");
            var test = new Renderer();
            test.OpenComabatScreen(testEnemy);
        }
    }
}
