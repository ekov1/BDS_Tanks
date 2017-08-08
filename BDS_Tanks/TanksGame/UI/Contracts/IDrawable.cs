using TanksGame.Environment;

namespace TanksGame.UI
{
    public interface IDrawable
    {
        Texture Texture { get; set; }
        int X { get; set; }
        int Y { get; set; }
    }
}
