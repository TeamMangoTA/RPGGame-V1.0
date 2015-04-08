namespace rpg_Game_V1.Weapons
{
    public abstract class Weapon : Items
    {
        public Weapon(string imageLocation)
            : base(imageLocation)
        { 
        }

        public int DmgValue { get; set; }
        public int AccuracyRating { get; set; }
    }
}
