namespace rpg_Game_V1.EntityModels.RPG
{
    public class Hero
    {
        private int xPosition;
        private int yPosition;


        public Hero(int xpos, int ypos)
        {
            this.XPosition = xpos;
            this.YPosition = ypos;
            this.Player = (int)ValueEnum.player;
        }
        public int XPosition
        {
            get { return this.xPosition; }
            set { xPosition = value; }
        }
        public int YPosition
        {
            get { return this.yPosition; }
            set { yPosition = value; }
        }
        public int Player { get; protected set; }
    }
}
