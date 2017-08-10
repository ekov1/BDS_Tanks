using System;
using TanksGame.Core.Contracts;
using TanksGame.Core.Providers;
using TanksGame.Environment;

namespace TanksGame.Projectiles
{
    public class Rocket : Projectile
    {
        IBoolTemplateProvider templateProvider;
        

        public Rocket(int x, int y, int damage) : base(x, y, damage)
        {
            this.templateProvider = BoolTemplateProvider.Instace;

        }

        public override FigureTexture FigureTexture
        {
            get
            {
                return new FigureTexture(this.templateProvider.GetBoolTemplate("rocket"), 'º', ConsoleColor.Red);
            }
        }
    }
}