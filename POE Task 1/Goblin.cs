using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task_1
{
    public class Goblin : Enemy
    {
        private int goldvalue;
        public int Goldvalue
        {
            get { return goldvalue; }
            set { goldvalue = value; }
        }
        public Goblin(int tilex, int tiley, string symbolval, Tiletypes tiletype, int hp, int maxhp, int damage) : base(tilex, tiley, symbolval, tiletype, hp, maxhp, damage)
        {
            Goldvalue = 1;
        }

        //random movement
        public override Movement returnmove(Movement move = Movement.Up)
        {
            Random r = new Random();
            int num = r.Next(4);
            return (Movement)num;
        }
        public override bool CheckingRange(int target, int charpos)
        {
            int distance = target = charpos;
            if (distance <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
