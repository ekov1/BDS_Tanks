using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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