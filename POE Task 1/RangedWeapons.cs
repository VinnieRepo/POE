using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task_1
{
    class RangedWeapons : Weapon
    {
        public enum Types { Rifle, Longbow };
        public RangedWeapons(int x, int y, Tiletypes rweapon, int type) : base(x, y, rweapon)
        {
            chooseWeapon(type);
        }

        public void chooseWeapon(int choose)
        {
            switch (choose)
            {
                case 0:
                    WeaponString = "Rifle";
                    durability = 3;
                    damage = 5;
                    range = 3;
                    cost = 7;
                    break;
                case 1:
                    WeaponString = "Longbow";
                    durability = 4;
                    damage = 4;
                    range = 2;
                    cost = 6;
                    break;
               
                    
            }
        }

       
    }
}


