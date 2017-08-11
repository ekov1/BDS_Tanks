using TanksGame.Environment.Contracts;

namespace TanksGame.UI.Contracts
{
    public interface IDrawable : IPosition
    {
        IFigureTexture FigureTexture { get;  }
    }
}