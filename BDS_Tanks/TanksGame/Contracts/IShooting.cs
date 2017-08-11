using System.Collections.Generic;

namespace TanksGame.Contracts
{
    public interface IShooting
    {
        ICollection<IProjectile> FiredProjectiles { get; }
    }
}