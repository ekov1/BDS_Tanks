using System;
using TanksGame.Core.Enums;
using TanksGame.Core.Providers;

namespace TanksGame.Environment.Terrains
{
    public class SteelBrick : Brick
    {
        private int health;

        public SteelBrick(int startX, int startY)
            : base(startX, startY)
        {
            this.health = (int)HealthList.SteelBrickHealth;
        }

        public override FigureTexture FigureTexture
        {
            get
            {
                return new FigureTexture(BoolTemplateProvider.Instace.GetBoolTemplate("terrain"), '±', ConsoleColor.Red); ;
            }
        }
    }
}