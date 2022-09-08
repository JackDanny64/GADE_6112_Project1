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

    }
}
