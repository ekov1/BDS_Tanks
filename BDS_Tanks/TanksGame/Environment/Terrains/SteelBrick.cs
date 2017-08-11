using System;
using TanksGame.Core.Contracts;
using TanksGame.Core.Enums;
using TanksGame.Core.Providers;
using TanksGame.Environment.Contracts;
using TanksGame.UI.Contracts;

namespace TanksGame.Environment.Terrains
{
    public class SteelBrick : Brick, ITerrain, IDrawable, IPosition
    {
        private int health;

        public SteelBrick(int startX, int startY)
            : base(startX, startY)
        {
            this.health = (int)HealthList.SteelBrickHealth;
        }

        public override IFigureTexture FigureTexture
        {
            get
            {
                return new FigureTexture(BoolTemplateProvider.Instace.GetBoolTemplate("terrain"), '±', ConsoleColor.Red); ;
            }
        }
    }
}