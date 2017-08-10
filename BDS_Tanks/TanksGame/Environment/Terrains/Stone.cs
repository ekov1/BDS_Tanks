﻿using System;
using TanksGame.Core.Providers;
using TanksGame.Environment.Contracts;

namespace TanksGame.Environment.Terrains
{
    public class Stone : Terrain
    {
        public Stone(int startX, int startY)
            : base(startX, startY)
        {

        }

        public override IFigureTexture FigureTexture
        {
            get
            {
                return new FigureTexture(BoolTemplateProvider.Instace.GetBoolTemplate("terrain"), '▒', ConsoleColor.DarkYellow);
            }
        }

        public override bool IsPassable
        {
            get
            {
                return false;
            }
        }

        public override bool IsDestructable
        {
            get
            {
                return false;
            }
        }
    }
}