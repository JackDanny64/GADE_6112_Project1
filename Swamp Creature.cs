using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project1
{
     abstract class Swamp_Creature : Enemy
    {
        public Swamp_Creature(int x, int y, int Hp, int MaxHp, int damage): base(x,y, Hp, MaxHp, damage)
        {
            Hp = 10;
            damage = 1;

        }
        public override void ReturnMove()
        {
            Random RndDirection = new Random();
            int RandomMove = RndDirection.Next(0,4);
            X = 1;
            Y = 1;
            
            if (RandomMove == 1)
            {
                Y++;
            }
            else if (RandomMove == 2)
            {
                X++;
            }
            else if(RandomMove == 3)
            {
                Y--;
            }
            else if(RandomMove == 0)
            {
                X++;
            }
            
                
                    
            

          

        }

    }
}
