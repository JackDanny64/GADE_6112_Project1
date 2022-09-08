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

        }

        public bool isDead()
        {
            return (hp <= 0);

        }
        public virtual bool CheckRange(Character target)
        {

        }

        private int DistanceTo(Character target)
        {
           
            double distance = (Character - target).Length;
        }

        public void Move(Movement move)
        {
            

            switch(move)
            {
                case Movement.Up.cout <<"Up" << end1
                    break;
                case Movement.Down.cout << "Down" << end1
                    break;
                case Movement.Left.cout << "Left" << end1
                    break;
                case Movement.Right.cout << "Right" << end1
                    break;
                case Movement.noMovement.cout << "noMovement" << end1
                    break;

            }
        }



    }
}
