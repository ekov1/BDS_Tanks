using TanksGame.Contracts;
using TanksGame.Core.Enums;

namespace TanksGame.Common
{
    public class Mover : IMover
    {
        private static readonly Mover instance = new Mover();

        private Mover() { }

        public static Mover Instance
        {
            get
            {
                return instance;
            }
        }

        public void Move(IMovable obj, Direction direction)
        {
            switch(direction)
            {
                case Direction.Top:
                    if (obj.Y - 1 >= 0)
                    {
                        obj.Y--;
                    }
                    break;
                case Direction.Down:
                    if (obj.Y + 1 < Constants.ConsoleHeight - Constants.PlayerHeight)
                    {
                        obj.Y++;
                    }
                    break;
                case Direction.Left:
                    if (obj.X - 1 >= 0)
                    {
                        obj.X--;
                    }
                    break;
                case Direction.Right:
                    if (obj.X + 1 < Constants.ConsoleWidth)
                    {
                        obj.X++;
                    }
                    break;
            }
        }
    }
}