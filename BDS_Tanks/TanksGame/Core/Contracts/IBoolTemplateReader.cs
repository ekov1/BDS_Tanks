using System.Collections.Generic;

namespace TanksGame.Core.Contracts
{
    public interface IBoolTemplateProvider
    {
        ICollection<IEnumerable<bool>> GetBoolTemplate(string filename);
    }
}