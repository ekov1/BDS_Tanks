using System;
using TanksGame.Core.Providers;
using TanksGame.Environment.Contracts;

namespace TanksGame.Environment.Terrains
{
    public class Water : Terrain
    {
        public Water(int startX, int startY)
            : base(startX, startY)
        {
        }

        public override IFigureTexture FigureTexture
        {
            get
            {
                return new FigureTexture(BoolTemplateProvider.Instace.GetBoolTemplate("terrain"), '░', ConsoleColor.Cyan);
            }
        }

        public override bool IsPassable
        {
            get
            {
                return true;
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