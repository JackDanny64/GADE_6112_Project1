using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project1
{
    internal class GameEngine
    {
        private Map map;
        private static readonly char
            HeroChar = 'H',
            SwampCreatureChar = 'Ω',
            ObstacleChar = '║',
            EmptyChar = ',';
        public GameEngine()
        {
            map = new Map(12, 16, 12, 16, 12);
        }
        public Map Map { get => map; }
        public bool MovePLayer(Character.Movement direction)
        {
            return false;
        }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < map.MapWidth_player; i++)
            {
                for (int j = 0; j < map.MapHeight_player; j++)
                {


                    switch (map.Map_player[i, j].Type)
                    {
                        case Tile.Tiletype.Hero:
                            stringBuilder.Append(HeroChar);
                            break;
                        case Tile.Tiletype.Obstacle:
                            stringBuilder.Append(ObstacleChar);
                            break;
                        case Tile.Tiletype.Enemy:
                            stringBuilder.Append(SwampCreatureChar);
                            break;
                        case Tile.Tiletype.EmptyTile:
                            stringBuilder.Append(EmptyChar);
                            break;
                        case Tile.Tiletype.Weapon:
                            break;
                        case Tile.Tiletype.Gold:
                            break;
                        default:
                            break;

                    }
                }
                stringBuilder.Append('\n');
            }

            return stringBuilder.ToString();
        }

        public bool MovePlayer(Character.Movement move)
        {
            bool cMove = false;
            if (move != Character.Movement.noMovement)
            {
                cMove = true;
            }
            return cMove;
        }

    }
}
