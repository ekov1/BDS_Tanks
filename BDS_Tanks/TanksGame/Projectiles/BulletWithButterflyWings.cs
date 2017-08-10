using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Core.Contracts;
using TanksGame.Core.Providers;
using TanksGame.Environment;

namespace TanksGame.Projectiles
{
    class BulletWithButterflyWings : Projectile
    {
        IBoolTemplateProvider templateProvider;

        public BulletWithButterflyWings(int x, int y, int damage) : base(x, y, damage)
        {
            this.templateProvider = BoolTemplateProvider.Instace;

        }

        public override Texture Texture
        {
            get
            {
                return new Texture(this.templateProvider.GetBoolTemplate("BulletWithButterflyWings"), 'x', ConsoleColor.Red);
            }
        }
    }
}
