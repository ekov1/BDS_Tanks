using TanksGame.UI;

namespace TanksGame.Contracts
{
    public interface ITank : IMovable, IDrawable
    {
         void Attack();
    }
}