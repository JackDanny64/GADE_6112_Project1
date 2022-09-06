using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project1
{
    internal class Tile
    {
        private int x;
        private int y;

        public Tile(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
