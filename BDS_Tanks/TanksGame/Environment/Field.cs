using System.Collections.Generic;
using System.Linq;
using TanksGame.Core.Contracts;
using TanksGame.Core.Providers;
using TanksGame.Environment.Contracts;

namespace TanksGame.Environment
{
    public class Field : IField
    {
        private static readonly IField instance = new Field();
        public ICollection<IEnumerable<bool>> occupiedFields;
        private readonly IBoolTemplateProvider boolTemplateProvider;
        private List<List<bool>> casted;

        private Field()
        {
            this.boolTemplateProvider = BoolTemplateProvider.Instace;
            this.occupiedFields = this.boolTemplateProvider.GetBoolTemplate("field");
            this.casted = this.occupiedFields.Select(l => l.ToList()).ToList();
        }

        public static IField Instance
        {
            get
            {
                return instance;
            }
        }

        // Need to return interface ! And new instance instead of the existing one !
        public List<List<bool>> OccupiedFields
        {
            get
            {
                return this.casted;
            }
        }

        public void OccupyField(int offsetX, int offsetY)
        {
            this.casted[offsetY][offsetX] = true;
        }

        public void UnOccupyField(int offsetX, int offsetY)
        {
            this.casted[offsetY][offsetX] = false;
        }
    }
}