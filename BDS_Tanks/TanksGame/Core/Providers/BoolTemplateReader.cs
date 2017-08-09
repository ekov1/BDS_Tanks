using System.Collections.Generic;
using System.IO;
using System.Linq;
using TanksGame.Core.Contracts;

namespace TanksGame.Core.Providers
{
    public class BoolTemplateProvider : IBoolTemplateProvider
    {
        private static readonly BoolTemplateProvider instance = new BoolTemplateProvider();

        private IDictionary<string, ICollection<IEnumerable<bool>>> cache;

        private BoolTemplateProvider()
        {
            this.cache = new Dictionary<string, ICollection<IEnumerable<bool>>>();
        }

        public static BoolTemplateProvider Instace
        {
            get
            {
                return instance;
            }
        }

        public ICollection<IEnumerable<bool>> GetBoolTemplate(string filename)
        {
            if (this.cache.ContainsKey(filename))
            {
                return this.cache[filename];
            }

            var template = new List<IEnumerable<bool>>();

            using (StreamReader sr = new StreamReader("../../UI/Visuals/" + filename + ".txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    template.Add(line.Select(s => s.ToString() == "1" ? true : false).ToArray());
                }
            }

            this.cache[filename] = template;

            return template;
        }
    }
}