using System;
using TanksGame.Contracts;
using TanksGame.Core.Contracts;
using TanksGame.Environment;
using TanksGame.Environment.Contracts;
using TanksGame.Player;

namespace TanksGame.Core.Factories
{
    public class TankFactory : ITankFactory
    {
        public ITank CreateTank(int x, int y, IFigureTexture figureTexture)
        {
            return new Tank(x, y, figureTexture);
        }
        
    }
}