using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.UI;

namespace TanksGame.Environment
{
    class Border : IDrawable
    {
        public Border()
        {
            this.UnitBody = this.GenerateBorder("border.txt");
            this.X = 0;
            this.Y = 0;
        }

        public UnitBody UnitBody { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public UnitBody GenerateBorder(string filename)
        {
            var border = new List<IEnumerable<bool>>();

            using (StreamReader sr = new StreamReader("../../../../" + filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    border.Add(line.Select(s => s.ToString() == "1" ? true : false).ToArray());
                }
            }
            UnitBody borderBody = new UnitBody(border, '.', ConsoleColor.Red);
            return borderBody;
        }

    }
}
