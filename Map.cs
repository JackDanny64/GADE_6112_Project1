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

        public Enemy[] enemies = new Enemy[]
        {
           

        };

        double MapWidth;
        double MapHeight;
        int random_num = new Random().Next(1, 10);

        public Map(double H, double W)
        {
            MapWidth = W;
            MapHeight = H;

        }


    }
}
