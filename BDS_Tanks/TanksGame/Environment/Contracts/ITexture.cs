using System.Collections.Generic;

namespace TanksGame.Environment.Contracts
{
    public interface ITexture
    {
        ICollection<IEnumerable<bool>> Body { get; }
    }
}