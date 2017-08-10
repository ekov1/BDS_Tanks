using System;
using TanksGame.Common;
using TanksGame.Core.Contracts;
using TanksGame.Core.Providers;
using TanksGame.Environment;
using TanksGame.Environment.Contracts;

namespace TanksGame.Projectiles
{
    public class MachineGun : Projectile
    {
        IBoolTemplateProvider templateProvider;


        public MachineGun(int x, int y)
            : base(x, y)
        {
            this.templateProvider = BoolTemplateProvider.Instace;

        }

        public override IFigureTexture FigureTexture
        {
            get
            {
                return new FigureTexture(this.templateProvider.GetBoolTemplate("machineGun"), '¤', ConsoleColor.Yellow);
            }
        }

        public override int Damage
        {
            get
            {
                return Constants.MachineGunDamage;
            }
        }
    }
}