using rpg_Game_V1.Weapons.Interface;
namespace rpg_Game_V1.Weapons
{
    abstract class Armor : Items, IItem
    {
        public Armor(string imageLocation)
            : base(imageLocation)
        { 
        }        
    }
}
