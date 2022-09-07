using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project1
{
    internal class Map
    {

        public int[,] MapLayout = new int[,]
        {
           {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
           {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
           {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
           {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
           {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
           {0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        };

        private class Hero {public float maximumhealth, currenthealth; }

        public class Enemy { public float MaximumHealth, CurrentHealth; }

        public Enemy[] enemy = new Enemy[]
        {
           

        };

    }
}
