using System;
using System.Collections.Generic;
using TanksGame.Contracts;
using TanksGame.Core.Contracts;
using TanksGame.Core.Enums;
using TanksGame.Core.Providers;
using TanksGame.Environment;
using TanksGame.Environment.Contracts;

namespace TanksGame.Common
{
    public class Mover : IMover
    {
        private static readonly Mover instance = new Mover();
        private readonly IEnumerable<ITerrain> terrain;
        private IField field;

        private Mover()
        {
            this.terrain = TerrainProvider.Instance.Terrain;
            this.field = Field.Instance;
        }

        public static Mover Instance
        {
            get
            {
                return instance;
            }
        }

        // TODO: Implement moving projectiles
        public void MoveProjectile()
        {
            throw new NotImplementedException();
        }

        public bool MoveTank(IMovable obj, Direction direction)
        {
            bool collide = true;

            switch (direction)
            {
                case Direction.Top:
                    if (obj.Y - 1 >= 0)
                    {
                        obj.Y -= Constants.TankSpeed - 1;
                        collide = false;
                    }
                    break;
                case Direction.Down:
                    if (obj.Y + 1 < Constants.ConsoleHeight - Constants.PlayerHeight)
                    {
                        obj.Y+= Constants.TankSpeed - 1;
                        collide = false;
                    }
                    break;
                case Direction.Left:
                    if (obj.X - 1 > 0)
                    {
                        obj.X-= Constants.TankSpeed;
                        collide = false;
                    }
                    break;
                case Direction.Right:
                    if (obj.X + 1 < Constants.ConsoleWidth)
                    {
                        obj.X+= Constants.TankSpeed;
                        collide = false;
                    }
                    break;
            }

            return collide;
        }
    }
}