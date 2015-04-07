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
        // Make Inventory and Equiped public property !!!
        public List<Items> Inventory {get; set;}
        public List<Items> Equiped { get; set; }
        int weaponCapacity = 2;
        int armorCapacity = 1;
        int trinketCapacity = 1;

        public Player(string name,int health,int mana, int stamina,
            int dexterity, int intelligence, int strenght, int defenceRation)
            :base(name,health,mana,stamina,dexterity,intelligence,strenght,defenceRation)
        {         
            this.Inventory  = new List<Items>();
            this.Equiped = new List<Items>();
        }

        public void AddItem(Items thing)
        {
            this.Inventory.Add(thing);    

            //attacks.Add(new LightAttackAbility(temp));
        }

        public void EquipWeapon(Items thing)
        {
            if(thing is Weapon)
            {
                if(weaponCapacity>0)
                {
                    this.Equiped.Add(thing);
                    if (thing is Saber)
                    {
                        var temp = (Saber)thing;

                        attacks.Add(new LightAttackAbility(temp,this));
                    }
                    else if(thing is DarkStaff)
                    {
                        var temp = (DarkStaff)thing;
                        attacks.Add(new LightMagicAbility(temp,this));
                    }
                    weaponCapacity--;
                    this.Inventory.Remove(thing);
                }

                //else { Console.WriteLine("Not Allowed"); }

            }
        }

        public void UneqipWeapon(Items thing)
        {
            if (thing is Weapon)
            {
                Equiped.Remove(thing);
                Inventory.Add(thing);

                if (thing is Saber)
                {
                    var temp = (Saber)thing;
                    LightAttackAbility tempAbility = new LightAttackAbility(temp);
                    var toRemove = attacks.FirstOrDefault(w => w == tempAbility);
                }

                else
                {
                    var temp=(DarkStaff)thing;
                    LightMagicAbility tempAbility = new LightMagicAbility(temp);
                    var toRemove = attacks.FirstOrDefault(w => w == tempAbility);
                }
                


                weaponCapacity++;
                
            }
        }

        

        public void EquipArmor(Items thing)
        {
            if (thing is PlateArmor)
            {
                if (armorCapacity > 0)
                {
                    Equiped.Add(thing);

                    armorCapacity--;
                    var temp = (PlateArmor)thing;
                    this.ChangeDefence(temp.DefRatingMod);
                    this.Inventory.Remove(thing);
                }
            }
        }

        public void UneqipArmour(Items thing)
        {
            if (thing is Armor)
            {
                Equiped.Remove(thing);
                Inventory.Add(thing);

                var temp = (PlateArmor)thing;
                this.ChangeDefence(-temp.DefRatingMod);

                armorCapacity++;
                
            }
        }

        public void EqipTrinket(Items thing)
        {
            if (thing is Trinket)
            {
                if (trinketCapacity > 0)
                {
                    Equiped.Add(thing);
                    var temp = (Trinket)thing;
                    attacks.Add(new HealAbility(temp));
                    this.ChangeHealth(temp.DmgValue);
                    trinketCapacity--;
                    this.Inventory.Remove(thing);
                }
            }
        }

        public void UneqipTrinket(Items thing)
        {
            Equiped.Remove(thing);
            Inventory.Add(thing);

            var temp = (Trinket)thing;
            var tempAbility = new HealAbility(temp);
            var toRemove = attacks.FirstOrDefault(w => w == tempAbility);
            
            attacks.Remove(toRemove);
            this.trinketCapacity++;
            

        }



        public int DoAttack(Enemy target, int n)
        {
            var r = -1;
            int ch = n;
            if (ch < 0) { return -1; }
            
            var tempattack = (Ability)attacks[ch];
            if (tempattack is LightAttackAbility)
            {
                if (this.Info.Stamina >= tempattack.StaminaEffect)
                {

                    r = this.DoAttack(target, tempattack);
                }
               
            }
            else if ( tempattack is LightMagicAbility )
            {
                if(this.Info.Mana>=tempattack.ManaEffect)
                {
                    r = this.DoAttack(target, tempattack);
                }
            }
            else if (tempattack is HealAbility)
            {
                 r = this.DoAttack(target, tempattack);

            }
             return r;
        }
        private int DoAttack(Enemy target, Ability a)
        {

            if(a is LightAttackAbility)
            {
                var skill = (LightAttackAbility)a;
                var action = skill.CreatAction(this, target);
                var resolution = action;
                var r=resolution.Resolve();
                return r;
            }
            else if(a is LightMagicAbility) 
            {
                var skill = (LightMagicAbility)a;
                var action = skill.CreatAction(this, target);
                var resolution = action;
                var r=resolution.Resolve();
                return r;
            }
            else
            {
                var skill = (HealAbility)a;
                var action = skill.CreatAction(this);
                var resolution = action;
                var r = resolution.Resolve();
                return r;
            }
            
            

            
        }
        public string InventoryList()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Inventory: ");
            foreach (var item in this.Equiped)
            {
                result.AppendLine(" - " + item.ToString());
            }

            return result.ToString();
        }

        public string[] AbilityList()
        {
            List<string> result = new List<string>();

            foreach (var item in attacks)
            {
                result.Add(item.ToString());

            }

            return result.ToArray();
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + this.InventoryList() + "AbilityList:\n - " + string.Join("\n - ", this.AbilityList());
        }
    }
}
