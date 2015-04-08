using rpg_Game_V1.AbilityModels;
using rpg_Game_V1.EntityModels;
using rpg_Game_V1.Render;
using rpg_Game_V1.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using rpg_Game_V1.Factories;

namespace rpg_Game_V1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        static extern bool AllocConsole();//Slagane na konzola vyv drug tip proekt



        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // UNCOMENT here ==========================>
            var Battle = new BattlePath();
            var choiceWindow = new ChoiceWindow(Battle);
            choiceWindow.ShowDialog();




            
        }
    }
}
