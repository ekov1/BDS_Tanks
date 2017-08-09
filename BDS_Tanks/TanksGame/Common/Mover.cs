using TanksGame.Contracts;

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

        public void Move(IMovable obj, int offsetX, int offsetY)
        {
            if (obj.X + offsetX >= 0 && obj.X + offsetX < Constants.ConsoleWidth)
            {
                obj.X += offsetX;
            }

            if (obj.Y + offsetY >= 0 && obj.Y + offsetY < Constants.ConsoleHeight - Constants.PlayerHeight)
            {
                obj.Y += offsetY;
            }
        }
    }
}