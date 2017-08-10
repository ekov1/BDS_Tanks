using System;
using System.Collections.Generic;
using System.Linq;
using TanksGame.Contracts;
using TanksGame.Core.Contracts;
using TanksGame.Core.Enums;
using TanksGame.Core.Providers;
using TanksGame.Environment.Terrains;

namespace TanksGame.Common
{
    public class Mover : IMover
    {
        private static readonly Mover instance = new Mover();
        private readonly IEnumerable<Terrain> terrain;

        private Mover()
        {
            this.terrain = TerrainProvider.Instance.Terrain;
        }
        
        private IEnumerable<int> OccupiedFields()
        {
            var occupiedFieldsX = new List<int>();

            foreach (var terr in terrain)
            {

            }


            return null;
        }

        public static Mover Instance
        {
            get
            {
                return instance;
            }
        }

        public bool Move(IMovable obj, Direction direction)
        {

            //switch (direction)
            //{
            //    case Direction.Top:
            //        foreach (var terr in this.terrain)
            //        {
            //            if (obj.Y - Constants.PlayerWidth == terr.Y)
            //            {
            //                return;
            //            }
            //        }
            //        break;
            //    case Direction.Down:
            //        foreach (var terr in this.terrain)
            //        {
            //            if (obj.Y + 1 == terr.Y )
            //            {
            //                return;
            //            }
            //        }
            //        break;
            //    case Direction.Left:
            //        foreach (var terr in this.terrain)
            //        {
            //            if (obj.X - 1 == terr.X)
            //            {
            //                return;
            //            }
            //        }
            //        break;
            //    case Direction.Right:
            //        foreach (var terr in this.terrain)
            //        {
            //            if (obj.X + 1 == terr.X + Constants.TerrainHeight)
            //            {
            //                return;
            //            }
            //        }
            //        break;
            //}
            bool collide = true;
            switch (direction)
            {
                case Direction.Top:
                    if (obj.Y - 1 >= 0)
                    {
                        obj.Y--;
                        collide = false;
                    }
                    break;
                case Direction.Down:
                    if (obj.Y + 1 < Constants.ConsoleHeight - Constants.PlayerHeight)
                    {
                        obj.Y++;
                        collide = false;
                    }
                    break;
                case Direction.Left:
                    if (obj.X - 1 >= 0)
                    {
                        obj.X--;
                        collide = false;
                    }
                    break;
                case Direction.Right:
                    if (obj.X + 1 < Constants.ConsoleWidth)
                    {
                        obj.X++;
                        collide = false;
                    }
                    break;
            }
            return collide;
            
        }
        
    }
}