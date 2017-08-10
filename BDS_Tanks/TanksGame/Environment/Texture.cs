using System.Collections.Generic;
using TanksGame.Environment.Contracts;

namespace TanksGame.Environment
{
    public abstract class Texture : ITexture
    {
        public Texture(ICollection<IEnumerable<bool>> body)
        {
            this.Body = body;
        }

        public ICollection<IEnumerable<bool>> Body { get; }
    }
}