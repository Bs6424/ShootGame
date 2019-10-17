using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootGame
{
     public class ShootLogic
    {
        public int Bullet;
        public int TotalBullet = 6;
        public int FireAwayChance= 2;

        
        public int Spin(int chance)
        {
            {
                if (chance == 6)
                {
                    chance = 1;
                }
                else
                {
                    chance++;
                }
                return chance;
            }
        }
        public int FireAway()
        {

            int score = 0;

            
            if (TotalBullet > 0 && TotalBullet == 1 && TotalBullet == 2)
            {
                score = 100;
            }
            if (TotalBullet > 0 && TotalBullet == 1 && TotalBullet == 1)
            {
                score = 50;
            }
            
            else if (TotalBullet > 0 && TotalBullet != 1)
            {
                score = 0;
                TotalBullet = TotalBullet - 1;
                Bullet = Spin(Bullet);
            }
            FireAwayChance--;


            return score;
        }

    }

}

