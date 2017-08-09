using TanksGame.UI;
using TanksGame.UI.Contracts;

namespace TanksGame.Contracts
{
    public interface ITank : IMovable, IDrawable        
    {
        IProjectile  Weapon { get; set; }
        void Attack();
    }
}