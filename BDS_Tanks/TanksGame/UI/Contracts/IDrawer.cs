using System.Collections.Generic;

namespace TanksGame.UI
{
    public interface IDrawer
    {
        void Draw(IDrawable obj);
        void Draw(IEnumerable<IDrawable> items);
    }
}