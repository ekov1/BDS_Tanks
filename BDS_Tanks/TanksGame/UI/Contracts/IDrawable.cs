using TanksGame.Environment;

namespace TanksGame.UI
{
    public interface IDrawable
    {
        Texture Texture { get; }
        int X { get; set; }
        int Y { get; set; }
    }
}