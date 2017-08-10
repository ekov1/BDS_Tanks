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

        bool DefenseMode { get; }

        IProjectile Weapon { get; set; }
        void Attack();
        void AddProjectile(IProjectile projectile);
     
        void Report();
    }
}