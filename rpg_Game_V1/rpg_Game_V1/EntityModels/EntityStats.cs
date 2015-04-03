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
            sb.AppendLine(string.Format("Stats:"));
            sb.AppendLine(string.Format(" - {1,-13} {0}", this.Health, "Health:"));
            sb.AppendLine(string.Format(" - {1,-13} {0}", this.Mana, "Mana:"));
            sb.AppendLine(string.Format(" - {1,-13} {0}", this.Stamina, "Stamina:"));
            sb.AppendLine(string.Format(" - {1,-13} {0}", this.Dex, "Dexterity:"));
            sb.AppendLine(string.Format(" - {1,-13} {0}", this.Int, "Intelligence:"));
            sb.Append(string.Format(" - {1,-13} {0}", this.Str, "Strength:"));

            return sb.ToString();
        }
    }
}
