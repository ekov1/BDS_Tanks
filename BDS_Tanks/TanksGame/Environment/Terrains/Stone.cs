using System;
using TanksGame.Core.Contracts;
using TanksGame.Core.Providers;
using TanksGame.Environment.Contracts;
using TanksGame.UI.Contracts;

namespace TanksGame.Environment.Terrains
{
    public class Stone : Terrain, ITerrain, IDrawable, IPosition
    {
        public Stone(int startX, int startY)
            : base(startX, startY)
        {

        }

        public override IFigureTexture FigureTexture
        {
            get
            {
                return new FigureTexture(BoolTemplateProvider.Instace.GetBoolTemplate("terrain"), '▒', ConsoleColor.DarkYellow);
            }
        }

        public override bool IsPassable
        {
            get
            {
                return false;
            }
        }

        public override bool IsDestructable
        {
            get
            {
                return false;
            }
        }
    }
}