using System;
using TanksGame.Common;
using TanksGame.Contracts;
using TanksGame.Core.Contracts;
using TanksGame.Core.Enums;
using TanksGame.Core.Providers;
using TanksGame.Environment;
using TanksGame.Environment.Contracts;
using TanksGame.UI.Contracts;

namespace TanksGame.Projectiles
{
    public class BulletWithButterflyWings : Projectile, IProjectile, IMovable, IDrawable
    {
        IBoolTemplateProvider templateProvider;

        public BulletWithButterflyWings(int x, int y, Direction direction) 
            : base(x, y, direction)
        {
            this.templateProvider = BoolTemplateProvider.Instace;
        }

        public override IFigureTexture FigureTexture
        {
            get
            {
                return new FigureTexture(this.templateProvider.GetBoolTemplate("BulletWithButterflyWings"), 'x', ConsoleColor.Red);
            }
        }

        public override int Damage
        {
            get
            {
                return Constants.BulletWithButterflyWingsDamage;
            }
        }
    }
}
