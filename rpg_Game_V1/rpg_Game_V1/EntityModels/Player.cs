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
                if(weaponCapacity > 0)
                {
                    Equiped.Add(thing);
                   
                    var temp = (Saber)thing;

                    attacks.Add(new LightAttackAbility(temp));
                    weaponCapacity--;
                }

                //else { Console.WriteLine("Not Allowed"); }
            }
        }

        public void UneqipWeapon(Items thing)
        {
            if(thing is Weapon)
            {
                Equiped.Remove(thing);
                Inventory.Add(thing);

                var temp = (Saber)thing;
                LightAttackAbility tempAbility = new LightAttackAbility(temp);
                var toRemove = attacks.FirstOrDefault(w => w == tempAbility);

                attacks.Remove(toRemove);

                weaponCapacity++;
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

        public void UneqipArmour(Items thing)
        {
            if (thing is Armor)
            {
                Equiped.Remove(thing);
                Inventory.Add(thing);

                var temp = (PlateArmor)thing;
                this.ChangeDefence(- temp.DefRatingMod);

                armorCapacity++;
            }
        }

        public int DoAttack(Enemy target, int n)
        {
            var r = -1;
            int ch = n;
            if (ch < 0) { return -1; }
            var tempattack = (LightAttackAbility)attacks[ch];
            if (this.Info.Stamina >= tempattack.StaminaEffect)
            {
                r = this.DoAttack(target, tempattack);
            }
            return r;
        }
        private int DoAttack(Enemy target, Ability a)
        {
            var skill = (LightAttackAbility)a;
            var action = skill.CreatAction(this, target);
            var resolution = action;
            var r=resolution.Resolve();

            return r;
        }
        public List<Items> InventoryList()
        {
            List<Items> inventory = new List<Items>();
            foreach(var item in Inventory)
            {
                inventory.Add(item);
            }
            return inventory;
        }

        public List<Weapon> GetWeaponsFromInventory()
        {
            List<Weapon> weapons = new List<Weapon>();
            weapons = Inventory.FindAll(w => w is Weapon).Select(w => w as Weapon).ToList();
            return weapons;

        }

        public List<Armor> GetArmourFromInventory()
        {
            List<Armor> armours = new List<Armor>();
            armours = Inventory.FindAll(a => a is Armor).Select(a => a as Armor).ToList();
            return armours;
        }

        public void PickWeaponToEquip(int index)
        {
            List<Weapon> weapons = GetWeaponsFromInventory();
            this.EquipWeapon(weapons[index]);
            this.Inventory.Remove(weapons[index]);
        }

        public void PickArmourToEqip(int index)
        {
            List<Armor> armours = GetArmourFromInventory();
            this.EquipArmor(armours[index]);
            this.Inventory.Remove(armours[index]);
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
