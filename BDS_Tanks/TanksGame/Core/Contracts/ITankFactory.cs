using TanksGame.Contracts;
using TanksGame.Environment.Contracts;

namespace TanksGame.Core.Contracts
{
    public interface ITankFactory
    {
        ITank CreateTank(int x, int y, IFigureTexture texture);
    }
}