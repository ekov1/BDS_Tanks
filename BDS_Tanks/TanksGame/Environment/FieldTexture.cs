using System.Collections.Generic;
using TanksGame.Environment.Contracts;

namespace TanksGame.Environment
{
    public class FieldTexture : Texture, ITexture
    {
        public FieldTexture(ICollection<IEnumerable<bool>> body) : base(body)
        {
        }
    }
}