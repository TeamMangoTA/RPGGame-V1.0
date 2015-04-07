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




            //===============================================>
            // COMMENT ALL FROM HERE
            ////Application.Run(new Form2());


            //var factory = MobFactory.Instance;


            //var testEnemy = factory.CreateEnemy();
            ////var testEnemy=new Enemy("Billy",100,0,0,0,0,0,@"http://assets.sbnation.com/assets/795920/zergling-300.jpg",0);
            //var testPlayer = new Player("Pavel", 100, 100, 5, 0, 0, 0, 0);
            //// AllocConsole();
            //var sword1 = new Saber("Doom", 0, 50, 1, @"http://assets.sbnation.com/assets/795920/zergling-300.jpg");
            //var sword2 = new Saber("Chaos", 25, -50, 2, @"http://assets.sbnation.com/assets/795920/zergling-300.jpg");
            //var staff1 = new DarkStaff("Boom", 90, 70, 40, @"http://assets.sbnation.com/assets/795920/zergling-300.jpg");
            //var staff2 = new DarkStaff("THis staff", 15, 40, 10, @"http://assets.sbnation.com/assets/795920/zergling-300.jpg");
            ////var armor1 = new PlateArmor("GosoArmor", 15, @"http://assets.sbnation.com/assets/795920/zergling-300.jpg");
            //var item = ItemFactory.CreateRandomItem();
            //var ring = new Trinket("Ring", 30, 0, 0, @"http://assets.sbnation.com/assets/795920/zergling-300.jpg");

            ////testPlayer.AddItem(sword1);
            ////testPlayer.AddItem(sword2);
            ////testPlayer.EquipWeapon(sword1);
            //////testPlayer.EquipWeapon(sword2);
            ////testPlayer.AddItem(staff1);
            ////testPlayer.AddItem(staff2);
            ////testPlayer.AddItem(ring);
            ////testPlayer.EquipWeapon(staff1);
            ////testPlayer.EquipWeapon(staff2);
            ////testPlayer.EqipTrinket(ring);

            //for (int i = 0; i < 7; i++)
            //{
            //    var itemRnd = ItemFactory.CreateRandomItem();
            //    testPlayer.AddItem(itemRnd);
            //    //testPlayer.equ
            //}
            //testPlayer.AddItem(sword1);

            //testEnemy.AddAbility(new LightAttackAbility(sword1));


            ////Console.WriteLine(testPlayer);            
            ////testPlayer.EquipArmor(armor1);
            ////Console.WriteLine(testPlayer);
            ////
            ////Console.ReadLine();
            //var inventoryScreen = new InventoryWindow(testPlayer);
            //inventoryScreen.ShowDialog();
            //var battleScreen = new CombatScreen(testPlayer, testEnemy);
            //battleScreen.ShowDialog();
        }
    }
}
