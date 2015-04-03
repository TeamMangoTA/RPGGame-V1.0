using rpg_Game_V1.EntityModels;
using rpg_Game_V1.Render;
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

            var testEnemy=new Enemy("Billy",0,0,0,0,0,0,@"http://assets.sbnation.com/assets/795920/zergling-300.jpg");
            
            var test = new Renderer();
            test.OpenComabatScreen(testEnemy);

            AllocConsole();
            Console.WriteLine(testEnemy);
            Console.ReadKey();
        }
    }
}
