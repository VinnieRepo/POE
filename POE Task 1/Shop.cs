using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task_1
{
     public class Shop
    {
        public Weapon[] weaponlist = new Weapon[3];
        Random r = new Random();
        Hero buyer;
        public Shop(Hero target)
        {
            buyer = target;
            randomWeapon();
        }

        private void randomWeapon()
        {
            for (int i = 0; i < weaponlist.Length; i++)
            {
                int weaponType = r.Next(0, 2);

                if (weaponType == 0)
                {
                    int meleeType = r.Next(0, 2);

                    weaponlist[i] = new MeleeWeapon(0, 0, tile.Tiletypes.MeleeWeapon, meleeType);
                }
                else
                {
                    int rangeType = r.Next(0, 2);
                    weaponlist[i] = new RangedWeapons(0, 0, tile.Tiletypes.RangedWeapon, rangeType);
                }

            }
        }

        public bool CanBuy(int place)
        {
            if (buyer.goldpurse >= weaponlist[place].Cost)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string displayWeapon(int num)
        {
            return "Weapon:  " + weaponlist[num].WeaponString + " " + weaponlist[num].Cost + "Cost";
        }

        public string Equippedweapon(int num)
        {
            return "Weapon:  " + weaponlist[num].WeaponString + "\r\n " + "Damage: " + weaponlist[num].Damage + "\r\n"+"Durability: "+weaponlist[num];
        }
        
    }
}

