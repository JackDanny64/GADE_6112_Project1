using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project1
{
    abstract class Swamp_Creature : Enemy
    {
        public Swamp_Creature(int x, int y, int Hp, int MaxHp, int damage) :base(x, y, Hp, MaxHp, damage)
        {
            Hp = 10;
            damage = 1;

        }
        public override Movement ReturnMove()
        {
            Random RndDirection = new Random();
            int RandomMove = RndDirection.Next(0, 4);
            bool loop = false;
            do
            {

                if (ArrayTiles[RandomMove] != Tiletype.EmptyTile)
                {
                    loop = true;
                }
            } while (loop);
            switch (RandomMove)
            {
                case 0:
                    return Movement.Up;
                case 1:
                    return Movement.Down;
                case 2:
                    return Movement.Left;
                case 3:
                    return Movement.Right;
                case 4:
                    return Movement.noMovement;
            }







        }
    }
    
}
