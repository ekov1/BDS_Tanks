using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Common;
using TanksGame.Core.Contracts;
using TanksGame.Core.Providers;
using TanksGame.Environment;
using TanksGame.Environment.Contracts;

namespace TanksGame.Projectiles
{
    class BulletWithButterflyWings : Projectile
    {
        IBoolTemplateProvider templateProvider;

        public BulletWithButterflyWings(int x, int y) 
            : base(x, y)
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
