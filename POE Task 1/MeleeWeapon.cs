using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task_1
{
    class MeleeWeapon : Weapon
    {
        public enum Types 
        { 
            dagger, 
            longsword, 
            fist,
        }
        public override string ToString()
        {
            return WeaponString;
        }

       
        public MeleeWeapon(int x, int y, Tiletypes Mweapon, int type) : base(x, y, Mweapon)
        {
            range = 1;
            chooseWeapon(type);
        }

        public void chooseWeapon(int choose)
        {

            switch (choose)
            {
                case 0:
                    WeaponString = "Dagger";
                    durability = 10;
                    damage = 3;
                    cost = 3;
                    break;

                case 1:
                    WeaponString = "Longsword";
                    durability = 6;
                    damage = 4;
                    cost = 5;
                    break;
                
                default:
                    break;
            }
        }
    }
}


