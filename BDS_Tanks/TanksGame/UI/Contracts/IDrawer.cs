using System.Collections.Generic;
using TanksGame.UI.Contracts;

namespace TanksGame.UI
{
    public interface IDrawer
    {
        void Draw(IDrawable obj);

        void Draw(IEnumerable<IDrawable> items);
    }
}