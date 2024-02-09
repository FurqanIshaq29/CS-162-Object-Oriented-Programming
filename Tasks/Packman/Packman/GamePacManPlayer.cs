using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GL
{
    class GamePacManPlayer : GameObject
    {
        public GamePacManPlayer(char character, GameCell startCell) : base(GameObjectType.PLAYER, character)
        {
            CurrentCell = startCell;
        }

        public void move(GamePacManPlayer pacmanPlayer, GameDirection direction)
        {
            if (direction == GameDirection.Up)
            {
                pacmanPlayer.CurrentCell.Y--;
            }

            else if (direction == GameDirection.Right)
            {
                pacmanPlayer.CurrentCell.X++;
            }

            else if (direction == GameDirection.Left)
            {
                pacmanPlayer.CurrentCell.X--;
            }

            else if (direction == GameDirection.Down)
            {
                pacmanPlayer.CurrentCell.Y++;
            }
        }
    }
}
