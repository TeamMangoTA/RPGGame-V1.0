using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.EntityModels
{
    public struct EntityStats
    {
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Stamina { get; set; }

        public int Dex { get; set; }
        public int Int { get; set; }
        public int Str { get; set; }

        public int DefenceRating { get; set; }

        public EntityStats(int health, int mana, int stamina, int dex, int intelligence, int strenght):this()
        {
            this.Health = health;
            this.Mana = mana;
            this.Stamina = stamina;
            this.Dex = dex;
            this.Int = intelligence;
            this.Str = strenght;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("- Stats:"));
            sb.AppendLine(string.Format(" * Health: {0}", this.Health));
            sb.AppendLine(string.Format(" * Mana: {0}", this.Mana));
            sb.AppendLine(string.Format(" * Stamina: {0}", this.Stamina));
            sb.AppendLine(string.Format(" * Dexterity: {0}", this.Dex));
            sb.AppendLine(string.Format(" * Intelligence: {0}", this.Int));
            sb.Append(string.Format(" * Strength: {0}", this.Str));

            return sb.ToString();
        }
    }
}
