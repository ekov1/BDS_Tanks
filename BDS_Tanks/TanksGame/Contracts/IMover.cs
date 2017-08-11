using TanksGame.Core.Enums;

namespace TanksGame.Contracts
{
    public interface IMover
    {
        //Should be void
        bool MoveTank(IMovable obj, Direction direction);

        void MoveProjectile();
    }
}