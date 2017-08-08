﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Environment.Terrains;

namespace TanksGame.Environment.Contracts
{
    public interface ITerrainGenerator
    {
        IEnumerable<Terrain> GenerateRandomMap(int terrainElementsCount);
    }
}
