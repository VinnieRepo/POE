using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task_1
{
    class Shop
    {
        Weapon[] weaponlist = new Weapon[3];
        Random r = new Random();
        Hero buyer;
        public Shop(Hero target)
        {
            buyer = target;
            randomWeapon();
        }

        public void randomWeapon()
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
        public void Weapons(int num)
        {
            int weaponType = r.Next(0, 2);
            
            if (weaponType == 0)
            {
                int meleeType = r.Next(0, 2);
                weaponlist[num] = new MeleeWeapon(0, 0, tile.Tiletypes.MeleeWeapon, meleeType);
            }
            else
            {
                int rangeType = r.Next(0, 2);
                weaponlist[num] = new RangedWeapons(0, 0, tile.Tiletypes.RangedWeapon, rangeType);
            }
        }
    }
}

