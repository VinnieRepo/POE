using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task_1
{
    public abstract class Weapon : Item
    {
        protected int damage;
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        protected int range;
        public int Range
        {
            get { return range; }
            set { range = value; }
        }
        protected int durability;
        public int Durability
        {
            get { return durability; }
            set { durability = value; }
        }
        protected int cost;
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        private string weaponString;
        public string WeaponString
        {
            get { return weaponString; }
            set { weaponString = value; }
        }

        public Weapon(int x, int y, tile.Tiletypes Weapon) : base(x, y, "W",Tiletypes.Weapon)
        {

        }
    }
}
