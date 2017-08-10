using TanksGame.Environment;
using TanksGame.UI.Contracts;

namespace TanksGame.UI.Contracts
{
    public interface IDrawable : IPosition
    {
        FigureTexture FigureTexture { get; }
    }
}