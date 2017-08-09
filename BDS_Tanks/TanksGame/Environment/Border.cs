using TanksGame.UI;

namespace TanksGame.Environment
{
    public class Border : IDrawable
    {
        public Border()
        {
            //this.Texture = this.GenerateBorder("border.txt");
            this.X = 0;
            this.Y = 0;
        }

        public Texture Texture { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        //public Texture GenerateBorder(string filename)
        //{
        //    var border = new List<IEnumerable<bool>>();

        //    using (StreamReader sr = new StreamReader("../../../../" + filename))
        //    {
        //        string line;
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            border.Add(line.Select(s => s.ToString() == "1" ? true : false).ToArray());
        //        }
        //    }
        //    Texture borderBody = new Texture(border, '.', ConsoleColor.Red);
        //    return borderBody;
        //}

    }
}