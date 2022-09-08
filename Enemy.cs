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
            x = random.Next(x);
            y = random.Next(y);
        }
        public static int EnemysDamage { get; }
        public static int StartingHp { get; }

        public int MaxHp = 10;
        public int damage = 10;
        
        static Enemy()
        {
           EnemysDamage= 10;
            StartingHp= 10;
         
        }

    }
}
