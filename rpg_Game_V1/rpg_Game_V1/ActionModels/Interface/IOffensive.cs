using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.ActionModels.Interface
{
    public interface IOffensive
    {
        int DmgValue { get; set; }
        bool Defend { get; set; }

        void Resolve();
    }
    
}
