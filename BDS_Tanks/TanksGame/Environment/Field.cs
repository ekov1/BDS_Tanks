using System;
using System.Collections.Generic;
using TanksGame.Environment.Contracts;

namespace TanksGame.Environment
{
    // TODO: If enough time refactor it so it can work faster with bool matrix!
    public class Field : IField
    {
        private static readonly IField instance = new Field();
        private ICollection<string> occupiedFields;

        private Field()
        {
            occupiedFields = new List<string>();
        }

        public static IField Instance
        {
            get
            {
                return instance;
            }
        }

        public IEnumerable<string> OccupiedFields
        {
            get
            {
                return new List<string>(this.occupiedFields);
            }
        }

        public void OccupyField(int offsetX, int offsetY)
        {
            var occupiedField = Convert.ToString(offsetY) + Convert.ToString(offsetX);
            this.occupiedFields.Add(occupiedField);
        }

        public void UnOccupyField(int offsetX, int offsetY)
        {
            var occupiedField = Convert.ToString(offsetY) + Convert.ToString(offsetX);

            if (this.occupiedFields.Contains(occupiedField))
            {
                this.occupiedFields.Remove(occupiedField);
            }
        }
    }
}