using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task_1
{
    class Leader : Enemy
    {
        private tile target;
        public tile Target 
        {
            get { return target; }
            set { target = value; } 
        }
        Random r;

        public Leader(int x, int y, tile[,] map, tile.Tiletypes Leader, int hp, int dam, Map mapL, int gold) : base(x, y, "L", Leader, hp, 20 , 5)
        {
            tilex = x;
            tiley = y;
            
        }

        //Fixed to work with player
        public override Movement returnmove(Movement move)
        {
            int direction = (int)move;
            // enum Move(up , down, left ,right)
            //             1,   2 ,   3,  4
            bool path = false;
            while (path == false)
            {
                if (direction == 1)
                {
                    // Move UP 
                    if (Vision[tiley - 1, tilex].tiletype == Tiletypes.Empty || Vision[tiley - 1, tilex].tiletype == Tiletypes.MeleeWeapon || Vision[tiley - 1, tilex].tiletype == Tiletypes.RangedWeapon && Vision[tiley - 1, tilex].tiletype != Tiletypes.Barrier)
                    {
                        path = true;
                        return move;
                    }
                    else
                    {
                        path = false;
                        return Movement.NoMovement;
                    }
                }
                else if (direction == 2)
                {
                    // Move Down
                    if (Vision[tiley + 1, tilex].tiletype == Tiletypes.Empty || Vision[tiley + 1, tilex].tiletype == Tiletypes.MeleeWeapon || Vision[tiley + 1, tilex].tiletype == Tiletypes.RangedWeapon && Vision[tiley + 1, tilex].tiletype != Tiletypes.Barrier)
                    {
                        path = true;
                        return move;
                    }
                    else
                    {
                        path = false;
                        return Movement.NoMovement;
                    }
                }
                else if (direction == 3)
                {
                    // Move Left
                     if (Vision[tiley , tilex -1].tiletype == Tiletypes.Empty || Vision[tiley , tilex - 1].tiletype == Tiletypes.MeleeWeapon || Vision[tiley , tilex - 1].tiletype == Tiletypes.RangedWeapon && Vision[tiley , tilex - 1].tiletype != Tiletypes.Barrier)
                    {
                        path = true;
                        return move;
                    }
                    else
                    {
                        path = false;
                        return Movement.NoMovement;
                    }
                }
                else
                {
                    // Move Left
                    if (Vision[tiley, tilex + 1].tiletype == Tiletypes.Empty || Vision[tiley, tilex + 1].tiletype == Tiletypes.MeleeWeapon || Vision[tiley, tilex + 1].tiletype == Tiletypes.RangedWeapon && Vision[tiley, tilex + 1].tiletype != Tiletypes.Barrier)
                    {
                        path = true;
                        return move;
                    }
                    else
                    {
                        path = false;
                        return Movement.NoMovement;
                    }
                }
            }
            return move;
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


