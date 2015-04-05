using rpg_Game_V1.EntityModels;
using rpg_Game_V1.Render;
using rpg_Game_V1.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CombatScreen());

            var testEnemy=new Enemy("Billy",100,0,0,0,0,0,@"http://assets.sbnation.com/assets/795920/zergling-300.jpg",0);
            var testPlayer = new Player("Pavel", 100, 100, 5, 0, 0, 0,0);
            AllocConsole();
            var sword1 = new Saber("Doom", 10, 50, 1);
            testPlayer.AddItem(sword1);
            testPlayer.EquipWeapon(sword1);
            var armor1 = new PlateArmor(15);
            Console.WriteLine(testPlayer);
            testPlayer.EquipArmor(armor1);
            Console.WriteLine(testPlayer);

            Console.ReadLine();
           
        }
    }
}
