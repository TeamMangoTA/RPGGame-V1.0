using rpg_Game_V1.AbilityModels;
using rpg_Game_V1.ActionModels;
using rpg_Game_V1.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_Game_V1.EntityModels
{
    public class Player:GoodEntity
    {
        List<AttackAbility> attacks = new List<AttackAbility>();
        List<Items> Inventory = new List<Items>();
        List<Items> Equiped = new List<Items>();
        int weaponCapacity = 2;
        int armorCapacity = 1;

        public Player(string name,int health,int mana, int stamina,
            int dexterity, int intelligence, int strenght, int defenceRation)
            :base(name,health,mana,stamina,dexterity,intelligence,strenght,defenceRation)
        {
            
        }

        public void AddItem(Items thing)
        {
            this.Inventory.Add(thing);
            var temp = (Saber)thing;

            //attacks.Add(new LightAttackAbility(temp));
        }

        public void EquipWeapon(Items thing)
        {
            if(thing is Weapon)
            {
                if(weaponCapacity>0)
                {
                    Equiped.Add(thing);
                   
                    var temp = (Saber)thing;

                    attacks.Add(new LightAttackAbility(temp));
                    weaponCapacity--;
                }

                //else { Console.WriteLine("Not Allowed"); }
            }
        }

        public void EquipArmor(Items thing)
        {
            if (thing is PlateArmor)
            {
                if (weaponCapacity > 0)
                {
                    Equiped.Add(thing);

                    armorCapacity--;
                    var temp = (PlateArmor)thing;
                    this.ChangeDefence(temp.DefRatingMod);
                }

                //else { Console.WriteLine("Not Allowed"); }
            }
        }

        public bool DoAttack(Enemy target, int n)
        {
            var r = true;
            int ch = n;
            if (ch < 0) { return true; }
            var tempattack = (LightAttackAbility)attacks[ch];
            if (this.Info.Stamina >= tempattack.StaminaEffect)
            {
                r = this.DoAttack(target, tempattack);
            }
            return r;
        }

        public string InventoryList()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Inventory: ");
            foreach (var item in Inventory)
            {
                result.AppendLine(item.Name);
            }

            return result.ToString();
        }

        public string AbilityList()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Skill: ");
            foreach (var item in attacks)
            {
                result.AppendLine(item.Name);
            }

            return result.ToString();
        }

        private bool DoAttack(Enemy target, Ability a)
        {
            var skill = (LightAttackAbility)a;
            var action = skill.CreatAction(this, target);
            var resolution = action;
            var r=resolution.Resolve();

            return r;
        }

        public override string ToString()
        {
            return base.ToString()+Environment.NewLine+ this.InventoryList()+this.AbilityList();
        }
    }
}
