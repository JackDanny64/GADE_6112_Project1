using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project1
{
    abstract class Enemy : Character
    {
        Random random = new Random();
        protected Enemy(int x, int y) : base(x, y)
        {
        }
        public int MaxHp = 10;
        public int damage = 10;
        
        static Enemy()
        {
           EnemysDamage= 10;
            StartingHp= 10;
            MaxHp= 10;
        }

    }
}
