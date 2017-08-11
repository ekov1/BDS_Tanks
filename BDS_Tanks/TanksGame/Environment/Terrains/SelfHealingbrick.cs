using System;
using TanksGame.Core.Contracts;
using TanksGame.Core.Enums;
using TanksGame.Core.Providers;
using TanksGame.Environment.Contracts;
using TanksGame.UI.Contracts;

namespace TanksGame.Environment.Terrains
{
    public class SelfHealingbrick : Brick, ITerrain, IDrawable, IPosition
    {
        private int health;

        public SelfHealingbrick(int startX, int startY)
            : base(startX, startY)
        {
            this.health = (int)HealthList.NormalBrickHealth;

        }

        // TODO:
        private void IncreaseHealth()
        {
            // if(time > condition)
            // health +++
        }

        public override IFigureTexture FigureTexture 
        {
            get
            {
                return new FigureTexture(BoolTemplateProvider.Instace.GetBoolTemplate("terrain"), '§', ConsoleColor.Red); ;
            }
        }
    }
}