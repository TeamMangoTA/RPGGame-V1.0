using rpg_Game_V1.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpg_Game_V1.Render
{
    class Renderer
    {
        public void OpenComabatScreen(Enemy opponent)
        {
            var imageUri = opponent.Image;
            Application.Run(new CombatScreen(imageUri));
        }
    }
}
