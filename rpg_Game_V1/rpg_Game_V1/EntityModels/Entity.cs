using rpg_Game_V1.EntityModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.EntityModels
{
    abstract class Entity:IEntity
    {
        public EntityStats Info { get;  set; }

        public string Name { get; set; }

        public Entity(string name,int health,int mana, int stamina,
            int dexterity, int intelligence, int strenght)
        {
            this.Name = name;
            this.Info = new EntityStats(health, mana, stamina, dexterity, intelligence, strenght);
        }

        public void ChangeHealth(int health)
        {
            var h = this.Info.Health;
            var m = this.Info.Mana;
            var s = this.Info.Stamina;
            var d = this.Info.Dex;
            var i = this.Info.Int;
            var str = this.Info.Str;


            this.Info = new EntityStats(h + health, m, s, d, i, str);
        }

        public void ChangeMana(int mana)
        {
            var h = this.Info.Health;
            var m = this.Info.Mana;
            var s = this.Info.Stamina;
            var d = this.Info.Dex;
            var i = this.Info.Int;
            var str = this.Info.Str;


            this.Info = new EntityStats(h, m+mana, s, d, i, str);
        }

        public void ChangeStamina(int stamina)
        {
            var h = this.Info.Health;
            var m = this.Info.Mana;
            var s = this.Info.Stamina;
            var d = this.Info.Dex;
            var i = this.Info.Int;
            var str = this.Info.Str;


            this.Info = new EntityStats(h, m, s+stamina, d, i, str);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("Type: {0}", this.GetType().Name));
            sb.AppendLine(string.Format("Name: {0}", this.Name));
            sb.Append(this.Info.ToString());
       
            return sb.ToString();
        }       
    }
}
