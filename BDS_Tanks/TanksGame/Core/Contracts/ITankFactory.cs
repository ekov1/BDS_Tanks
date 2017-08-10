using TanksGame.Contracts;
using TanksGame.Environment;

namespace TanksGame.Core.Contracts
{
    public interface ITankFactory
    {
        ITank CreateTank(int x, int y, FigureTexture texture, IProjectile weapon);
    }
}