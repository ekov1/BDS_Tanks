using System;
using TanksGame.Core.Contracts;
using TanksGame.Core.Providers;
using TanksGame.Environment;

namespace TanksGame.Projectiles
{
    public class MachineGun : Projectile
    {
        IBoolTemplateProvider templateProvider;
        

        public MachineGun(int x, int y, int damage) : base(x, y, damage)
        {
            this.templateProvider = BoolTemplateProvider.Instace;

        }

        public override FigureTexture FigureTexture
        {
            get
            {
                return new FigureTexture(this.templateProvider.GetBoolTemplate("machineGun"), '¤', ConsoleColor.Yellow);
            }
        }
    }
}