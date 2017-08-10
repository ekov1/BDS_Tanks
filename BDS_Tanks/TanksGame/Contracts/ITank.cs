using TanksGame.Core.Enums;
using TanksGame.UI;
using TanksGame.UI.Contracts;

namespace TanksGame.Contracts
{
    public interface ITank : IMovable, IDrawable, IShooting
    {
        string Name
        {
            get;
        }

        bool DefenseMode { get; }
        ProjectileType WeaponType { get; set; }
        
        void Attack();

        void Report();
    }
}