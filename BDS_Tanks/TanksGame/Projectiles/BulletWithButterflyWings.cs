using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksGame.Projectiles
{
    class BulletWithButterflyWings : Projectile
    {
        public Rocket(int x, int y, int damage) : base(x, y, damage)
        {
            this.templateProvider = BoolTemplateProvider.Instace;

        }
    }
}
