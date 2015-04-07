using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.ActionModels.Interface
{
    public interface IHealer
    {
        int DmgValue { get; set; }
        //public string ID { get; set; }
        int ManaEffect { get; set; }
        int StaminaEffect { get; set; }

        int Resolve();
        
    }
}
