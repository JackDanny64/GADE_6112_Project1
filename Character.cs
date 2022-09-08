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
        private int end1;

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
        public virtual void Attack(Character target)
        {
            if (DistanceTo(target) < 1) return;

            target.hp -= this.damage;
        }

        public bool isDead()
        {
            return (hp <= 0);

        }
        public virtual bool CheckRange(Character target)
        {
            if (DistanceTo(target) <= 1) ;

            return true;    

        }

        private int DistanceTo(Character target)
        {
           return Math.Abs(this.X - target.X) + Math.Abs(this.Y - target.Y) ;
        }

        public void Move(Movement move)
        {
            

            switch(move)
            {
                case Movement.Up: 
                    Y += 1;
                    break;
                case Movement.Down: 
                    Y -= 1;
                    break;
                case Movement.Left: 
                    X -= 1;
                    break;
                case Movement.Right: 
                    X += 1;
                    break;
                case Movement.noMovement:
                    break;

            }
        }
        
        


    }
}
