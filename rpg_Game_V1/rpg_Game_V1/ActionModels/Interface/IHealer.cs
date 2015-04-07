using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.ActionModels.Interface
{
    public interface IHealer
    {
        private int restoreHealth;
        bool defend;

        public void Heal();
    }
}
