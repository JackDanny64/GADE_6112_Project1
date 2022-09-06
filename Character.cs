using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project1
{
    abstract class Character : Tile
    {
        protected int hp;
        public int Healthpoints
        {
            get { return hp; }
        }
        protected int maxhp;

        public int Maxhp
        {
            get { return maxhp; }
        }
        protected int damage;
        public int Damage
        {
            get { return damage; } 
        }

        Tile[] arrayTiles = new Tile[4];
       protected Character(int x, int y) : base(x, y)
        {

        }
        public enum Movement
        {
            noMovement,
            Up,
            Down,
            Left,
            Right
        }
        
    }
}
