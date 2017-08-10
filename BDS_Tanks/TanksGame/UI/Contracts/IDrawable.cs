using TanksGame.Environment;
using TanksGame.Environment.Contracts;
using TanksGame.UI.Contracts;

namespace TanksGame.UI.Contracts
{
    public interface IDrawable : IPosition
    {
        IFigureTexture FigureTexture { get;  }
    }
}