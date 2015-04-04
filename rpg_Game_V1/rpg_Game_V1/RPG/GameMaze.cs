namespace rpg_Game_V1.EntityModels.RPG
{
    using System;
    using System.IO;
    using System.Text;
    using System.Threading;
    public class GameMaze
    {
        // Private Max Coordinates of Matrix
        private int xCoordinate;
        private int yCoordinate;
        private Hero player;

        //Constructor of Matrix
        public GameMaze(int xCoord, int yCoord)
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
            this.LocData = new int?[this.xCoordinate, this.yCoordinate];
            this.Visible = new int[this.xCoordinate, this.yCoordinate];
            this.Result = new int?[this.xCoordinate, this.yCoordinate];
        }
        public GameMaze(int xCoord, int yCoord, Hero initPlayer)
            : this(xCoord, yCoord)
        {
            this.player = initPlayer;
            this.Set(player);
            this.GetLabirint();

        }

        // Properties of Matrix, check if they is bigger than 0
        public int XCoord
        {
            get { return xCoordinate; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("XCoord must be > 0 ");
                }
                this.xCoordinate = value;
            }
        }
        public int YCoord
        {
            get { return yCoordinate; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("YCoord must be > 0");
                }
                this.yCoordinate = value;
            }
        }
        public int?[,] LocData { get; private set; }
        public int[,] Visible { get; private set; }
        public int?[,] Result { get; private set; }

        //Indexators of LocData
        public int? this[int row, int col]
        {
            get
            {
                return this.LocData[row, col];
            }
            private set
            {
                this.LocData[row, col] = value;
            }
        }

        // Calculating between 2 Matrix
        public void Discovering()
        {
            for (int i = 0; i < xCoordinate; i++)
            {
                for (int j = 0; j < yCoordinate; j++)
                {
                    if (this.Visible[i, j] == (int)ValueEnum.visible)
                    {
                        this.Result[i, j] = this.Visible[i, j];
                    }

                    if (this.LocData[i, j] == (int)ValueEnum.player)// || this.LocData[i, j] == (int)ValueEnum.wall)
                    {
                        this.Result[i, j] = this.LocData[i, j];
                    }
                }
            }
        }

        // Set Hero on Matrix
        public void Set(Hero player)
        {
            int xCoord = player.XPosition;
            int yCoord = player.YPosition;
            int hero = player.Player;
            if (xCoord >= 0 && xCoord < this.xCoordinate)
            {
                if (yCoord >= 0 && yCoord < this.yCoordinate)
                {
                    this.LocData[xCoord, yCoord] = hero;
                }
            }
            this.Reveal();
        }

        // Discovery of The Hero
        public void Reveal()
        {
            int visible = (int)ValueEnum.visible;
            int wall = (int)ValueEnum.wall;
            int xCoord = player.XPosition;
            int yCoord = player.YPosition;
            if (xCoord >= 0 && xCoord < this.xCoordinate)
            {
                if (yCoord >= 0 && yCoord < this.yCoordinate)
                {
                    this.Visible[xCoord, yCoord] = visible;
                    if (xCoord < this.xCoordinate - 1)
                    {
                        if (this.LocData[xCoord + 1, yCoord] == wall)
                        {
                            this.Result[xCoord + 1, yCoord] = wall;
                        }
                        else
                        {
                            this.Visible[xCoord + 1, yCoord] = visible;
                        }
                    }
                    if (yCoord < this.yCoordinate - 1)
                    {
                        if (this.LocData[xCoord, yCoord + 1] == wall)
                        {
                            this.Result[xCoord, yCoord + 1] = wall;
                        }
                        else
                        {
                            this.Visible[xCoord, yCoord + 1] = visible;
                        }
                    }
                    if (xCoord > 0)
                        if (this.LocData[xCoord - 1, yCoord] == wall)
                        {
                            this.Result[xCoord - 1, yCoord] = wall;
                        }
                        else
                        {
                            this.Visible[xCoord - 1, yCoord] = visible;
                        }
                    if (yCoord > 0)
                    {
                        if (this.LocData[xCoord, yCoord - 1] == wall)
                        {
                            this.Result[xCoord, yCoord - 1] = wall;
                        }
                        else
                        {
                            this.Visible[xCoord, yCoord - 1] = visible;
                        }
                    }
                }
            }
            Discovering();
        }

        public void MoveCommand(Hero player)
        {
            int xCoord = player.XPosition;
            int yCoord = player.YPosition;
            this.LocData[xCoord, yCoord] = (int)ValueEnum.visible;
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                if (userInput.Key == ConsoleKey.UpArrow)
                {
                    if (player.XPosition > 0 && this.LocData[xCoord - 1, yCoord] != 0)
                    {
                        player.XPosition--;
                    }
                }
                if (userInput.Key == ConsoleKey.DownArrow)
                {
                    if (player.XPosition < this.xCoordinate - 1 && this.LocData[xCoord + 1, yCoord] != 0)
                    {
                        player.XPosition++;
                    }
                }
                if (userInput.Key == ConsoleKey.LeftArrow && this.LocData[xCoord, yCoord - 1] != 0)
                {
                    if (player.YPosition > 0)
                    {
                        player.YPosition--;
                    }
                }
                if (userInput.Key == ConsoleKey.RightArrow)
                {
                    if (player.YPosition < this.yCoordinate - 1 && this.LocData[xCoord, yCoord + 1] != 0)
                    {
                        player.YPosition++;
                    }
                }
                this.Set(player);
                if (LocData[xCoord, yCoord] == 3)
                {
                    StartCombat();
                }
            }

            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
            }
        }

        private void GetLabirint()
        {
            StreamReader labirint = new StreamReader(@"..\..\RPG\labirint.csv");
            using (labirint)
            {
                int rowNumber = 0;
                string line = labirint.ReadLine();
                while (line != null)
                {
                    string[] lineArr = line.Split(',');
                    for (int j = 0; j < this.LocData.GetLength(1); j++)
                    {
                        if (int.Parse(lineArr[j]) == 0)
                        {
                            this.LocData[rowNumber, j] = int.Parse(lineArr[j]);
                        }
                    }
                    rowNumber++;
                    line = labirint.ReadLine();
                }
            }
        }
        public void MazeTravel()
        {
            ConsoleDraw();
            while (true)
            {
                MoveCommand(this.player);

                ConsoleDraw();
                Thread.Sleep(100);
            }
        }

        private void StartCombat()
        {
            //throw new NotImplementedException();
            Console.WriteLine("There are Enemy");
        }
        public void ConsoleDraw()
        {
            Console.WindowHeight = 42;
            Console.WindowWidth = 42;

            var draw = new StringBuilder();
            for (int i = 0; i < xCoordinate; i++)
            {
                for (int j = 0; j < yCoordinate; j++)
                {
                    if (this.Result[i, j] == null)
                    {
                        draw.Append("#");
                    }
                    else if (this.Result[i, j] == 1)
                    {
                        draw.Append(" ");
                    }
                    else
                    {
                        draw.Append(string.Format("{0}", this.Result[i, j]));
                    }
                }
                if (i < xCoordinate - 1)
                {
                    draw.AppendLine();
                }
            }
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
            Console.Write(draw);
        }

    }
}

