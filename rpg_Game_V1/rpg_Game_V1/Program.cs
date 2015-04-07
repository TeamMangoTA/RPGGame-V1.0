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
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form2());
            var factory = MobFactory.Instance;


            var testEnemy = factory.CreateEnemy();
            //var testEnemy=new Enemy("Billy",100,0,0,0,0,0,@"http://assets.sbnation.com/assets/795920/zergling-300.jpg",0);
            var testPlayer = new Player("Pavel", 100, 100, 5, 0, 0, 0,0);
            // AllocConsole();
            var sword1 = new Saber("Doom", 10, 50, 1);
            var sword2 = new Saber("Chaos", 25, -50, 2);
            var staff1 = new DarkStaff("Boom", 90, 70, 40);
            var staff2 = new DarkStaff("THis staff", 15, 40, 10);
            var armor1 = new PlateArmor(15);
            var ring = new Trinket("Ring", 30, 0, 0);

            //testPlayer.AddItem(sword1);
            //testPlayer.AddItem(sword2);
            //testPlayer.EquipWeapon(sword1);
            //testPlayer.EquipWeapon(sword2);
            testPlayer.AddItem(staff1);
            testPlayer.AddItem(staff2);
            testPlayer.EquipWeapon(staff1);
            testPlayer.EquipWeapon(staff2);
            testPlayer.EqipTrinket(ring);


            testEnemy.AddAbility(new LightAttackAbility(sword1));
         
            
            //Console.WriteLine(testPlayer);            
            testPlayer.EquipArmor(armor1);
            //Console.WriteLine(testPlayer);
            //
            //Console.ReadLine();

            var test = new CombatScreen(testPlayer,testEnemy );
            test.ShowDialog();

        }
    }
}
