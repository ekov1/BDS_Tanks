using System;
using TanksGame.Core.Enums;
using TanksGame.Core.Providers;
using TanksGame.Environment.Contracts;

namespace TanksGame.Environment.Terrains
{
    public class NormalBrick : Brick
    {
        private int health; // Should be in Terrain and give it through the constructor

        public NormalBrick(int startX, int startY)
            : base(startX, startY)
        {
            this.health = (int)HealthList.NormalBrickHealth;
        }

        public override IFigureTexture FigureTexture
        {
            get
            {
                return new FigureTexture(BoolTemplateProvider.Instace.GetBoolTemplate("terrain"), '▓', ConsoleColor.Red); 
            }
        }
    }
}