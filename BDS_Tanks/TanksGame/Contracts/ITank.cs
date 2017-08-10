using TanksGame.UI;
using TanksGame.UI.Contracts;

namespace TanksGame.Contracts
{
    public interface ITank : IMovable, IDrawable
    {
        string Name
        {
            get;
        }
        IProjectile Weapon { get; set; }
        void Attack();
        void AddBullet();

        void Report();
    }
}